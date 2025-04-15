using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manager_Graphical
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        public void AllTags(ListBox list)
        {
            using (var context = new ContactmanagerContext())
            {
                var people = context.People
                    .Include(p => p.Contacts)
                    .ThenInclude(c => c.Tags)
                    .ToList();

                foreach (var person in people)
                {

                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, Contact contact)
        {
            Tag newTag = new Tag() { Name = textBoxTag.Text };
            contact.Tags.Add(newTag);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
