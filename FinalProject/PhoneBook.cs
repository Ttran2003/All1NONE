using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class PhoneBook : Form
    {
        // Create a dictionary to store the phone book entries
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        public PhoneBook()
        {
            InitializeComponent();
        }

        private void PopulateListBox()
        {

            // Clear the list box
            listBox1.Items.Clear();

            // Add each entry in the phonebook to the list box
            foreach (KeyValuePair<string, string> entry in phonebook)
            {
                string name = entry.Key;
                string phone = entry.Value;
                string item = $"{name}: {phone}";
                listBox1.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Get the name and phone number from the text boxes
            string name = txtName.Text;
            string phone = txtPhone.Text;

            // Add the entry to the phonebook
            phonebook.Add(name, phone);

            // Clear the text boxes
            txtName.Clear();
            txtPhone.Clear();

            // Populate the list box with the entries in the phonebook
            PopulateListBox();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            {
                // Get the name to look up from the text box
                string name = txtName.Text;

                // Check if the name exists in the phonebook
                if (phonebook.ContainsKey(name))
                {
                    // If it exists, display the phone number
                    string phone = phonebook[name];
                    MessageBox.Show(phone);
                }
                else
                {
                    // If it does not exist, display an error message
                    MessageBox.Show("Error: No entry with that name exists in the phonebook.");
                }
            }
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
        }
    }
}