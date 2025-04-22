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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            AllTags(listBox1);
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

        private void btn_UpdateTag_Click(object sender, EventArgs e)
        {
            using (var context = new ContactmanagerContext())
            {
                var contact = context.Contacts
                    .Include(c => c.Tags)
                    .FirstOrDefault();
                string newTagName = textBoxNewTag.Text.Trim();
                if (string.IsNullOrEmpty(newTagName))
                {
                    MessageBox.Show("Tag name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                listBox1.SelectedItem = newTagName;
                context.SaveChanges();
                textBoxNewTag.Clear();
            }
        }
    }
}
