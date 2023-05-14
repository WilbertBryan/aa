using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace nyoba
{
    public partial class Form1 : Form
    {
        string connection = "server=localhost;uid=root;pwd=root;database=premier_league";
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;//buat query
        MySqlDataReader sqlDataReader;// insert update delete
        DataTable dt=new DataTable();
        string query = "";
        public Form1()
        {
            InitializeComponent();
            try
            {
                sqlConnection = new MySqlConnection(connection);
                //sqlConnection.Open();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.DataSource = dt;
        }
        private void UpdateDGV1()
        {
            dt.Clear();
            try
            {   /*
                ========= Buat Query =========
                
                */
                query = "SELECT * FROM nationality;";
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);
                dataGridView1.ClearSelection();//waktu ngeload ga ke select di dgv
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDGV1();   
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string id=txtBox_id.Text;
            string abv=txtBox_abv.Text;
            string nation=txtBox_Nation.Text;

            query = $"insert into nationality values ('{id}','{abv}','{nation}',0)";

            try 
            { 
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {  
                sqlConnection.Close();
                UpdateDGV1();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string abv = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string nation = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBox_idupdate.Text = id;
            txtBox_abvupdate.Text=abv;
            txtBox_nationupdate.Text = nation;
            txtBox_iddelete.Text = id;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBox_iddelete.Text))
            {
                query = $"delete from nationality where nationality_id ='{txtBox_iddelete.Text}';";

                try
                {
                    sqlConnection.Open();
                    sqlCommand = new MySqlCommand(query, sqlConnection);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnection.Close();
                    UpdateDGV1();
                }
                txtBox_iddelete.Clear();
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string abv = txtBox_abvupdate.Text;
            string nation = txtBox_nationupdate.Text;
            query = $"update nationality set abv='{abv}',nation='{nation}' where nationality_id='{txtBox_idupdate.Text}'";
            try
            {
                sqlConnection.Open();
                sqlCommand = new MySqlCommand(query, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
                UpdateDGV1();
            }
        }
    }
}
