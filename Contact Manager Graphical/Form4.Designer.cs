namespace Contact_Manager_Graphical
{
    partial class Form4
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
            listBox1 = new ListBox();
            label1 = new Label();
            textBoxNewTag = new TextBox();
            btn_UpdateTag = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(201, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(184, 319);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(182, 35);
            label1.TabIndex = 1;
            label1.Text = "New tag name:";
            // 
            // textBoxNewTag
            // 
            textBoxNewTag.Font = new Font("Segoe UI", 15F);
            textBoxNewTag.Location = new Point(12, 50);
            textBoxNewTag.Name = "textBoxNewTag";
            textBoxNewTag.Size = new Size(182, 41);
            textBoxNewTag.TabIndex = 2;
            // 
            // btn_UpdateTag
            // 
            btn_UpdateTag.Font = new Font("Segoe UI", 15F);
            btn_UpdateTag.Location = new Point(12, 274);
            btn_UpdateTag.Name = "btn_UpdateTag";
            btn_UpdateTag.Size = new Size(182, 57);
            btn_UpdateTag.TabIndex = 3;
            btn_UpdateTag.Text = "UPDATE TAG";
            btn_UpdateTag.UseVisualStyleBackColor = true;
            btn_UpdateTag.Click += btn_UpdateTag_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 343);
            Controls.Add(btn_UpdateTag);
            Controls.Add(textBoxNewTag);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form4";
            Text = "Update Tag";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBoxNewTag;
        private Button btn_UpdateTag;
    }
}