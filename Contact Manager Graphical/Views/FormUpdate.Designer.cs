namespace Contact_Manager_Graphical
{
    partial class FormUpdate
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
            buttonUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNum = new TextBox();
            textBoxEmail = new TextBox();
            listBox1 = new ListBox();
            label6 = new Label();
            textBoxBirthDate = new TextBox();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 15F);
            buttonUpdate.Location = new Point(260, 232);
            buttonUpdate.Margin = new Padding(5, 4, 5, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(237, 66);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(18, 33);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 2;
            label1.Text = "FirstName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(18, 117);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(169, 35);
            label2.TabIndex = 3;
            label2.Text = "SecondName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(18, 195);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 35);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(18, 270);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 35);
            label4.TabIndex = 5;
            label4.Text = "PhoneNum:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(18, 346);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 35);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(18, 65);
            textBoxFirstName.Margin = new Padding(5, 4, 5, 4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(205, 41);
            textBoxFirstName.TabIndex = 9;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(18, 149);
            textBoxSecondName.Margin = new Padding(5, 4, 5, 4);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(205, 41);
            textBoxSecondName.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(18, 227);
            textBoxAddress.Margin = new Padding(5, 4, 5, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(205, 41);
            textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(18, 302);
            textBoxPhoneNum.Margin = new Padding(5, 4, 5, 4);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(205, 41);
            textBoxPhoneNum.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(18, 378);
            textBoxEmail.Margin = new Padding(5, 4, 5, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(205, 41);
            textBoxEmail.TabIndex = 13;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(260, 26);
            listBox1.Margin = new Padding(5, 4, 5, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 144);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 430);
            label6.Name = "label6";
            label6.Size = new Size(164, 35);
            label6.TabIndex = 19;
            label6.Text = "Date Of Birth:";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Location = new Point(18, 468);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(205, 41);
            textBoxBirthDate.TabIndex = 20;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 541);
            Controls.Add(textBoxBirthDate);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNum);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormUpdate";
            Text = "Update Contact";
            Load += FormUpdate_Load;
            KeyDown += Form_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNum;
        private TextBox textBoxEmail;
        private ListBox listBox1;
        private Label label6;
        private TextBox textBoxBirthDate;
    }
}