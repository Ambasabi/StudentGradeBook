using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{

    public partial class ScoresWindow : Form
    {
        public ScoresWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating a button that will close the second window that pops up to display students' grades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCloseSecondWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
    }
}
