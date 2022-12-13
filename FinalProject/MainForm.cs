using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
       

        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // This is where the different forms are opened based on user click
        #region FormClick
        private void Calculator_Click(object sender, EventArgs e)
        {
            var myForm = new CalcForm();
            if (Application.OpenForms.OfType<CalcForm>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void Calendar_Click(object sender, EventArgs e)
        {
            var myForm = new Calendar();
            if (Application.OpenForms.OfType<Calendar>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void Currency_Click(object sender, EventArgs e)
        {
            var myForm = new Currency();
            if (Application.OpenForms.OfType<Currency>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void Notes_Click(object sender, EventArgs e)
        {
            var myForm = new NoteApp();
            if (Application.OpenForms.OfType<NoteApp>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void Game_Click(object sender, EventArgs e)
        {
            var myForm = new GameForm();
            if (Application.OpenForms.OfType<GameForm>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void PhoneBook_Click(object sender, EventArgs e)
        {
            var myForm = new PhoneBook();
            if (Application.OpenForms.OfType<PhoneBook>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }

        private void ToDoList_Click(object sender, EventArgs e)
        {
            var myForm = new ToDoList();
            if (Application.OpenForms.OfType<ToDoList>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }
        private void Paint_Click(object sender, EventArgs e)
        {
            var myForm = new PaintApp();
            if (Application.OpenForms.OfType<PaintApp>().Any())
            {
                MessageBox.Show("Only One at a Time");
            }
            else
            {
                myForm.Show();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //Closes Everything Except Main Form

           CalcForm Calc = Application.OpenForms.OfType<CalcForm>().FirstOrDefault();
            if (Application.OpenForms.OfType<CalcForm>().Any())
                Calc.Close();
      

            Calendar Cal = Application.OpenForms.OfType<Calendar>().FirstOrDefault();
            if (Application.OpenForms.OfType<Calendar>().Any())
                Cal.Close();

            Currency Cur = Application.OpenForms.OfType<Currency>().FirstOrDefault();
            if (Application.OpenForms.OfType<Currency>().Any())
                Cur.Close();

            NoteApp Note = Application.OpenForms.OfType<NoteApp>().FirstOrDefault();
            if (Application.OpenForms.OfType<NoteApp>().Any())
                Note.Close();

            GameForm Game = Application.OpenForms.OfType<GameForm>().FirstOrDefault();
            if (Application.OpenForms.OfType<GameForm>().Any())
                Game.Close();

            PhoneBook Phone = Application.OpenForms.OfType<PhoneBook>().FirstOrDefault();
            if (Application.OpenForms.OfType<PhoneBook>().Any())
                Phone.Close();

            ToDoList ToDo = Application.OpenForms.OfType<ToDoList>().FirstOrDefault();
            if (Application.OpenForms.OfType<ToDoList>().Any())
                ToDo.Close();

            PaintApp Paint = Application.OpenForms.OfType<PaintApp>().FirstOrDefault();
            if (Application.OpenForms.OfType<PaintApp>().Any())
                Paint.Close();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
