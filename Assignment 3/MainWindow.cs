using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment_3
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// constructor that also loads the XML file on start and puts the information into the appropriate datagridview and listbox
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                //grabs the data from the data.xml file that was previously created
                string path = (txtOutputName.Text + ".xml");
                var results = Deserialize(path);
                //adds the student information into the listbox
                foreach (Student student in results)
                {
                    listBoxStudent.Items.Add(student);
                }

                this._students = results.ToArray();
            }
            catch (Exception e)
            {
                return;
            }
            //if there is data in the list box, disable the first panel and enable the second panel
            if (_students != null && _students.Count() > 0)
            {
                panelLocks = true;
            }
        }

        /// <summary>
        /// Initializing student array and using _ to denote a global variable for easy readability through program
        /// </summary>
        private Student[] _students = null;


        /// <summary>
        /// Declare the amount of students and number of assignments for each student. handle errors within assignment criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdNavigate_Click(object sender, EventArgs e)
        {
            int numStudents = 0;
            String numStudentsText = txtNumStudents.Text;

            //Making sure that the number of students is
            bool success = Int32.TryParse(txtNumStudents.Text, out numStudents);

            if (numStudents <= 0 || numStudents > 10 || success == false)
            {
                MessageBox.Show("Please enter a number between 0 and 10.");
                return;
            }
            //initializing the number of assignments to 0 and starting to grab the input for the number of assignments
            int numAssignments = 0;
            String studentScoreText = txtNumAssignments.Text;

            //making sure the input is valid, no less than 0 and no more than 99
            bool succeed = Int32.TryParse(txtNumAssignments.Text, out numAssignments);

            if (numAssignments <= 0 || numAssignments > 99 || !succeed)
            {
                MessageBox.Show("Please enter a number of assignments between 0 and 99");
                return;
            }
            //Creating the students with generic names Student #1, Student #2, etc.
            _students = new Student[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                _students[i] = new Student();
                _students[i].studentName = "Student #" + (i + 1);
                _students[i].studentID = i;

                _students[i].assignments = new Assignment[numAssignments];
                for (int j = 0; j < numAssignments; j++)
                {
                    _students[i].assignments[j] = new Assignment();
                    _students[i].assignments[j].assignmentScore = 0;
                    _students[i].assignments[j].assignmentID = j;
                }
            }

            //Disables the first panel where the amount of students and amount of assignments are first
            //Declared so they cannot be changed, and activates the next panel to allow us to modify names and scores
            pnlSetup.Enabled = false;
            pnlModify.Enabled = true;

            //Loading all of the students into a listBox
            foreach (Student student in _students)
            {
                listBoxStudent.Items.Add(student);
            }
        }
        /// <summary>
        /// Reset the assignment back to its initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReset_Click(object sender, EventArgs e)
        {
            //Enalbing setup panel and disabling modify panel. ALso resetting all variables back to original state
            pnlSetup.Enabled = true;
            pnlModify.Enabled = false;
            this.txtNumAssignments.Text = "0";
            this.txtNumStudents.Text = "0";
            _students = new Student[0];
            listBoxStudent.Items.Clear();
            txtUpdateStudentName.Text = "";


        }

        /// <summary>
        /// Update a students name from a generic name to a real name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdUpdateStudentName_Click(object sender, EventArgs e)
        {
            //Error handling to make sure a student is selected
            Student theSelectedStudent = getSelectedStudent();

            //Error handling to make sure we enter a name into the box to update
            if (theSelectedStudent == null)
            {
                return;
            }
            if (string.IsNullOrEmpty(txtUpdateStudentName.Text) || string.IsNullOrWhiteSpace(txtUpdateStudentName.Text))
            {
                MessageBox.Show("Please enter a name");
                return;
            }

            //Updates the selected students name in the list to the specified name from the user
            theSelectedStudent.studentName = txtUpdateStudentName.Text;
            //Saves the selected index so it does not have to be reselected when modifying scores
            int saveCurrentIndex = listBoxStudent.SelectedIndex;
            listBoxStudent.Items.Clear();
            foreach (Student student in _students)
            {
                listBoxStudent.Items.Add(student);
            }
            listBoxStudent.SelectedIndex = saveCurrentIndex;

        }

        /// <summary>
        /// Show the students names from the array in an easy to use listBox so the user can select which student to alter, make changes, and see the change live
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_students != null)
            {
                int index = listBoxStudent.SelectedIndex;
                Student theSelectedStudent = _students[index];
                String theNameOfTheSelectedStudent = theSelectedStudent.studentName;
                txtUpdateStudentName.Text = theNameOfTheSelectedStudent;
            }
        }
        /// <summary>
        /// After following assignment criteria (i.e. staying within the amount of previously selected assignments and forcing 
        /// the user to only enter grades greater than or = to 0, will allow the user to update the score by selecting an assignment to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSaveScore_Click(object sender, EventArgs e)
        {

            //Error handling to make sure a student is selected
            Student theSelectedStudent = getSelectedStudent();

            //Error handling to make sure the user cannot choose an assignment that is less than 0, is a string, or is greater than the specified number
            //of assignments from earlier
            if (theSelectedStudent == null)
            {
                return;
            }
            int savedAssignmentNum;

            bool assignmentRight = Int32.TryParse(txtEnterAssignmentNumber.Text, out savedAssignmentNum);
            //Assuming assignment 1 is the first possible assignment and assignment 0 is not a valid assignment
            if (savedAssignmentNum < 1 || savedAssignmentNum > theSelectedStudent.assignments.Count() || assignmentRight == false)
            {
                MessageBox.Show("Please enter a valid assignment number.");
                return;
            }
            //Creates a variable that finds the students assignment, converts it to an int
            Assignment requestedAssignment = theSelectedStudent.assignments[Convert.ToInt32(txtEnterAssignmentNumber.Text) - 1];
            int savedAssignmentScore;
            //error handling to make sure the assignment score is not less than 0 and is not a string
            bool scoreRight = Int32.TryParse(txtEnterAssignmentScore.Text, out savedAssignmentScore);

            if (savedAssignmentScore < 0 || scoreRight == false)
            {
                MessageBox.Show("Please enter a valid assignment score to be updated");
            }
            //Updates the assignment score
            requestedAssignment.assignmentScore = savedAssignmentScore;
        }

        /// <summary>
        /// Displays all of the students, their grades, their average grade, and their letter grade. 
        /// The grades will be determined from the syllabus using if else statements to choose the proper score for a given double averagegrade
        /// Also displays a datagrid for an easy to read format that shows all student scores for all assignments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdDisplayScores_Click(object sender, EventArgs e)
        {
            //Making a new scores window for less clustering of data
            ScoresWindow showScores = new ScoresWindow();
            //Finds the proper textbox from the second window
            TextBox findDisplayAllAssignments = (TextBox)showScores.Controls.Find("txtDisplayAllScores", true).FirstOrDefault();
            for (int i = 0; i < _students.Count(); i++)
            {
                //Gets the students name at the i'th index, then displays their average score, then displays their letter grade
                findDisplayAllAssignments.Text += _students[i].studentName.ToString();
                findDisplayAllAssignments.Text += "  Average Score: ";
                findDisplayAllAssignments.Text += _students[i].calculateAverageScore();
                findDisplayAllAssignments.Text += "  Letter Grade: ";

                //begin validation to see what letter grade is earned based off of calculatedAverageScore
                if (_students[i].calculateAverageScore() >= 93)
                {
                    findDisplayAllAssignments.Text += "A";
                }

                else if (_students[i].calculateAverageScore() >= 90 && _students[i].calculateAverageScore() <= 92.9)
                {
                    findDisplayAllAssignments.Text += "A-";
                }

                else if (_students[i].calculateAverageScore() >= 87 && _students[i].calculateAverageScore() <= 89.9)
                {
                    findDisplayAllAssignments.Text += "B+";
                }

                else if (_students[i].calculateAverageScore() >= 83 && _students[i].calculateAverageScore() <= 86.9)
                {
                    findDisplayAllAssignments.Text += "B";
                }
                else if (_students[i].calculateAverageScore() >= 80 && _students[i].calculateAverageScore() <= 82.9)
                {
                    findDisplayAllAssignments.Text += "B-";
                }
                else if (_students[i].calculateAverageScore() >= 77 && _students[i].calculateAverageScore() <= 79.9)
                {
                    findDisplayAllAssignments.Text += "C+";
                }
                else if (_students[i].calculateAverageScore() >= 73 && _students[i].calculateAverageScore() <= 76.9)
                {
                    findDisplayAllAssignments.Text += "C";
                }
                else if (_students[i].calculateAverageScore() >= 70 && _students[i].calculateAverageScore() <= 72.9)
                {
                    findDisplayAllAssignments.Text += "C-";
                }
                else if (_students[i].calculateAverageScore() >= 67 && _students[i].calculateAverageScore() <= 69.9)
                {
                    findDisplayAllAssignments.Text += "D+";
                }
                else if (_students[i].calculateAverageScore() >= 63 && _students[i].calculateAverageScore() <= 66.9)
                {
                    findDisplayAllAssignments.Text += "D";
                }
                else if (_students[i].calculateAverageScore() >= 60 && _students[i].calculateAverageScore() <= 62.9)
                {
                    findDisplayAllAssignments.Text += "D-";
                }
                else
                {
                    findDisplayAllAssignments.Text += "E";
                }
                findDisplayAllAssignments.Text += Environment.NewLine;
            }

            //Creating a datagrid to show all of the student's assignments in a table format for readability
            DataGridView findDataGrid = (DataGridView)showScores.Controls.Find("dgvAllAssignments", true).FirstOrDefault();
            findDataGrid.DataSource = studentAssignmentScoresData();


            //Calls ShowDialog to display the score window
            showScores.ShowDialog();
        }
        /// <summary>
        /// loads the student assignment scores into the data table
        /// </summary>
        /// <returns></returns>
        private DataTable studentAssignmentScoresData()
        {
            DataTable table = new DataTable()
                {
                    TableName = "data"
                };
            table.Columns.Add("Name".ToString());
            for (int i = 0; i < _students.FirstOrDefault().assignments.Count(); i++)
            {
                table.Columns.Add("Assignment #" + (i + 1).ToString());
            }
            foreach (Student student in _students)
            {
                DataRow dr = table.NewRow();
                dr["Name"] = student.studentName;
                foreach (Assignment assignment in student.assignments)
                {
                    dr["Assignment #" + (assignment.assignmentID + 1)] = assignment.assignmentScore;
                }
                table.Rows.Add(dr);
            }

            return table;
        }

        /// <summary>
        /// A method that was created to minimize code needed throughout program as the user must always have
        /// a student selected to either update their name and respective assignments scores
        /// </summary>
        /// <returns></returns>
        private Student getSelectedStudent()
        {
            if (listBoxStudent.SelectedItem == null)
            {
                MessageBox.Show("Please select a student");
                return null;
            }
            return _students[listBoxStudent.SelectedIndex];
            
        }
        /// <summary>
        /// method I had to make in order to successfully bypass the threading madness of winforms
        /// </summary>
        private void done()
        {
            lblOutputToFile.Text = "Finished writing to file.";
            btnOutputToFile.Enabled = true;
        }

        /// <summary>
        /// used to write to an xml file. uses an invoke method to clear the label after the thread has finished running
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outputToFile_Click(object sender, EventArgs e)
        {
            if(txtOutputName.TextLength == 0)
            {
                MessageBox.Show("Please enter a file name");
                return;
            }
            btnOutputToFile.Enabled = false;
            //tells the user that we are outputting to a file
            lblOutputToFile.Text = "Outputting to file. Please wait.";
            //begin the thread declarations
            Thread newThread = new Thread(new ThreadStart(delegate
            {
                
                //do work here
                XmlSerializer serializer = new XmlSerializer(typeof(Student[]));

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = Encoding.Unicode;
                settings.Indent = false;
                settings.OmitXmlDeclaration = false;

                string results = string.Empty;
                using (StringWriter textWriter = new StringWriter())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                    {
                        serializer.Serialize(xmlWriter, this._students);
                    }
                    results = textWriter.ToString();
                }
                //writes all of the appropriate information into a file called data.xml
                using (StreamWriter filewriter = new StreamWriter(txtOutputName.Text + ".xml"))
                {
                    //sleeps the thread for 2 seconds to simulate multi threading functioning properly
                    Thread.Sleep(2000); 
                    filewriter.Write(results);
                }
                //after the threading is complete, invoke this method in order to clear the label properly
                this.Invoke(new MethodInvoker(() => done()));                
            })); 
            //start the thread
            newThread.Start();  
        }
        /// <summary>
        /// used to read the XML file back in
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Student[] Deserialize(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Student[]));

            XmlReaderSettings settings = new XmlReaderSettings();
            // No settings need modifying here

            using (StreamReader textReader = new StreamReader(path))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    xmlReader.Read();
                    return serializer.Deserialize(xmlReader) as Student[];
                }
            }
        }
        /// <summary>
        /// Used to enable or disable panels depending on whether or not that is information populated in the listbox
        /// </summary>
        public bool panelLocks = false;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            pnlModify.Enabled = panelLocks;
            pnlSetup.Enabled = !panelLocks;
        }
        

    }
}
