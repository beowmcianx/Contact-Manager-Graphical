using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;

namespace Contact_Manager_Graphical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AllContacts(ListBox list)
        {
            using (var context = new ContactmanagerContext())
            {
                var people = context.People
                    .Include(p => p.Contacts)
                    .ThenInclude(c => c.Tags)
                    .ToList();

                foreach (var person in people)
                {
                    string fullName = $"{person.FirstName} {person.SecondName}";
                    list.Items.Add(fullName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            listBox1.Items.Clear();
            AllContacts(listBox1);
        }


        //Memory
        public void MemorySystem()
        {
            Directory.CreateDirectory("export");
            string filePath = "export/export.txt";
            var content = "";

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
                        content += $"{fullName} | Phone: {contact.PhoneNum}\n";
                    }
                }
            }
            File.WriteAllText(filePath, content);
        }

        private void exportContactsToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemorySystem();
            MessageBox.Show("Successfully saved all contacts to txt. file");
        }

        //Contact details in the second listBox
        private void listBoxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            var selectedContact = listBox1.SelectedItem.ToString();

            using (var context = new ContactmanagerContext())
            {
                string[] nameParts = selectedContact.Split('|')[0].Trim().Split(' ');
                string firstName = nameParts[0];
                string secondName = nameParts[1];

                var person = context.People
                    .Include(p => p.Contacts)
                    .ThenInclude(c => c.Tags)
                    .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == secondName);

                if (person != null)
                {
                    foreach (var contact in person.Contacts)
                    {
                        listBox2.Items.Add($"Phone: {contact.PhoneNum}");
                        listBox2.Items.Add($"Email: {contact.Email}");
                        listBox2.Items.Add($"Address: {person.Address}");
                        listBox2.Items.Add($"Birth date: {person.BirthDate}");

                        var tagNames = string.Join(", ", contact.Tags.Select(t => t.Name));
                        listBox2.Items.Add($"Tags: {tagNames}");

                        listBox2.Items.Add("---------------------------------------------------");
                        listBox2.Items.Add($"Contact Created: {contact.CreationDate}");
                    }
                }
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
            }
            listBox1.Items.Clear();
            string searchTerm = textBox1.Text.ToLower();

            using (var context = new ContactmanagerContext())
            {
                var filteredPeople = context.People
                    .Include(p => p.Contacts)
                    .ThenInclude(c => c.Tags)
                    .Where(p => (p.FirstName + " " + p.SecondName).ToLower().Contains(searchTerm) ||
                           p.Contacts.Any(c => c.PhoneNum.ToString().Contains(searchTerm) ||
                                               c.Tags.Any(t => t.Name.ToLower().Contains(searchTerm)))).ToList();

                if (searchTerm == string.Empty)
                {
                    var people = context.People
                    .Include(p => p.Contacts)
                    .ToList();

                    AllContacts(listBox1);
                }
                else
                {
                    foreach (var person in filteredPeople)
                    {
                        string fullName = $"{person.FirstName} {person.SecondName}";
                        foreach (var contact in person.Contacts)
                        {
                            listBox1.Items.Add($"{fullName}");
                        }
                    }
                }

            }
        }
        private void buttonAllContacts_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            using (var context = new ContactmanagerContext())
            {
                AllContacts(listBox1);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
        private void exitescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void createATagToolStripMenuItem_Click(object sender, EventArgs e)
        {
                var form3 = new Form3();
                form3.ShowDialog();

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var context = new ContactmanagerContext())
            {
                string[] contactname = listBox1.SelectedItem.ToString().Split(' ');
                Person person = context.People.FirstOrDefault(p => p.FirstName == contactname[0] && p.SecondName == contactname[1]);
                List<Contact> listContacts = context.Contacts.Where(c => person.PersonId == c.PersonId).Include(c => c.Tags).ToList();
                /*foreach (var contact in listContacts)
                {
                   var listContactTags = context.Contacts.Include(c=>c.Tags).ToList();
                }*/
                context.RemoveRange(listContacts);
                context.SaveChanges();
                context.People.Remove(person);
                context.SaveChanges();
            }
        }

        
    }

}
