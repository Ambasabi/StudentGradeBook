using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    /// <summary>
    /// Creating a Student class to minimize code needed
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Created a studentName string
        /// </summary>
        public string studentName { get; set; }
        /// <summary>
        /// Giving each student their own respective ID for more organized coding
        /// </summary>
        public int studentID { get; set; }

        /// <summary>
        /// Declaring an array of assignments
        /// </summary>
        public Assignment[] assignments { get; set; }

        /// <summary>
        /// A method that helps calculate the average scores of the student
        /// </summary>
        /// <returns></returns>
        public double calculateAverageScore()
        {
            double average = 0.0;
            for(int i = 0; i < assignments.Count(); i++)
            {
                average += assignments[i].assignmentScore;
            }
            return (average / assignments.Count());
        }
    }
}
