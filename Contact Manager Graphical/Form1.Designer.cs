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
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            exitescToolStripMenuItem = new ToolStripMenuItem();
            exportContactsToTxtToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(363, 169);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 15;
            label3.Text = "Contact Info:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(36, 169);
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
            listBox2.Location = new Point(363, 200);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(393, 172);
            listBox2.TabIndex = 13;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(497, 96);
            button2.Name = "button2";
            button2.Size = new Size(156, 38);
            button2.TabIndex = 12;
            button2.Text = "ALL CONTACTS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(36, 65);
            label1.Name = "label1";
            label1.Size = new Size(266, 28);
            label1.TabIndex = 11;
            label1.Text = "Search By Name OR Number:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(362, 96);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 10;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(36, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 34);
            textBox1.TabIndex = 9;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(36, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 284);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBoxContacts_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(792, 36);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.LightGray;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitescToolStripMenuItem, exportContactsToTxtToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(54, 32);
            editToolStripMenuItem.Text = "File";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 539);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
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
        private Button button2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem exitescToolStripMenuItem;
        private ToolStripMenuItem exportContactsToTxtToolStripMenuItem;
    }
}
