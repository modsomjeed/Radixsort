using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyList;

namespace GUIArrayList
{
    public partial class GUIArrayList : Form
    {
        ArrayList A = new ArrayList(10);
        public GUIArrayList()
        {
            InitializeComponent();
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            A.add(textBoxName.Text);
            label1.Text = A.size() + " People";
            DoItAll();
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBoxName.Text))
                MessageBox.Show("Found \"" + textBoxName.Text + "\" in list.");// + "(" + ")"); 
            else MessageBox.Show(textBoxName.Text + " not found!");
            //DoItAll();
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            if (A.contains(textBoxName.Text))
            {
                A.remove(textBoxName.Text);
                MessageBox.Show(textBoxName.Text + " was deleted succesfully.");
                label1.Text = A.size() + " People";
            }
            else MessageBox.Show("There is no " + textBoxName.Text + " in list.");
            DoItAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxEdit.Text = A.get(int.Parse(textBoxIndex.Text)).ToString();
                textBoxEdit.Enabled = true;
                textBoxEdit.Focus();
            }
            catch
            {
                textBoxEdit.Enabled = false;
                MessageBox.Show("Something goes wrong!\n" +
                                "Maybe index is out of range.\n\n" +
                                "Please enter only a number (0 or higher).");

                textBoxIndex.Clear();
            }
        }

        private void EditName_Click(object sender, EventArgs e)
        {
            A.set(int.Parse(textBoxIndex.Text), textBoxEdit.Text);
            DoItAll();
            MessageBox.Show("In list #" + textBoxIndex.Text + " is changed to \"" + textBoxEdit.Text + "\".");
        }

        private void ShowAllName_Click(object sender, EventArgs e)
        {
            DoItAll();
        }
        private void DoItAll()
        {
            textBoxIndex.Clear();
            textBoxIndex.Enabled = true;
            textBoxEdit.Clear();
            textBoxEdit.Enabled = false;
            listView1.Items.Clear();
            ListViewItem lvi;
            for (int i = 0; i < A.size(); ++i)
            {
                lvi = new ListViewItem(i.ToString());
                lvi.SubItems.Add(A.get(i).ToString());
                listView1.Items.Add(lvi);
            }
        }
    }
}
