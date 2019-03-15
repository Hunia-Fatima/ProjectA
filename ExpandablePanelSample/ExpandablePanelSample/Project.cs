using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpandablePanelSample
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
            lblTitleError.Hide();
            dgvProjects.ReadOnly = true;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Query = "SELECT p.Title, p.Description FROM Project p";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            DataTable data = new DataTable();
            sda.Fill(data);

            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvProjects.DataSource = src;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "dataGridViewDeleteButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.dgvProjects.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvProjects.Columns.Add(deleteButton);

        }

        public string connectionString = "Data Source=HN;Initial Catalog=ProjectA;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                lblTitleError.Show();

            }
            else
            {
                string Title = txtTitle.Text;
                string Description = txtDescription.Text;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "INSERT INTO Project(Title, Description) values('" + Title + "','" + Description  + "')";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Project has been inserted successfully");
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            lblTitleError.Hide();
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                txtTitle.Text = dgvProjects.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDescription.Text = dgvProjects.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            else if (e.ColumnIndex == 1)
            {
                bool allow = false;
                DialogResult dialogResult = MessageBox.Show("Do you Want to Delete this entry", "Confirm", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    allow = true;
                }
                if (allow)
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    

                    string query = "Delete From Project where Title = '" + dgvProjects.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();
                    DataTable data = new DataTable();

                    string Query = "SELECT p.Title, p.Description FROM Project p";
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(Query, connection);
                    sda.Fill(data);

                    BindingSource src = new BindingSource();
                    src.DataSource = data;
                    dgvProjects.DataSource = src;


                    MessageBox.Show("Data Deleted Successfully");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable data = new DataTable();
            string query = "UPDATE Project SET Title = '" + txtTitle.Text.ToString() + "',  Description = '" + txtDescription.Text.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            string Query = "SELECT p.Title, p.Description FROM Project p";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            sda.Fill(data);

            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvProjects.DataSource = src;

            MessageBox.Show("Data updated succesfully");
        }
    }
}
