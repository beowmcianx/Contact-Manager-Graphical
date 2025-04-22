namespace Contact_Manager_Graphical
{
    partial class FormCreate
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNum = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTag = new TextBox();
            listBox1 = new ListBox();
            ButtonCreateContact = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "SecondName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 116);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 206);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 266);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 328);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 5;
            label6.Text = "Tag";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(24, 56);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(125, 27);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(24, 116);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(125, 27);
            textBoxSecondName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(24, 166);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(24, 229);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(125, 27);
            textBoxPhoneNum.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(24, 289);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 10;
            // 
            // textBoxTag
            // 
            textBoxTag.Location = new Point(24, 360);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(125, 27);
            textBoxTag.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(305, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 324);
            listBox1.TabIndex = 12;
            // 
            // ButtonCreateContact
            // 
            ButtonCreateContact.Location = new Point(305, 377);
            ButtonCreateContact.Name = "ButtonCreateContact";
            ButtonCreateContact.Size = new Size(265, 47);
            ButtonCreateContact.TabIndex = 13;
            ButtonCreateContact.Text = "CREATE CONTACT";
            ButtonCreateContact.UseVisualStyleBackColor = true;
            ButtonCreateContact.Click += ButtonCreateContact_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 157);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 450);
            Controls.Add(label7);
            Controls.Add(ButtonCreateContact);
            Controls.Add(listBox1);
            Controls.Add(textBoxTag);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNum);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCreate";
            Text = "FormCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNum;
        private TextBox textBoxEmail;
        private TextBox textBoxTag;
        private ListBox listBox1;
        private Button ButtonCreateContact;
        private Label label7;
    }
}