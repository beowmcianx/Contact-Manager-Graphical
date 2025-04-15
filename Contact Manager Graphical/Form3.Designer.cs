
namespace Contact_Manager_Graphical
{
    partial class Form3
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
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
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
            textBoxTag.Size = new Size(157, 41);
            textBoxTag.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 35;
            listBox1.Location = new Point(175, 13);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(341, 424);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 381);
            button1.Name = "button1";
            button1.Size = new Size(157, 57);
            button1.TabIndex = 10;
            button1.Text = "CREATE TAG";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(12, 159);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 11;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBoxTag);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Tags";
            ResumeLayout(false);
            PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox textBoxTag;
        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
    }
}