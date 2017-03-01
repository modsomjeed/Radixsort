using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCollection;

namespace GUICollection
{
    public partial class Form1 : Form
    {
        ArrayCollection A = new ArrayCollection(10);
        public Form1()
        {
            InitializeComponent();
        }
        private void AddName_Click(object sender, EventArgs e)
        {
            A.add(AddName.Text);
            label1.Text = A.size() + "Member(s)";
            textBoxAdd.Clear();
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            if (A.contains(SearchName.Text))
            {
                MessageBox.Show("found " + textBoxSearch.Text + " in database");
            }
            else MessageBox.Show("Not found " + textBoxSearch.Text + " in database");
            textBoxSearch.Clear();
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            A.remove(AddName.Text);
            textBoxRemove.Clear();
            label1.Text = A.size()+"Member(s)";
        }
    }
}
