using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCollection;
namespace GUILinkedCollection
{
    public partial class Form1 : Form
    {
        public LinkedCollectionWithHeader A = new LinkedCollectionWithHeader();
        public Form1()
        {
            InitializeComponent();
        }
        private void AddName_Click(object sender, EventArgs e)
        {
            if (textBox.Text != null)
            {
                A.add(textBox.Text);
                label1.Text = A.size() + " member(s)";
                textBox.Clear();
            }
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBox.Text))
                MessageBox.Show("Found " + textBox.Text + " in member.");
            else MessageBox.Show(textBox.Text + " not found!");
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBox.Text))
            {
                A.remove(textBox.Text);
                label1.Text = A.size() + " member(s)";
                MessageBox.Show(textBox.Text + " has removed from member.");
            }
            else MessageBox.Show(textBox.Text + " not found in member.");
            textBox.Clear();
        }
    }
}
