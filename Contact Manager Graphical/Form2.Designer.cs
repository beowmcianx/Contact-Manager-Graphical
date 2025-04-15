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
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(540, 397);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += button1_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(694, 397);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 3;
            label2.Text = "SecondName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 5;
            label4.Text = "PhoneNum";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 228);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 6;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 281);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 7;
            label6.Text = "CreationDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 334);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 8;
            label7.Text = "Tag";
            label7.Click += label7_Click;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(12, 39);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 27);
            textBoxFirstName.TabIndex = 9;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(12, 92);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(150, 27);
            textBoxSecondName.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 145);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(150, 27);
            textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(12, 198);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(150, 27);
            textBoxPhoneNum.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 251);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 27);
            textBoxEmail.TabIndex = 13;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(12, 357);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(150, 27);
            textBoxTag.TabIndex = 15;
            textBoxTag.TextChanged += textBoxTag_TextChanged;
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(12, 304);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(150, 27);
            textBoxDate.TabIndex = 16;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(540, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 364);
            listBox1.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form2";
            Text = "Update Contact";
            KeyDown += Form2_KeyDown;
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
    }
}