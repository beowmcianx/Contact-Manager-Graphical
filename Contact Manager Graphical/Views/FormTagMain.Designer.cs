
namespace Contact_Manager_Graphical
{
    partial class FormTagMain
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
            textBoxTag = new TextBox();
            btn_CreateTag = new Button();
            listBox2 = new ListBox();
            label2 = new Label();
            btn_UpdateTag = new Button();
            btn_DeleteTag = new Button();
            listBox1 = new ListBox();
            btn_DetatchContacts = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Tag name:";
            // 
            // textBoxTag
            // 
            textBoxTag.Font = new Font("Segoe UI", 15F);
            textBoxTag.Location = new Point(23, 53);
            textBoxTag.Margin = new Padding(3, 2, 3, 2);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(258, 34);
            textBoxTag.TabIndex = 1;
            // 
            // btn_CreateTag
            // 
            btn_CreateTag.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_CreateTag.Location = new Point(23, 363);
            btn_CreateTag.Margin = new Padding(3, 2, 3, 2);
            btn_CreateTag.Name = "btn_CreateTag";
            btn_CreateTag.Size = new Size(114, 60);
            btn_CreateTag.TabIndex = 10;
            btn_CreateTag.Text = "CREATE TAG";
            btn_CreateTag.UseVisualStyleBackColor = true;
            btn_CreateTag.Click += btn_CreateTag_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(23, 132);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(258, 200);
            listBox2.TabIndex = 11;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 101);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 12;
            label2.Text = "All tags:";
            // 
            // btn_UpdateTag
            // 
            btn_UpdateTag.Font = new Font("Segoe UI", 15F);
            btn_UpdateTag.Location = new Point(153, 363);
            btn_UpdateTag.Margin = new Padding(3, 2, 3, 2);
            btn_UpdateTag.Name = "btn_UpdateTag";
            btn_UpdateTag.Size = new Size(128, 60);
            btn_UpdateTag.TabIndex = 13;
            btn_UpdateTag.Text = "UPDATE TAG";
            btn_UpdateTag.UseVisualStyleBackColor = true;
            btn_UpdateTag.Click += btn_UpdateTag_Click;
            // 
            // btn_DeleteTag
            // 
            btn_DeleteTag.Font = new Font("Segoe UI", 15F);
            btn_DeleteTag.Location = new Point(464, 363);
            btn_DeleteTag.Margin = new Padding(3, 2, 3, 2);
            btn_DeleteTag.Name = "btn_DeleteTag";
            btn_DeleteTag.Size = new Size(116, 60);
            btn_DeleteTag.TabIndex = 14;
            btn_DeleteTag.Text = "DELETE TAG";
            btn_DeleteTag.UseVisualStyleBackColor = true;
            btn_DeleteTag.Click += btn_DeleteTag_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(314, 53);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(266, 284);
            listBox1.TabIndex = 15;
            // 
            // btn_DetatchContacts
            // 
            btn_DetatchContacts.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_DetatchContacts.Location = new Point(314, 363);
            btn_DetatchContacts.Margin = new Padding(3, 2, 3, 2);
            btn_DetatchContacts.Name = "btn_DetatchContacts";
            btn_DetatchContacts.Size = new Size(135, 60);
            btn_DetatchContacts.TabIndex = 16;
            btn_DetatchContacts.Text = "DETATCH CONTACTS";
            btn_DetatchContacts.UseVisualStyleBackColor = true;
            btn_DetatchContacts.Click += btn_DetatchContacts_Click;
            // 
            // FormTagMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 454);
            Controls.Add(btn_DetatchContacts);
            Controls.Add(listBox1);
            Controls.Add(btn_DeleteTag);
            Controls.Add(btn_UpdateTag);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(btn_CreateTag);
            Controls.Add(textBoxTag);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTagMain";
            Text = "Modify Tag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTag;
        private Button btn_CreateTag;
        private ListBox listBox2;
        private Label label2;
        private Button btn_UpdateTag;
        private Button btn_DeleteTag;
        private ListBox listBox1;
        private Button btn_DetatchContacts;
    }
}