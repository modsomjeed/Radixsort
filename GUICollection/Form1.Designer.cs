namespace GUICollection
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
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxRemove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddName = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(36, 31);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(297, 20);
            this.textBoxAdd.TabIndex = 0;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(36, 105);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(297, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // textBoxRemove
            // 
            this.textBoxRemove.Location = new System.Drawing.Point(36, 181);
            this.textBoxRemove.Name = "textBoxRemove";
            this.textBoxRemove.Size = new System.Drawing.Size(297, 20);
            this.textBoxRemove.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(441, 31);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(95, 20);
            this.AddName.TabIndex = 4;
            this.AddName.Text = "เพิ่มชื่อ";
            this.AddName.UseVisualStyleBackColor = true;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(441, 104);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(95, 20);
            this.SearchName.TabIndex = 5;
            this.SearchName.Text = "ค้นหาชื่อ";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(441, 170);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(95, 20);
            this.RemoveName.TabIndex = 6;
            this.RemoveName.Text = "ลบชื่อ";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 323);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRemove);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBoxAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button RemoveName;
    }
}

