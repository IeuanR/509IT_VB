using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _509IT_Ccode
{
    public partial class Form2 : Form
    {
        ContactDBconn mysqlConn;
        
        
        
            public Form2()
            {
                InitializeComponent();
                mysqlConn = new ContactDBconn();
                mysqlConn.connect();

                if (mysqlConn.connOpen() == true)
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables[0];

                mysqlConn.connClose();
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.insertContact(Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables[0];
                }

                mysqlConn.connClose();
            }

            private void dataGridView1_SelectionChanged(object sender, EventArgs e)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Firstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    Lastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    Phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    Mail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    Address.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    Postcode.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    contType.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                }
            }

            private void btnUpdate_Click(object sender, EventArgs e)
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.updateContact(ID.Text, Firstname.Text, Lastname.Text, Phone.Text, Mail.Text, Address.Text, Postcode.Text, contType.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables[0];
                }

                mysqlConn.connClose();
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    if (mysqlConn.connOpen() == true)
                    {
                        mysqlConn.deleteContact(ID.Text);
                        dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `contact`").Tables[0];
                    }

                    mysqlConn.connClose();
                }
            }

            private void btnMainMenu_Click(object sender, EventArgs e)
            {
                Close();
                new MainForm().Show();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    }

