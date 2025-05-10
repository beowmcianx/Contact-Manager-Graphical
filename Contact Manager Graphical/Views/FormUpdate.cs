using Contact_Manager_Graphical.Models;
using Contact_Manager_Graphical.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Contact_Manager_Graphical
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
            this.KeyPreview = true;
            AllContacts(listBox1);
            LoadTags(listBoxTags);
        }

        public void LoadTags(ListBox list)
        {

            using (var context = new ContactmanagerContext())
            {
                var Tag = context.Tags.ToList();
                list.Items.Clear();
                foreach (var tags in Tag)
                {

                    list.Items.Add(tags.Name);
                }
            }

        }
        public void AllContacts(ListBox list)
        {
            listBox1.Items.Clear();
            using (var context = new ContactmanagerContext())
            {
                var people = context.People
                    .Include(p => p.Contacts)
                    .ThenInclude(c => c.Tags)
                    .ToList();

                foreach (var person in people)
                {
                    string fullName = $"{person.FirstName} {person.SecondName}";
                    foreach (var contact in person.Contacts)
                    {
                        list.Items.Add($"{fullName}");
                    }
                }
            }

        }
        private void exportContactsToTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void exitescToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ContactmanagerContext())
                {
                    string[] contactname = listBox1.SelectedItem.ToString().Split(' ');
                    var person = context.People
                        .Include(c => c.Contacts)
                        .ThenInclude(c => c.Tags)
                        .FirstOrDefault(p => p.FirstName == contactname[0] && p.SecondName == contactname[1]);

                    var selectedTagName = listBoxTags.SelectedItem?.ToString();
                    var existingTag = context.Tags.FirstOrDefault(t => t.Name == selectedTagName);

                    if (person != null)
                    {
                        person.FirstName = textBoxFirstName.Text;
                        person.SecondName = textBoxSecondName.Text;
                        person.Address = textBoxAddress.Text;
                        person.BirthDate = textBoxBirthDate.Text != "" ? DateOnly.Parse(textBoxBirthDate.Text) : null;

                        var contact = person.Contacts.FirstOrDefault();
                        if (contact != null)
                        {
                            contact.PhoneNum = long.Parse(textBoxPhoneNum.Text);
                            contact.Email = textBoxEmail.Text;

                            if (existingTag != null && !contact.Tags.Contains(existingTag))
                            {
                                contact.Tags.Add(existingTag);
                            }
                        }

                        context.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Fill all necessary boxes!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string[] contactName = listBox1.SelectedItem.ToString().Split(' ');
            string firstName = contactName[0];
            string secondName = contactName.Length > 1 ? contactName[1] : "";

            using (var context = new ContactmanagerContext())
            {
                var person = context.People
                     .Include(p => p.Contacts)
                     .ThenInclude(c => c.Tags)
                    .FirstOrDefault(p => p.FirstName == firstName && p.SecondName == secondName);

                if (person != null)
                {
                    textBoxFirstName.Text = person.FirstName;
                    textBoxSecondName.Text = person.SecondName;
                    textBoxAddress.Text = person.Address;
                    textBoxBirthDate.Text = person.BirthDate?.ToString() ?? "";

                    var contact = person.Contacts.FirstOrDefault();
                    if (contact != null)
                    {
                        textBoxPhoneNum.Text = contact.PhoneNum.ToString();
                        textBoxEmail.Text = contact.Email;
                    }
                }
            }
        }

        private void textBoxTag_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxtag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
