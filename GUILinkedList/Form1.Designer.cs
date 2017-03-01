namespace GUILinkedList
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.Button();
            this.SearchName = new System.Windows.Forms.Button();
            this.RemoveName = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxEdit = new System.Windows.Forms.TextBox();
            this.EditName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ColumnIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ShowAllName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(288, 24);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(112, 31);
            this.AddName.TabIndex = 2;
            this.AddName.Text = "Add";
            this.AddName.UseVisualStyleBackColor = true;
            this.AddName.Click += new System.EventHandler(this.AddName_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(417, 24);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(112, 31);
            this.SearchName.TabIndex = 3;
            this.SearchName.Text = "Search";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // RemoveName
            // 
            this.RemoveName.Location = new System.Drawing.Point(553, 24);
            this.RemoveName.Name = "RemoveName";
            this.RemoveName.Size = new System.Drawing.Size(112, 31);
            this.RemoveName.TabIndex = 4;
            this.RemoveName.Text = "Remove";
            this.RemoveName.UseVisualStyleBackColor = true;
            this.RemoveName.Click += new System.EventHandler(this.RemoveName_Click);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(12, 83);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(72, 20);
            this.textBoxIndex.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Search from index number";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Location = new System.Drawing.Point(292, 83);
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(237, 20);
            this.textBoxEdit.TabIndex = 7;
            // 
            // EditName
            // 
            this.EditName.Location = new System.Drawing.Point(553, 77);
            this.EditName.Name = "EditName";
            this.EditName.Size = new System.Drawing.Size(112, 31);
            this.EditName.TabIndex = 8;
            this.EditName.Text = "Edit";
            this.EditName.UseVisualStyleBackColor = true;
            this.EditName.Click += new System.EventHandler(this.EditName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIndex,
            this.ColumnData});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 152);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(511, 217);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.Text = "Index";
            this.ColumnIndex.Width = 40;
            // 
            // ColumnData
            // 
            this.ColumnData.Text = "Name";
            this.ColumnData.Width = 468;
            // 
            // ShowAllName
            // 
            this.ShowAllName.Location = new System.Drawing.Point(553, 152);
            this.ShowAllName.Name = "ShowAllName";
            this.ShowAllName.Size = new System.Drawing.Size(110, 183);
            this.ShowAllName.TabIndex = 12;
            this.ShowAllName.Text = "Show All List";
            this.ShowAllName.UseVisualStyleBackColor = true;
            this.ShowAllName.Click += new System.EventHandler(this.ShowAllName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowAllName);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditName);
            this.Controls.Add(this.textBoxEdit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.RemoveName);
            this.Controls.Add(this.SearchName);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button RemoveName;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.Button EditName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ColumnIndex;
        private System.Windows.Forms.ColumnHeader ColumnData;
        private System.Windows.Forms.Button ShowAllName;
        private System.Windows.Forms.Label label3;
    }
}

