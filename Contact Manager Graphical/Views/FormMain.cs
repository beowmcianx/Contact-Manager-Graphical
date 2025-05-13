using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections.Generic;

namespace Contact_Manager_Graphical
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public void AllContacts(ListBox list)
        {
            using (var context = new ContactmanagerContext())
            {
                listBox1.Items.Clear();
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
            if (listBox1.SelectedItem == null)
                return;

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
            var form2 = new FormUpdate();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var formCreate = new FormCreate();
            if (formCreate.ShowDialog() == DialogResult.OK)
            {
                AllContacts(listBox1);
            }
        }

        private void createATagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form3 = new FormTagMain();
            form3.ShowDialog();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Select a contact to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string current = listBox1.SelectedIndex.ToString();
            int index = listBox1.FindString(current);
            if (index! > 0)
            {
                MessageBox.Show("Select an contact to delete!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using var context = new ContactmanagerContext();

            string[] contactname = listBox1.SelectedItem.ToString().Split(' ');
            var person = context.People.FirstOrDefault(p => p.FirstName == contactname[0] && p.SecondName == contactname[1]);
            if (person == null) return;

            var contacts = context.Contacts
                 .Where(c => c.PersonId == person.PersonId)
                 .Include(c => c.Tags)
                 .ToList();

            foreach (var contact in contacts)
            {
                contact.Tags.Clear();
            }
            context.SaveChanges();

            context.Contacts.RemoveRange(contacts);
            context.SaveChanges();
            context.People.Remove(person);
            context.SaveChanges();

            AllContacts(listBox1);
            listBox2.Items.Clear();
        }

        private void tagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formTagMain=new FormTagMain();
            formTagMain.ShowDialog();
        }
    }

}
