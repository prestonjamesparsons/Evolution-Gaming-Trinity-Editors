using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Trinity_Database_Editors
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //no username?
            string myConnection = "datasource=YOURSOURCE;port=3306;username=YOURUSERNAME;password=YOURPASSWORD";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand SelectCommand = new MySqlCommand("select * from dbname.accounts where firstname='" + this.textBox1.Text +  "' surname='" + this.textBox2.Text + "' email='" + this.textBox3.Text + "' password= '" + this.textBox4.Text + "'and terms= '" + this.checkBox1 + "';'", myConn);
            MySqlDataReader myReader;
            myConn.Open();
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct");
            }
            else if (count > 1)
            {
                MessageBox.Show("Access denied");
            }
            else
            {
                MessageBox.Show("Wrong username and password");
            }
            myConn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void versionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
