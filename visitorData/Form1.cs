using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace visitorData
{
    public partial class Form1 : Form
    {
        OleDbConnection sqlconn;
        OleDbCommand sqlquery;
        OleDbDataReader dr;
        string connString;
        public Form1()
        {
            InitializeComponent();
            
        }

       

        private void Button2_Click(object sender, EventArgs e)
        {
            
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            string sql = "INSERT INTO visit(Name,Contact,email,arriveTime,dateto,tomeet) VALUES('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + DateTimePicker2.Text + "',  '" + DateTimePicker1.Text + "', '" + ComboBox1.Text + "')";
            sqlconn = new OleDbConnection(connString);
            
            sqlquery = new OleDbCommand(sql,sqlconn);
            sqlconn.Open();
            sqlquery.ExecuteNonQuery();
            MessageBox.Show("Data Inserted");
            bind();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTimePicker3.Enabled = true;
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            sqlconn = new OleDbConnection(connString);
            //sqlquery.Connection = sqlconn;
            string sql = "select * from visit  where ID = " + TextBox4.Text + "";
            
            sqlquery = new OleDbCommand(sql,sqlconn);
            sqlconn.Open();
            try
            {
                OleDbDataReader read = sqlquery.ExecuteReader();
                while (read.Read())
                {
                    TextBox1.Text = read["Name"].ToString();
                    TextBox2.Text = read["Contact"].ToString();
                    TextBox3.Text = read["email"].ToString();
                    DateTimePicker2.Text = read["arriveTime"].ToString();
                    label10.Text = read["tomeet"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string sql = "delete from visit where ID = " + TextBox4.Text + "";
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            sqlconn = new OleDbConnection(connString);
            sqlconn.Open();
            sqlquery = new OleDbCommand(sql,sqlconn) ;
            sqlquery.ExecuteNonQuery();
            MessageBox.Show("Data Deleted");
            bind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.databaseDataSet.visit);
            DateTimePicker3.Enabled = false;

            ComboBox1.Items.Add("Loan Poupose");
            ComboBox1.Items.Add("Delivery Parcel");
            ComboBox1.Items.Add("Print Passbook");
            ComboBox1.Items.Add("Deposit Money");
            ComboBox1.Items.Add("Withdrawn Money");

            comboBox2.Items.Add("Loan Poupose");
            comboBox2.Items.Add("Delivery Parcel");
            comboBox2.Items.Add("Print Passbook");
            comboBox2.Items.Add("Deposit Money");
            comboBox2.Items.Add("Withdrawn Money");
            
            
            
            
            
            
            DateTimePicker1.Format = DateTimePickerFormat.Custom;
            DateTimePicker1.CustomFormat = "dd-MM-yyyy";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "dd-MM-yyyy";
            DateTimePicker2.Format = DateTimePickerFormat.Custom;
            DateTimePicker2.CustomFormat = "HH:mm:ss tt";
            DateTimePicker3.Format = DateTimePickerFormat.Custom;
            DateTimePicker3.CustomFormat = "HH:mm:ss tt";
        
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            bind();
        }
        private void bind()
        {
            string sql = "Select * from visit";
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            sqlconn = new OleDbConnection(connString);
            sqlconn.Open();
            sqlquery = new OleDbCommand(sql, sqlconn);

            OleDbDataAdapter olda = new OleDbDataAdapter(sqlquery);
            DataTable dt = new DataTable();
            olda.Fill(dt);
            DataGridView1.DataSource = dt;
            //DataGridView1.DataBindingComplete();
            sqlconn.Close();
            //MessageBox.Show("Data Deleted");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            string sql = "update visit set departTime = '"+DateTimePicker3.Text+"' where ID = "+TextBox4.Text+"";
            sqlconn = new OleDbConnection(connString);
            sqlconn.Open();
            sqlquery = new OleDbCommand(sql, sqlconn);
            
            sqlquery.ExecuteNonQuery();
            MessageBox.Show("Data Updated");
            bind();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            string sql = "Select * from visit where dateto = '"+dateTimePicker4.Text+"'";
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            sqlconn = new OleDbConnection(connString);
            sqlconn.Open();
            sqlquery = new OleDbCommand(sql, sqlconn);

            OleDbDataAdapter olda = new OleDbDataAdapter(sqlquery);
            DataTable dt = new DataTable();
            olda.Fill(dt);
            DataGridView1.DataSource = dt;
            //DataGridView1.DataBindingComplete();
            sqlconn.Close();
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select * from visit where tomeet = '" + comboBox2.SelectedItem + "'";
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb";
            sqlconn = new OleDbConnection(connString);
            sqlconn.Open();
            sqlquery = new OleDbCommand(sql, sqlconn);
            
            OleDbDataAdapter olda = new OleDbDataAdapter(sqlquery);
            DataTable dt = new DataTable();
            olda.Fill(dt);
            DataGridView1.DataSource = dt;
            //DataGridView1.DataBindingComplete();
            sqlconn.Close();
            
        }
    }
}
