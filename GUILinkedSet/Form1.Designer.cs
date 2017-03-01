namespace GUILinkedSet
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(293, 30);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 6;
            this.label.Text = "0 member(s)";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(12, 71);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(99, 39);
            this.AddName.TabIndex = 7;
            this.AddName.Text = "เพิ่มชื่อ";
            this.AddName.UseVisualStyleBackColor = true;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(137, 71);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(99, 39);
            this.SearchName.TabIndex = 8;
            this.SearchName.Text = "ค้นหาชื่อ";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(258, 71);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(99, 39);
            this.RemoveName.TabIndex = 9;
            this.RemoveName.Text = "ลบชื่อ";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 122);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button RemoveName;
    }
}

