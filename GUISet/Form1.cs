using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySet;

namespace GUISet
{
    public partial class Form1 : Form
    {
        private ArraySet A = new ArraySet(10);
        public Form1()
        {
            InitializeComponent();
            this.Text = "Array GUI";
        }
        private void AddName_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                A.Add(textBox1.Text);
                label.Text = A.size() + " member(s)";
                if (!A.contains(textBox1.Text)) MessageBox.Show(textBox1.Text + " has added successfully.");
                else MessageBox.Show("Already has in set.");
                textBox1.Clear();
            }
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBox1.Text))
                MessageBox.Show("Found " + textBox1.Text + " in collection.");
            else MessageBox.Show(textBox1.Text + " not found!");
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBox1.Text))
            {
                A.remove(textBox1.Text);
                label.Text = A.size() + " member(s)";
                MessageBox.Show(textBox1.Text + " has removed from collection.");
            }
            else MessageBox.Show(textBox1.Text + " not found in collection.");
            textBox1.Clear();
        }
    }
}
