namespace Contact_Manager_Graphical
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreate = new Button();
            buttonUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNum = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTag = new TextBox();
            textBoxDate = new TextBox();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            exitescToolStripMenuItem = new ToolStripMenuItem();
            exportContactsToTxtToolStripMenuItem = new ToolStripMenuItem();
            tagsToolStripMenuItem = new ToolStripMenuItem();
            createATagToolStripMenuItem = new ToolStripMenuItem();
            updateTagToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Segoe UI", 15F);
            buttonCreate.Location = new Point(373, 563);
            buttonCreate.Margin = new Padding(5, 4, 5, 4);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(129, 41);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 15F);
            buttonUpdate.Location = new Point(599, 563);
            buttonUpdate.Margin = new Padding(5, 4, 5, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(129, 41);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(24, 85);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 2;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(24, 160);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 28);
            label2.TabIndex = 3;
            label2.Text = "SecondName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(24, 234);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(24, 307);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 5;
            label4.Text = "PhoneNum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(24, 382);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(24, 456);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 28);
            label6.TabIndex = 7;
            label6.Text = "CreationDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(24, 529);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 28);
            label7.TabIndex = 8;
            label7.Text = "Tag";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(24, 117);
            textBoxFirstName.Margin = new Padding(5, 4, 5, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(205, 34);
            textBoxFirstName.TabIndex = 9;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(24, 191);
            textBoxSecondName.Margin = new Padding(5, 4, 5, 4);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(205, 34);
            textBoxSecondName.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(24, 266);
            textBoxAddress.Margin = new Padding(5, 4, 5, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(205, 34);
            textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(24, 339);
            textBoxPhoneNum.Margin = new Padding(5, 4, 5, 4);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(205, 34);
            textBoxPhoneNum.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(24, 413);
            textBoxEmail.Margin = new Padding(5, 4, 5, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 34);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(24, 563);
            textBoxTag.Margin = new Padding(5, 4, 5, 4);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(205, 34);
            textBoxTag.TabIndex = 15;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(24, 488);
            textBoxDate.Margin = new Padding(5, 4, 5, 4);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(205, 34);
            textBoxDate.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(373, 117);
            listBox1.Margin = new Padding(5, 4, 5, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 424);
            listBox1.TabIndex = 17;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.AppWorkspace;
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, tagsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 4, 0, 4);
            menuStrip1.Size = new Size(801, 40);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.LightGray;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitescToolStripMenuItem, exportContactsToTxtToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(54, 32);
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
            tagsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createATagToolStripMenuItem, updateTagToolStripMenuItem });
            tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            tagsToolStripMenuItem.Size = new Size(62, 32);
            tagsToolStripMenuItem.Text = "Tags";
            // 
            // createATagToolStripMenuItem
            // 
            createATagToolStripMenuItem.Name = "createATagToolStripMenuItem";
            createATagToolStripMenuItem.Size = new Size(214, 32);
            createATagToolStripMenuItem.Text = "Create new tag";
            // 
            // updateTagToolStripMenuItem
            // 
            updateTagToolStripMenuItem.Name = "updateTagToolStripMenuItem";
            updateTagToolStripMenuItem.Size = new Size(214, 32);
            updateTagToolStripMenuItem.Text = "Update tags";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 657);
            Controls.Add(menuStrip1);
            Controls.Add(listBox1);
            Controls.Add(textBoxDate);
            Controls.Add(textBoxTag);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNum);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonCreate);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form2";
            Text = "Update Contact";
            KeyDown += Form_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private Button buttonUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNum;
        private TextBox textBoxEmail;
        private TextBox textBoxTag;
        private TextBox textBoxDate;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem exitescToolStripMenuItem;
        private ToolStripMenuItem exportContactsToTxtToolStripMenuItem;
        private ToolStripMenuItem tagsToolStripMenuItem;
        private ToolStripMenuItem createATagToolStripMenuItem;
        private ToolStripMenuItem updateTagToolStripMenuItem;
    }
}