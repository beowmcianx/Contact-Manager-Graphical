
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 35);
            label1.TabIndex = 0;
            label1.Text = "Tag name:";
            // 
            // textBoxTag
            // 
            textBoxTag.Font = new Font("Segoe UI", 15F);
            textBoxTag.Location = new Point(12, 47);
            textBoxTag.Name = "textBoxTag";
            textBoxTag.Size = new Size(294, 41);
            textBoxTag.TabIndex = 1;
            // 
            // btn_CreateTag
            // 
            btn_CreateTag.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn_CreateTag.Location = new Point(312, 12);
            btn_CreateTag.Name = "btn_CreateTag";
            btn_CreateTag.Size = new Size(118, 86);
            btn_CreateTag.TabIndex = 10;
            btn_CreateTag.Text = "CREATE TAG";
            btn_CreateTag.UseVisualStyleBackColor = true;
            btn_CreateTag.Click += btn_CreateTag_Click;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 35;
            listBox2.Location = new Point(12, 149);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(294, 284);
            listBox2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(102, 35);
            label2.TabIndex = 12;
            label2.Text = "All tags:";
            // 
            // btn_UpdateTag
            // 
            btn_UpdateTag.Font = new Font("Segoe UI", 15F);
            btn_UpdateTag.Location = new Point(312, 175);
            btn_UpdateTag.Name = "btn_UpdateTag";
            btn_UpdateTag.Size = new Size(118, 86);
            btn_UpdateTag.TabIndex = 13;
            btn_UpdateTag.Text = "UPDATE TAG";
            btn_UpdateTag.UseVisualStyleBackColor = true;
            btn_UpdateTag.Click += btn_UpdateTag_Click;
            // 
            // btn_DeleteTag
            // 
            btn_DeleteTag.Font = new Font("Segoe UI", 15F);
            btn_DeleteTag.Location = new Point(312, 337);
            btn_DeleteTag.Name = "btn_DeleteTag";
            btn_DeleteTag.Size = new Size(118, 96);
            btn_DeleteTag.TabIndex = 14;
            btn_DeleteTag.Text = "DELETE TAG";
            btn_DeleteTag.UseVisualStyleBackColor = true;
            btn_DeleteTag.Click += btn_DeleteTag_Click;
            // 
            // FormTagMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 445);
            Controls.Add(btn_DeleteTag);
            Controls.Add(btn_UpdateTag);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(btn_CreateTag);
            Controls.Add(textBoxTag);
            Controls.Add(label1);
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
    }
}