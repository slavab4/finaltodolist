using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Final
{
    public partial class Form1 : Form
    {
                     
        public Form1()
        {
            InitializeComponent();

            //Listview properties
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            //Construct Columns
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Position", 150);
            listView1.Columns.Add("Team", 150);
        }
        //Add to ListView
        private void add(String name, String pos, String team)
        {
            //Row
            String[] row = { name, pos, team };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }
        //Add
        private void addBtn_Click(object sender, EventArgs e)
        {
            add(nameTxt.Text, posTxt.Text, teamTxt.Text);
            //Clear TXT
            nameTxt.Text = "";
            posTxt.Text = "";
            teamTxt.Text = "";
        }
        //update
        private void update()
        {
            listView1.SelectedItems[0].SubItems[0].Text = nameTxt.Text;
            listView1.SelectedItems[0].SubItems[1].Text = posTxt.Text;
            listView1.SelectedItems[0].SubItems[2].Text = teamTxt.Text;
            //Clear TXT
            nameTxt.Text = "";
            posTxt.Text = "";
            teamTxt.Text = "";
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            update();
        }
        //Delete
        private void delete()
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                //Clear TXT
                nameTxt.Text = "";
                posTxt.Text = "";
                teamTxt.Text = "";
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //Clear TXT
            nameTxt.Text = "";
            posTxt.Text = "";
            teamTxt.Text = "";

        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            nameTxt.Text = listView1.SelectedItems[0].SubItems[0].Text;
            posTxt.Text = listView1.SelectedItems[0].SubItems[1].Text;
            teamTxt.Text = listView1.SelectedItems[0].SubItems[2].Text;
                       

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
