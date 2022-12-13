using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinalProject

{
    public partial class Calendar : Form
    {

        // Create a list to store our to-do items
        List<string> calendarList = new List<string>();

        public Calendar()
        {
            InitializeComponent();
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
        }
        private void CalendarTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            // Get the selected date range from the calendar
            DateTime start = monthCalendar1.SelectionStart;
      

            // Add the start and end dates to the list box as events
            listBox1.Items.Add(ChooseEventTxt.Text + " | " + start.ToShortDateString() + " | " + ChooseTimeTxt1.Text + ":" + ChooseTimeTxt2.Text + ChooseAmPm.Text);
            calendarList.Add(ChooseEventTxt.Text + " | " + start.ToShortDateString() + " | " + ChooseTimeTxt1.Text + ":" + ChooseTimeTxt2.Text + ChooseAmPm.Text);

            // Update the list box
            UpdateListBox();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            calendarList.RemoveAt(listBox1.SelectedIndex);
            UpdateListBox();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Clear the list and the list box
            calendarList.Clear();
            UpdateListBox();
        }


        private void UpdateListBox()
        {

            // Clear the list box
            listBox1.Items.Clear();

            // Add each item in the list to the list box
            foreach (string item in calendarList)
            {
                listBox1.Items.Add(item);
            }
        }

       
        private void ChooseTimeTxt1_TextChanged(object sender, EventArgs e)
        {
        }


    }
}
