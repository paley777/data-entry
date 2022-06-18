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

namespace Data_Entry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // connection string :

        SqlConnection conn = new SqlConnection(@"Data Source=VALLEYFEEDS\SQLEXPRESS;Initial Catalog=tugas;Integrated Security=True");

        //save data in database :-)

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (txtid.Text == "" || txtnama.Text == "" || txtdeskripsi.Text == "" || txtkategori.Text == "" || txtharga.Text == "")
                {
                    MessageBox.Show("Tolong isi semua kolom!");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("insert into crud1(id,nama,harga,deskripsi,kategori)values('" + txtid.Text + "','" + txtnama.Text + "','" + txtharga.Text + "','" + txtdeskripsi.Text + "','" + txtkategori.Text + "')", conn);

                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DATA SUKSES DIINPUT");
                    panel1.Enabled = false;

                }
            
        }
        // view the data in datagridview :-)

        private void btnview_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            //conn.Open();
            //SqlDataAdapter sda = new SqlDataAdapter("select * from crud1",conn);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.DataSource = data;
            load_data();
            //conn.Close();

            
        }

        private void load_data()
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from crud1", conn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            conn.Close();
        }
        // double click event for updating and deleting the data from database :-)

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel1.Enabled = true;
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtnama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtharga.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtdeskripsi.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtkategori.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();



        }
        //update the data :-)

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == true)
            {

                if (txtid.Text == "" || txtnama.Text == "" || txtdeskripsi.Text == "" || txtkategori.Text == "" || txtharga.Text == "")
                {
                    MessageBox.Show("Tolong isi semua kolom!");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("UPDATE crud1 SET nama = '" + txtnama.Text + "',harga = '" + txtharga.Text + "', deskripsi = '" + txtdeskripsi.Text + "',kategori = '" + txtkategori.Text + "' where id ='" + txtid.Text + "'", conn);

                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DATA BERHASIL DI UPDATE. . . .");
                    load_data();
                    panel1.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Tolong pilih data yang ingin di update");
            }
           
            
        }

        //delete btn c0ding :-)

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (panel1.Enabled == true)
            {

                if (txtid.Text == "" || txtnama.Text == "" || txtdeskripsi.Text == "" || txtkategori.Text == "" || txtharga.Text == "")
                {
                    MessageBox.Show("Tolong isi semua kolom!");
                }
                else
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("delete from crud1 where id ='" + txtid.Text + "'", conn);

                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DATA BERHASIL DI HAPUS. . . .");
                    load_data();
                    panel1.Enabled = false; 
                }
               
            }
            else
            {
                MessageBox.Show("Tolong pilih data yang ingin di update");
            }
           
        }

        //to insert the new entry :-*

        private void btnnew_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = false;
            panel1.Enabled = true;
            
            txtid.Text = "";
            txtnama.Text = "";
            txtdeskripsi.Text = "";
            txtkategori.Text = "";
            txtharga.Text = "";

        }

        //search the data from database by name :-*

        private void srchbtn_Click(object sender, EventArgs e)
        {

            if (txtnamesrch.Text == "")
            {
                MessageBox.Show("Kotak Pencarian kosong!");
            }
            
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from crud1 where nama LIKE '%"+txtnamesrch.Text+"%'", conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                conn.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
