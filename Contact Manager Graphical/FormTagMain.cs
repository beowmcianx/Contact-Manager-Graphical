using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Contact_Manager_Graphical
{
    public partial class FormTagMain : Form
    {
        public FormTagMain()
        {
            InitializeComponent();
            AllTags(listBox2);
        }

        public void AllTagContacts(ListBox list, ListBox list2)
        {
            list.Items.Clear();
            if (list2.SelectedItem == null)
                return;
            var selectedTagName = list2.SelectedItem.ToString();
            using (var context = new ContactmanagerContext())
            {

                var selectedTag = context.Contacts
                    .Include(t => t.Person) 
                    .Include(t => t.Tags)
                    .Where(c => c.Tags.Any(t => t.Name == selectedTagName)).ToList();


                if (selectedTag != null)
                {
                    foreach (var contact in selectedTag)
                    {
                        string fullName = $"{contact.Person.FirstName} {contact.Person.SecondName}";
                        list.Items.Add(fullName);
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
                context.Tags.Add(newTag);
                context.SaveChanges();
                textBoxTag.Clear();
                listBox2.Items.Clear();
                AllTags(listBox2);
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
                listBox2.Items.Clear();
                AllTags(listBox2);
            }
        }

        private void btn_DeleteTag_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a tag to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var context = new ContactmanagerContext())
                {
                    var selectedTagName = listBox2.SelectedItem.ToString();
                    var tagToDelete = context.Tags.FirstOrDefault(t => t.Name == selectedTagName);

                    if (tagToDelete != null)
                    {
                        context.Tags.Remove(tagToDelete);
                        context.SaveChanges();
                        listBox2.Items.Clear();
                        AllTags(listBox2);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Tag should not be connected to a contact. Please remove the contact before deleting this tag.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DetatchContacts_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a tag to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var context = new ContactmanagerContext())
            {
                var selectedTagName = listBox2.SelectedItem.ToString();
                var selectedTag = context.Contacts
                    .Include(t => t.Person)
                    .Include(t => t.Tags)
                    .Where(c => c.Tags.Any(t => t.Name == selectedTagName)).ToList();
                foreach (var contact in selectedTag)
                {
                    contact.Tags.Clear();
                }
                context.SaveChanges();
                listBox2.Items.Clear();
                listBox1.Items.Clear();
                AllTags(listBox2);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            AllTagContacts(listBox1, listBox2);
        }
    }
}
