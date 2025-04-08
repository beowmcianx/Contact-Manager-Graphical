using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Contact_Manager_Graphical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AllContacts()
        {
            using (var context = new ContactmanagerContext())
            {
                var people = context.People
                    .Include(p => p.Contacts)
                    .ToList();

                foreach (var person in people)
                {
                    string fullName = $"{person.FirstName} {person.SecondName}";
                    foreach (var contact in person.Contacts)
                    {
                        listBox1.Items.Add($"{fullName} | Phone: {contact.PhoneNum}");
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new ContactmanagerContext())
            {
                AllContacts();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string searchTerm = textBox1.Text.ToLower();

            using (var context = new ContactmanagerContext())
            {
                var filteredPeople = context.People
                    .Include(p => p.Contacts)
                    .Where(p => (p.FirstName + " " + p.SecondName).ToLower().Contains(searchTerm) ||
                                p.Contacts.Any(c => c.PhoneNum.ToString().Contains(searchTerm)))
                    .ToList();

                if (searchTerm == string.Empty)
                {
                    var people = context.People
                    .Include(p => p.Contacts)
                    .ToList();

                    AllContacts();
                }
                else
                {
                    foreach (var person in filteredPeople)
                    {
                        string fullName = $"{person.FirstName} {person.SecondName}";
                        foreach (var contact in person.Contacts)
                        {
                            listBox1.Items.Add($"{fullName} | Phone: {contact.PhoneNum}");
                        }
                    }
                }

            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            listBox1.Items.Clear();
            using (var context = new ContactmanagerContext())
            {
                AllContacts();
            }
        }
    }
}
