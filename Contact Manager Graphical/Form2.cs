﻿using Contact_Manager_Graphical.Models;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            AllContacts(listBox1);
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
                    foreach (var contact in person.Contacts)
                    {
                        list.Items.Add($"{fullName}");
                    }
                }
            }

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
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void exitescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (var context = new ContactmanagerContext())
            {
                Person newPerson = new Person()
                {
                    FirstName = textBoxFirstName.Text,
                    SecondName = textBoxSecondName.Text,
                    Address = textBoxAddress.Text
                };
                Tag newTag = new Tag() { Name = textBoxTag.Text };
                Contact newContact = new Contact()
                {
                    PhoneNum = long.Parse(textBoxPhoneNum.Text),
                    Email = textBoxEmail.Text,
                    CreationDate = DateOnly.Parse(textBoxDate.Text)
                };
                newContact.Tags.Add(newTag);
                context.People.Add(newPerson);
                context.Contacts.Add(newContact);
                context.SaveChanges();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            using (var context = new ContactmanagerContext())
            {
                string[] contactname = listBox1.SelectedItem.ToString().Split(' ');
                Person person = context.People.FirstOrDefault(p => p.FirstName == contactname[0] && p.SecondName == contactname[1]);

                if (person != null)
                {
                    person.FirstName = textBoxFirstName.Text;
                    person.SecondName = textBoxSecondName.Text;
                    person.Address = textBoxAddress.Text;


                    context.SaveChanges();
                }
            }

         
        }
        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTag_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
