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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                Tag newTag = new Tag() { Name = listBoxtag.Text };
                Contact newContact = new Contact()
                {
                    PhoneNum = long.Parse(textBoxPhoneNum.Text),
                    Email = textBoxEmail.Text,
                    Person = newPerson,
                    CreationDate = DateOnly.FromDateTime(DateTime.Now)
                    
                };
                newContact.Tags.Add(newTag);
                context.Contacts.Add(newContact);
                context.SaveChanges();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void FormCreate_Load(object sender, EventArgs e)
        {

            LoadTags(listBoxtag);
        }
    }
}
