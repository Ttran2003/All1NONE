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
    public partial class NoteApp : Form
    {
        DataTable Notes = new DataTable();
        bool Edit = false;

        public NoteApp()
        {
            InitializeComponent();
            Application.VisualStyleState = VisualStyleState.NoneEnabled;
        }
        private void NoteApp_Load(object sender, EventArgs e)
        {
            Notes.Columns.Add("Title");
            Notes.Columns.Add("Note");

            SavedNotes.DataSource = Notes;
        }

        #region button


        private void LoadButton_Click(object sender, EventArgs e)
        {

            try
            {
                TitleName.Text = Notes.Rows[SavedNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                NoteName.Text = Notes.Rows[SavedNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                Edit = true;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Not a Valid Note. Please try again");
            }
        }

        private void NewNote_Click(object sender, EventArgs e)
        {
            TitleName.Text = "";
            NoteName.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Notes.Rows[SavedNotes.CurrentCell.RowIndex].Delete();
            }
            catch (System.NullReferenceException)
            {
               MessageBox.Show("Not a Valid Note. Please try again");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit)
                {
                    Notes.Rows[SavedNotes.CurrentCell.RowIndex]["Title"] = TitleName.Text;
                    Notes.Rows[SavedNotes.CurrentCell.RowIndex]["Note"] = NoteName.Text;
                }
                else
                {
                    Notes.Rows.Add(TitleName.Text, NoteName.Text);
                }
                TitleName.Text = "";
                NoteName.Text = "";
                Edit = false;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Not a Valid Note. Please try again");
            }
          
        }
        #endregion

        private void SavedNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            TitleName.Text = Notes.Rows[SavedNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteName.Text = Notes.Rows[SavedNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            Edit = true;
        }

        private void SavedNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
