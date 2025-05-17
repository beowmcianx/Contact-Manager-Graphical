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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxFirstName = new TextBox();
            textBoxSecondName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhoneNum = new TextBox();
            textBoxEmail = new TextBox();
            ButtonCreateContact = new Button();
            label7 = new Label();
            listBoxtag = new ListBox();
            label3 = new Label();
            textBoxBirthDate = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(28, 41);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(31, 130);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 1;
            label2.Text = "Second Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(254, 41);
            label4.Name = "label4";
            label4.Size = new Size(148, 28);
            label4.TabIndex = 3;
            label4.Text = "Phone Number:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(257, 124);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(28, 306);
            label6.Name = "label6";
            label6.Size = new Size(46, 28);
            label6.TabIndex = 5;
            label6.Text = "Tag:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 15F);
            textBoxFirstName.Location = new Point(28, 71);
            textBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(168, 34);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Font = new Font("Segoe UI", 15F);
            textBoxSecondName.Location = new Point(31, 160);
            textBoxSecondName.Margin = new Padding(3, 2, 3, 2);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(165, 34);
            textBoxSecondName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 15F);
            textBoxAddress.Location = new Point(31, 240);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(165, 34);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Font = new Font("Segoe UI", 15F);
            textBoxPhoneNum.Location = new Point(255, 71);
            textBoxPhoneNum.Margin = new Padding(3, 2, 3, 2);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(168, 34);
            textBoxPhoneNum.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 15F);
            textBoxEmail.Location = new Point(255, 154);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(168, 34);
            textBoxEmail.TabIndex = 10;
            // 
            // ButtonCreateContact
            // 
            ButtonCreateContact.BackColor = Color.FromArgb(20, 40, 90);
            ButtonCreateContact.FlatStyle = FlatStyle.Flat;
            ButtonCreateContact.Font = new Font("Segoe UI", 15F);
            ButtonCreateContact.ForeColor = Color.White;
            ButtonCreateContact.Location = new Point(254, 392);
            ButtonCreateContact.Margin = new Padding(3, 2, 3, 2);
            ButtonCreateContact.Name = "ButtonCreateContact";
            ButtonCreateContact.Size = new Size(172, 53);
            ButtonCreateContact.TabIndex = 13;
            ButtonCreateContact.Text = "CREATE";
            ButtonCreateContact.UseVisualStyleBackColor = false;
            ButtonCreateContact.Click += ButtonCreateContact_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(28, 210);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 14;
            label7.Text = "Address:";
            // 
            // listBoxtag
            // 
            listBoxtag.Font = new Font("Segoe UI", 15F);
            listBoxtag.FormattingEnabled = true;
            listBoxtag.ItemHeight = 28;
            listBoxtag.Location = new Point(31, 329);
            listBoxtag.Margin = new Padding(3, 2, 3, 2);
            listBoxtag.Name = "listBoxtag";
            listBoxtag.SelectionMode = SelectionMode.MultiExtended;
            listBoxtag.Size = new Size(165, 116);
            listBoxtag.TabIndex = 17;
            listBoxtag.SelectedIndexChanged += listBoxtag_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(255, 205);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 18;
            label3.Text = "Date Of Birth:";
            // 
            // textBoxBirthDate
            // 
            textBoxBirthDate.Font = new Font("Segoe UI", 15F);
            textBoxBirthDate.Location = new Point(255, 235);
            textBoxBirthDate.Margin = new Padding(3, 2, 3, 2);
            textBoxBirthDate.Name = "textBoxBirthDate";
            textBoxBirthDate.Size = new Size(167, 34);
            textBoxBirthDate.TabIndex = 19;
            // 
            // FormCreate
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(460, 473);
            Controls.Add(textBoxBirthDate);
            Controls.Add(label3);
            Controls.Add(listBoxtag);
            Controls.Add(label7);
            Controls.Add(ButtonCreateContact);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhoneNum);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxSecondName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCreate";
            Text = "FormCreate";
            Load += FormCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxFirstName;
        private TextBox textBoxSecondName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhoneNum;
        private TextBox textBoxEmail;
        private Button ButtonCreateContact;
        private Label label7;
        private ListBox listBoxtag;
        private Label label3;
        private TextBox textBoxBirthDate;
    }
}