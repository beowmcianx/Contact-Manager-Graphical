using Contact_Manager_Graphical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
        public void SoundEffectLoader(string sfx)
        {
            try
            {
                string soundPath = Path.Combine(Application.StartupPath, "Resources", sfx);
                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.Play();
                }
                else
                {
                    MessageBox.Show("Sound file not found at:\n" + soundPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
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
            try
            {
                using (var context = new ContactmanagerContext())
                {
                    if (listBoxtag.SelectedItem == null)
                    {
                        MessageBox.Show($"Fill all necessary boxes!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    var selectedTagName = listBoxtag.SelectedItem.ToString();
                    var existingTag = context.Tags.FirstOrDefault(t => t.Name == selectedTagName);

                    if (existingTag == null)
                    {
                        MessageBox.Show("The selected tag doesn't exist in the database.", "Invalid Tag", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Person newPerson = new Person()
                    {
                        FirstName = textBoxFirstName.Text,
                        SecondName = textBoxSecondName.Text,
                        Address = textBoxAddress.Text,
                        BirthDate = textBoxBirthDate.Text != "" ? DateOnly.Parse(textBoxBirthDate.Text) : null
                    };
                    context.People.Add(newPerson);

                    Contact newContact = new Contact()
                    {
                        PhoneNum = long.Parse(textBoxPhoneNum.Text),
                        Email = textBoxEmail.Text,
                        Person = newPerson,
                        CreationDate = DateOnly.FromDateTime(DateTime.Now)
                    };

                    SoundEffectLoader("Chicken_plop.wav");
                    newContact.Tags.Add(existingTag);
                    context.Contacts.Add(newContact);
                    context.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Invalid input: {ex.Message}", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void FormCreate_Load(object sender, EventArgs e)
        {
            LoadTags(listBoxtag); 
        }

        private void listBoxtag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
