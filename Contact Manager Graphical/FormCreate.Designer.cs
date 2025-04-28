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
            ButtonCreateContact = new Button();
            label7 = new Label();
            listBoxtag = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "SecondName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 154);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 200);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 246);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 5;
            label6.Text = "Tag";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(21, 42);
            textBoxFirstName.Margin = new Padding(3, 2, 3, 2);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(110, 23);
            textBoxFirstName.TabIndex = 6;
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(21, 87);
            textBoxSecondName.Margin = new Padding(3, 2, 3, 2);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(110, 23);
            textBoxSecondName.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(21, 124);
            textBoxAddress.Margin = new Padding(3, 2, 3, 2);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(110, 23);
            textBoxAddress.TabIndex = 8;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(21, 172);
            textBoxPhoneNum.Margin = new Padding(3, 2, 3, 2);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(110, 23);
            textBoxPhoneNum.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(21, 217);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(110, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // ButtonCreateContact
            // 
            ButtonCreateContact.Location = new Point(267, 283);
            ButtonCreateContact.Margin = new Padding(3, 2, 3, 2);
            ButtonCreateContact.Name = "ButtonCreateContact";
            ButtonCreateContact.Size = new Size(232, 35);
            ButtonCreateContact.TabIndex = 13;
            ButtonCreateContact.Text = "CREATE CONTACT";
            ButtonCreateContact.UseVisualStyleBackColor = true;
            ButtonCreateContact.Click += ButtonCreateContact_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 118);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 14;
            label7.Text = "Address";
            // 
            // listBoxtag
            // 
            listBoxtag.FormattingEnabled = true;
            listBoxtag.ItemHeight = 15;
            listBoxtag.Location = new Point(21, 263);
            listBoxtag.Margin = new Padding(3, 2, 3, 2);
            listBoxtag.Name = "listBoxtag";
            listBoxtag.SelectionMode = SelectionMode.MultiExtended;
            listBoxtag.Size = new Size(132, 64);
            listBoxtag.TabIndex = 17;
            listBoxtag.SelectedIndexChanged += listBoxtag_SelectedIndexChanged;
            // 
            // FormCreate
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 338);
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label3;
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
    }
}