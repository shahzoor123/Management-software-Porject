using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace demo_soft
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        int i;

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /*  i = 0;
              sql.Open();
              SqlCommand cmd = sql.CreateCommand();
              cmd.CommandType = CommandType.Text;
              cmd.CommandText = "select * from login where Name='" + bunifuTextbox1.text + "' and Password= '" + bunifuTextbox2.text + "' ";
              cmd.ExecuteNonQuery();
              DataTable dt = new DataTable();
              SqlDataAdapter adp = new SqlDataAdapter(cmd);
              adp.Fill(dt);
              i = Convert.ToInt32(dt.Rows.Count.ToString());

              if (i == 0)
              {
                  bunifuCustomLabel1.Text = "You Have Entered Invalid username and password";
              }
              else
              {
                  this.Hide();
                  menu m = new menu();
                  m.Show();


              }
              sql.Close();
          }*/
        }

        private void bunifuThinButton21_Enter(object sender, EventArgs e)
        {
          /*  i = 0;
            sql.Open();
            SqlCommand cmd = sql.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where Name='" + bunifuTextbox1.text + "' and Password= '" + bunifuTextbox2.text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                bunifuCustomLabel1.Text = "You Have Entered Invalid username and password";
            }
            else
            {
                this.Hide();
                menu m = new menu();
                m.Show();


            }
            sql.Close();
        } 
            */
        }

        private void bunifuTextbox2_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
