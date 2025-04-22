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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
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
        private void ButtonCreateContact_Click(object sender, EventArgs e)
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
                    Person = newPerson
                };
                newContact.Tags.Add(newTag);
                context.Contacts.Add(newContact);
                context.SaveChanges();
            }
        }
    }
}
