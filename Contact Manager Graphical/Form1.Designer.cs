namespace Contact_Manager_Graphical
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            buttonAllContacts = new Button();
            label1 = new Label();
            buttonSearch = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            exitescToolStripMenuItem = new ToolStripMenuItem();
            exportContactsToTxtToolStripMenuItem = new ToolStripMenuItem();
            button3 = new Button();
            button4 = new Button();
            tagsToolStripMenuItem = new ToolStripMenuItem();
            createATagToolStripMenuItem = new ToolStripMenuItem();
            updateTagToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(415, 225);
            label3.Name = "label3";
            label3.Size = new Size(156, 35);
            label3.TabIndex = 15;
            label3.Text = "Contact Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(41, 225);
            label2.Name = "label2";
            label2.Size = new Size(151, 35);
            label2.TabIndex = 14;
            label2.Text = "All Contacts:";
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 35;
            listBox2.Location = new Point(415, 267);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(449, 284);
            listBox2.TabIndex = 13;
            // 
            // buttonAllContacts
            // 
            buttonAllContacts.Font = new Font("Segoe UI", 15F);
            buttonAllContacts.Location = new Point(540, 128);
            buttonAllContacts.Margin = new Padding(3, 4, 3, 4);
            buttonAllContacts.Name = "buttonAllContacts";
            buttonAllContacts.Size = new Size(195, 41);
            buttonAllContacts.TabIndex = 12;
            buttonAllContacts.Text = "ALL CONTACTS";
            buttonAllContacts.UseVisualStyleBackColor = true;
            buttonAllContacts.Click += buttonAllContacts_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(41, 87);
            label1.Name = "label1";
            label1.Size = new Size(341, 35);
            label1.TabIndex = 11;
            label1.Text = "Search By Name OR Number:";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Segoe UI", 15F);
            buttonSearch.Location = new Point(414, 128);
            buttonSearch.Margin = new Padding(3, 4, 3, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(120, 41);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "SEARCH";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(41, 128);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 41);
            textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(41, 267);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 354);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, tagsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(944, 45);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.LightGray;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitescToolStripMenuItem, exportContactsToTxtToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(66, 39);
            editToolStripMenuItem.Text = "File";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // exitescToolStripMenuItem
            // 
            exitescToolStripMenuItem.BackColor = Color.LightGray;
            exitescToolStripMenuItem.Font = new Font("Segoe UI", 13F);
            exitescToolStripMenuItem.Name = "exitescToolStripMenuItem";
            exitescToolStripMenuItem.Size = new Size(310, 34);
            exitescToolStripMenuItem.Text = "Exit (esc)";
            exitescToolStripMenuItem.Click += exitescToolStripMenuItem_Click;
            // 
            // exportContactsToTxtToolStripMenuItem
            // 
            exportContactsToTxtToolStripMenuItem.BackColor = Color.LightGray;
            exportContactsToTxtToolStripMenuItem.Font = new Font("Segoe UI", 13F);
            exportContactsToTxtToolStripMenuItem.Name = "exportContactsToTxtToolStripMenuItem";
            exportContactsToTxtToolStripMenuItem.Size = new Size(310, 34);
            exportContactsToTxtToolStripMenuItem.Text = "Export contacts to .txt";
            exportContactsToTxtToolStripMenuItem.Click += exportContactsToTxtToolStripMenuItem_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(664, 580);
            button3.Name = "button3";
            button3.Size = new Size(226, 41);
            button3.TabIndex = 17;
            button3.Text = "UPDATE CONTACT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(415, 580);
            button4.Name = "button4";
            button4.Size = new Size(243, 41);
            button4.TabIndex = 18;
            button4.Text = "CREATE A CONTACT";
            button4.UseVisualStyleBackColor = true;
            // 
            // tagsToolStripMenuItem
            // 
            tagsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createATagToolStripMenuItem, updateTagToolStripMenuItem });
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Size = new Size(78, 39);
            tagsToolStripMenuItem.Text = "Tags";
            // 
            // createATagToolStripMenuItem
            // 
            createATagToolStripMenuItem.Name = "createATagToolStripMenuItem";
            createATagToolStripMenuItem.Size = new Size(270, 40);
            createATagToolStripMenuItem.Text = "Create new tag";
            // 
            // updateTagToolStripMenuItem
            // 
            updateTagToolStripMenuItem.Name = "updateTagToolStripMenuItem";
            updateTagToolStripMenuItem.Size = new Size(270, 40);
            updateTagToolStripMenuItem.Text = "Update tags";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 653);
            Controls.Add(button4);
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
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
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
        private Button button3;
        private Button button4;
        private ToolStripMenuItem tagsToolStripMenuItem;
        private ToolStripMenuItem createATagToolStripMenuItem;
        private ToolStripMenuItem updateTagToolStripMenuItem;
    }
}
