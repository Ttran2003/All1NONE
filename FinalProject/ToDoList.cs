using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class ToDoList : Form
    {

        int step = 10;
        string number;

        // Create a list to store our to-do items
        List<string> toDoList = new List<string>();

        public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
        }

        #region BtnClick
        private void button1_Click(object sender, EventArgs e)
        {
            // Add the text in the text box to the list
            if (toDoList.Count == 10)
            {
                MessageBox.Show("Lets stick to 10!");
            }
            else
            {
                toDoList.Add(toDoTextBox.Text);
            }

            // Clear the text box
            toDoTextBox.Clear();

            // Update the list box
            UpdateListBox();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            // Remove the selected item from the list and update the list box
            toDoList.RemoveAt(toDoListBox.SelectedIndex);
            UpdateListBox();
            progressBar1.PerformStep();

            if (progressBar1.Value == progressBar1.Maximum)
            {
                // Display a message if the progress bar is full
                MessageBox.Show("Congratulations! You are one step to being the you, YOU want!");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear the list and the list box
            toDoList.Clear();
            UpdateListBox();
        }

        #endregion
        private void UpdateListBox()
        {
            // Clear the list box
            toDoListBox.Items.Clear();

            // Add each item in the list to the list box
            foreach (string item in toDoList)
            {
                toDoListBox.Items.Add(item);
            }
        }




        // Unfinished Improvments
        private void toDoTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UpOne_Click(object sender, EventArgs e)
        {
            progressBar1.Step = step++;
            number = Convert.ToString(step);
            StepCount.Text = number;
        }

        private void Down_Click(object sender, EventArgs e)
        {
            progressBar1.Step = step--;
            number = Convert.ToString(step);
            StepCount.Text = number;
        }

        private void StepCount_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
