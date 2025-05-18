namespace Contact_Manager_Graphical
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label3 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            buttonAllContacts = new Button();
            label1 = new Label();
            buttonSearch = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            sAToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            exitescToolStripMenuItem = new ToolStripMenuItem();
            exportContactsToTxtToolStripMenuItem = new ToolStripMenuItem();
            tagsToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            buttonDelete = new Button();
            button4 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(388, 168);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 15;
            label3.Text = "Contact Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(26, 170);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 14;
            label2.Text = "All Contacts:";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(388, 199);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(393, 200);
            listBox2.TabIndex = 13;
            // 
            // buttonAllContacts
            // 
            buttonAllContacts.BackColor = Color.FromArgb(10, 30, 90);
            buttonAllContacts.FlatStyle = FlatStyle.Flat;
            buttonAllContacts.Font = new Font("Segoe UI", 15F);
            buttonAllContacts.ForeColor = Color.White;
            buttonAllContacts.Location = new Point(537, 93);
            buttonAllContacts.Name = "buttonAllContacts";
            buttonAllContacts.Size = new Size(182, 46);
            buttonAllContacts.TabIndex = 12;
            buttonAllContacts.Text = "ALL CONTACTS";
            buttonAllContacts.UseVisualStyleBackColor = false;
            buttonAllContacts.Click += buttonAllContacts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(26, 74);
            label1.Name = "label1";
            label1.Size = new Size(300, 28);
            label1.TabIndex = 11;
            label1.Text = "Search By Name, Number Or Tag:";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(10, 30, 90);
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 15F);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(388, 93);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(104, 46);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(26, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(26, 199);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(307, 340);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.FromArgb(10, 30, 90);
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sAToolStripMenuItem, editToolStripMenuItem, tagsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(825, 49);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // sAToolStripMenuItem
            // 
            sAToolStripMenuItem.AutoSize = false;
            sAToolStripMenuItem.BackColor = Color.LightGray;
            sAToolStripMenuItem.ForeColor = Color.LightGray;
            sAToolStripMenuItem.Image = (Image)resources.GetObject("sAToolStripMenuItem.Image");
            sAToolStripMenuItem.Margin = new Padding(5);
            sAToolStripMenuItem.Name = "sAToolStripMenuItem";
            sAToolStripMenuItem.Padding = new Padding(4, 5, 4, 0);
            sAToolStripMenuItem.Size = new Size(35, 35);
            sAToolStripMenuItem.ToolTipText = "ASASA";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.AutoSize = false;
            editToolStripMenuItem.BackColor = Color.LightGray;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitescToolStripMenuItem, exportContactsToTxtToolStripMenuItem });
            editToolStripMenuItem.Margin = new Padding(5);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Padding = new Padding(4, 5, 4, 0);
            editToolStripMenuItem.Size = new Size(50, 35);
            editToolStripMenuItem.Text = "File";
            // 
            // exitescToolStripMenuItem
            // 
            exitescToolStripMenuItem.BackColor = Color.LightGray;
            exitescToolStripMenuItem.Font = new Font("Segoe UI", 13F);
            exitescToolStripMenuItem.Name = "exitescToolStripMenuItem";
            exitescToolStripMenuItem.Size = new Size(257, 30);
            exitescToolStripMenuItem.Text = "Exit (esc)";
            exitescToolStripMenuItem.Click += exitescToolStripMenuItem_Click;
            // 
            // exportContactsToTxtToolStripMenuItem
            // 
            exportContactsToTxtToolStripMenuItem.BackColor = Color.LightGray;
            exportContactsToTxtToolStripMenuItem.Font = new Font("Segoe UI", 13F);
            exportContactsToTxtToolStripMenuItem.Name = "exportContactsToTxtToolStripMenuItem";
            exportContactsToTxtToolStripMenuItem.Size = new Size(257, 30);
            exportContactsToTxtToolStripMenuItem.Text = "Export contacts to .txt";
            exportContactsToTxtToolStripMenuItem.Click += exportContactsToTxtToolStripMenuItem_Click;
            // 
            // tagsToolStripMenuItem
            // 
            tagsToolStripMenuItem.AutoSize = false;
            tagsToolStripMenuItem.BackColor = Color.LightGray;
            tagsToolStripMenuItem.Margin = new Padding(5);
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Padding = new Padding(4, 5, 4, 5);
            tagsToolStripMenuItem.Size = new Size(50, 35);
            tagsToolStripMenuItem.Text = "Tags";
            tagsToolStripMenuItem.Click += tagsToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(10, 30, 90);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(583, 424);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(198, 47);
            button3.TabIndex = 17;
            button3.Text = "UPDATE ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(10, 30, 90);
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 15F);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(388, 424);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(189, 47);
            buttonDelete.TabIndex = 18;
            buttonDelete.Text = "DELETE ";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(10, 30, 90);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 15F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(388, 484);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(393, 52);
            button4.TabIndex = 19;
            button4.Text = "CREATE A CONTACT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(825, 577);
            Controls.Add(button4);
            Controls.Add(buttonDelete);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(buttonAllContacts);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            Text = "Contact Manager";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ListBox listBox2;
        private Button buttonAllContacts;
        private Label label1;
        private Button buttonSearch;
        private TextBox textBox1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem exitescToolStripMenuItem;
        private ToolStripMenuItem exportContactsToTxtToolStripMenuItem;
        private ToolStripMenuItem tagsToolStripMenuItem;
        private Button button3;
        private Button buttonDelete;
        private Button button4;
        private ToolStripMenuItem sAToolStripMenuItem;
    }
}
