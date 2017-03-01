using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCollection;
using MySet;

namespace GUILinkedSet
{
    public partial class Form1 : Form
    {
        LinkedSet name;
        public Form1()
        {
            InitializeComponent();
            name = new LinkedSet();
            label.Text = "จำนวน " + name.size() + " คน ";
        }
        private void AddName_Click(object sender, EventArgs e)
        {
            name.add(textBox1.ToString());
            textBox1.Clear();
            label.Text = "จำนวน " + name.size() + " คน ";
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            if (name.contains(textBox1.ToString()) == true)
            {
                MessageBox.Show("ค้นพบ");
            }
            else { MessageBox.Show(" ไม่พบ"); }
            textBox1.Clear();
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            name.remove(textBox1.ToString());
            textBox1.Clear();
            label.Text = "จำนวน " + name.size() + " คน ";
        }

    }
}
