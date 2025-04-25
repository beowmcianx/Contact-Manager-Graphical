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
    public partial class FormTagMain : Form
    {
        public FormTagMain()
        {
            InitializeComponent();
            AllContacts(listBox1);
            AllTags(listBox2);
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
                var tags = context.Tags.ToList();
                list.Items.Clear();

                foreach (var tag in tags)
                { list.Items.Add(tag.Name); }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, Contact contact)
        {

        }

        private void btn_CreateTag_Click(object sender, EventArgs e)
        {
            using (var context = new ContactmanagerContext())
            {
                var contact = context.Contacts
                    .Include(c => c.Tags)
                    .FirstOrDefault();

                string tagName = textBoxTag.Text.Trim();
                if (string.IsNullOrEmpty(tagName))
                {
                    MessageBox.Show("Tag name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var existingTag = context.Tags.FirstOrDefault(t => t.Name == tagName);
                if (existingTag != null)
                {
                    MessageBox.Show("This tag already exists.", "Duplicate Tag", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Tag newTag = new Tag() { Name = tagName };
                contact.Tags.Add(newTag);
                context.SaveChanges();
                textBoxTag.Clear();
            }
        }

        private void btn_UpdateTag_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a tag to rename.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new ContactmanagerContext())
            {
                var contact = context.Contacts
                    .Include(c => c.Tags)
                    .FirstOrDefault();
                string newTagName = textBoxTag.Text.Trim();
                var tag = context.Tags.FirstOrDefault(t => t.Name == listBox2.SelectedItem.ToString());
                if (string.IsNullOrEmpty(newTagName))
                {
                    MessageBox.Show("Tag name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                tag.Name = newTagName;
                context.SaveChanges();
                textBoxTag.Clear();
            }
        }

        private void btn_DeleteTag_Click(object sender, EventArgs e)
        {/*
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a tag to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new ContactmanagerContext())
            {
                var contact = context.Contacts
                    .Include(c => c.Tags)
                    .FirstOrDefault();
                foreach(var tag in context.Tags)
                {
                    context.Tags.
                }
                context.Tags.Remove(listBox2.SelectedItem);
                context.SaveChanges();
            }*/
        }
    }
}
