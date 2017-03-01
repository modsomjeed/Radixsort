using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyCollection;
using MyList;

namespace GUILinkedList
{
    public partial class Form1 : Form
    {
        DoublyLinkedList name = new DoublyLinkedList();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "จำนวน " + name.size() + " คน";
            textBoxEdit.Enabled = false;
            EditName.Enabled = false;
        }

        private void AddName_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "")
                name.add(textBoxName.Text);
            textBoxName.Clear();
            textBoxEdit.Enabled = false;
            EditName.Enabled = false;
            label1.Text = "จำนวน " + name.size() + " คน";
        }

        private void SearchName_Click(object sender, EventArgs e)
        {
            object A = textBoxName.Text;
            if (name.contains(A) == true)
            {
                MessageBox.Show("ค้นพบ");
            }
            else { MessageBox.Show(" ไม่พบ"); }
            textBoxName.Clear();
            textBoxEdit.Enabled = false;
            EditName.Enabled = false;
            label1.Text = "จำนวน " + name.size() + " คน ";
        }

        private void RemoveName_Click(object sender, EventArgs e)
        {
            name.remove(textBoxName.Text);
            textBoxEdit.Enabled = false;
            EditName.Enabled = false;
            textBoxName.Clear();
            label1.Text = "จำนวน " + name.size() + " คน ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxEdit.Text = name.get(int.Parse(textBoxIndex.Text) - 1).ToString();
                textBoxEdit.Enabled = true;
                EditName.Enabled = true;
                textBoxEdit.Focus();
            }
            catch
            {
                if (name.size() != 0)
                    MessageBox.Show(" Please input index again !\nRange of index  is 1-" + name.size());
                else
                {
                    textBoxIndex.Clear();
                    MessageBox.Show(" Do not have any name!");
                }
            }
        }

        private void EditName_Click(object sender, EventArgs e)
        {
            if (textBoxEdit.Text != "")
            {
                name.set(int.Parse(textBoxIndex.Text) - 1, textBoxEdit.Text);
                EditName.Enabled = false;
                textBoxIndex.Clear();
            }
            else
            {
                EditName.Enabled = false;
                textBoxIndex.Clear();
                MessageBox.Show(" Please input index and edit name again !");
            }
            textBoxEdit.Clear();

            label1.Text = "จำนวน " + name.size() + " คน";
        }

        private void ShowAllName_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ListViewItem lvi;
            for (int i = 0; i < name.size(); ++i)
            {
                lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(name.get(i).ToString());
                listView1.Items.Add(lvi);


            }
            textBoxEdit.Enabled = false;
            EditName.Enabled = false;
        }

    }
}
