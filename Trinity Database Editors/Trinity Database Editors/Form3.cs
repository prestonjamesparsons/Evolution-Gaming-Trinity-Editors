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
    
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            MySqlConnection con = new MySqlConnection("Server=myServerAddress;Port=3306;Database=myDataBase;Uid=myUsername;Pwd = myPassword; "); //needs a fix for user to add in the data.
            con.Open();
            

            MySqlCommand cmd = new MySqlCommand("select + from person", con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            //Needs a new fix!
            //GridView1.DataSource = ds;
            //GridView1.DataBind(); 
            cmd.Dispose();
            con.Close();
        }
    }
}
