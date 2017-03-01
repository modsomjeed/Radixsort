namespace GUILinkedCollection
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(20, 36);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(255, 20);
            this.textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "0 member(s)";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(17, 86);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(70, 35);
            this.AddName.TabIndex = 2;
            this.AddName.Text = "เพิ่มชื่อ";
            this.AddName.UseVisualStyleBackColor = true;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(149, 86);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(70, 35);
            this.SearchName.TabIndex = 3;
            this.SearchName.Text = "ค้นหาชื่อ";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(277, 86);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(70, 35);
            this.RemoveName.TabIndex = 4;
            this.RemoveName.Text = "ลบชื่อ";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 151);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button RemoveName;
    }
}

