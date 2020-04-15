using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace demo_soft
{
    public partial class Form1 : Form
    {

        SqlConnection sql = new SqlConnection("Data Source=localhost;Initial Catalog=ConnectionDb;Integrated Security=True");
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LABEL1_Click(object sender, EventArgs e)
        {

        }

        private void xuiSuperButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox2.Text);
                Convert.ToInt32(textBox5.Text);
                Convert.ToInt32(textBox6.Text);
                Convert.ToInt32(textBox11.Text);
                Convert.ToInt32(textBox8.Text);
                Convert.ToInt32(textBox3.Text);
                cmd = new SqlCommand("insert into  Product values (@id,@Name,@Product,@Quantity,@Price,@Employee_name,@Product_serial_no,@Product_Price,@Total )", sql);
                cmd.Parameters.Add("id", SqlDbType.Int).Value = textBox2.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = textBox1.Text;
                cmd.Parameters.Add("Product", SqlDbType.NVarChar).Value = textBox4.Text;
                cmd.Parameters.Add("Quantity", SqlDbType.Int).Value = textBox5.Text;
                cmd.Parameters.Add("Price", SqlDbType.Int).Value = textBox6.Text;
                cmd.Parameters.Add("Employee_name", SqlDbType.NVarChar).Value = textBox7.Text;
                cmd.Parameters.Add("Product_serial_no", SqlDbType.Int).Value = textBox11.Text;
                cmd.Parameters.Add("Product_Price", SqlDbType.Int).Value = textBox8.Text;
                cmd.Parameters.Add("Total", SqlDbType.Int).Value = textBox3.Text;
                sql.Open();
                cmd.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("record added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
















        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sql.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from Product", sql);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void xuiSegment1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiCard1_Click(object sender, EventArgs e)
        {

        }

        private void xuiCard4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            /* Convert.ToInt32(textBox2.Text);
             Convert.ToInt32(textBox5.Text);
             Convert.ToInt32(textBox6.Text);
             Convert.ToInt32(textBox11.Text);
             Convert.ToInt32(textBox8.Text);
             Convert.ToInt32(textBox3.Text);

             cmd = new SqlCommand("Update  ConnectionDb.Product SET( Name = '" + textBox1.Text + "' , Product = '" + textBox4 + "', Quantity = '" + textBox5.Text + "' ,   Price = '" + textBox6.Text + "' ,  Employee_name= '" + textBox7.Text + "',  Product_serial_no = '" + textBox11.Text + "' ,  Product_Price = '" + textBox8.Text + "' , Total = '" + textBox3.Text + "'   )", sql);
              cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = textBox1.Text;
             cmd.Parameters.Add("Product", SqlDbType.NVarChar).Value = textBox4.Text;
             cmd.Parameters.Add("Quantity", SqlDbType.Int).Value = textBox5.Text;
             cmd.Parameters.Add("Price", SqlDbType.Int).Value = textBox6.Text;
             cmd.Parameters.Add("Employee_name", SqlDbType.Int).Value = textBox7.Text;
             cmd.Parameters.Add("Product_serial_no", SqlDbType.Int).Value = textBox11.Text;
             cmd.Parameters.Add("Product_Price", SqlDbType.Int).Value = textBox8.Text;
             cmd.Parameters.Add("Total", SqlDbType.Int).Value = textBox3.Text;
             sql.Open();
             cmd.ExecuteNonQuery();
             sql.Close();
             MessageBox.Show("record updated");
 */
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("DELETE FROM Product WHERE id=@id", sql);
            cm.Parameters.Add("@id", SqlDbType.Int).Value = textBox2.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Sucessfully!");
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           /* try
            {
                int i = Convert.ToInt32(textBox2.Text);
                cmd = new SqlCommand("select * from Product where id='" + i + "'", sql);
                sql.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    textBox1.Text = reader.GetString(1);
                    textBox4.Text = reader.GetString(2);
                    textBox5.Text = reader.GetInt32(3).ToString();
                    textBox6.Text = reader.GetInt32(4).ToString();
                    textBox7.Text = reader.GetString(5);
                    textBox11.Text = reader.GetInt32(6).ToString();
                    textBox8.Text = reader.GetInt32(7).ToString();
                    textBox3.Text = reader.GetInt32(8).ToString();
                }

                reader.Close();
                sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
            */


        }

    }
}
