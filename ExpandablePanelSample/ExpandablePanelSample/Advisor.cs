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
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
            lblDesignationError.Hide();
            dgvAdvisor.ReadOnly = true;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Connection opened");
            string Query = "SELECT p.Designation, p.Salary FROM Advisor p";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            DataTable data = new DataTable();
            sda.Fill(data);
            foreach (DataRow dataRow in data.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvAdvisor.DataSource = src;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "dataGridViewDeleteButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.dgvAdvisor.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvAdvisor.Columns.Add(deleteButton);
        }
        public string connectionString = "Data Source=HN;Initial Catalog=ProjectA;Integrated Security=True";

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable data = new DataTable();
            string query = "UPDATE Evaluation SET Designation = '" + cmbDesignation.Text.ToString() + "',  Salary = '" + Convert.ToInt32(numericUpDown1.Value.ToString()) + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            string Query = "SELECT p.Designation, p.Salary FROM Evaluation p";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            sda.Fill(data);
            foreach (DataRow dataRow in data.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    MessageBox.Show(item.ToString());
                }
            }
            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvAdvisor.DataSource = src;

            MessageBox.Show("Data updated succesfully");
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add button Clicked");
            if (cmbDesignation.Text == "")
            {
                lblDesignationError.Show();

            }
            else
            {
                string Designation = cmbDesignation.Text;
                Int32 Salary = Convert.ToInt32(numericUpDown1.Value);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection opened");
                string Filter = "SELECT Id FROM Lookup Where Value = '" + cmbDesignation.Text + "'";
                SqlCommand cmd = new SqlCommand(Filter, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                int designation = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader.GetInt32(0).ToString());
                        designation = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No Id found against the given data");
                }
                reader.Close();
                string query = "INSERT INTO Advisor(Designation, Salary) values('" + designation + "','" + Salary + "')";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Editing");
                cmbDesignation.Text = dgvAdvisor.Rows[e.RowIndex].Cells[2].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dgvAdvisor.Rows[e.RowIndex].Cells[5].Value.ToString());
            }
            else if (e.ColumnIndex == 1)
            {
                MessageBox.Show("Deleting");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                string query = "Delete From Advisor where Designation = '" + dgvAdvisor.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and Email = '" + dgvAdvisor.Rows[e.RowIndex].Cells[3].Value.ToString() + "'and Contact = '" + dgvAdvisor.Rows[e.RowIndex].Cells[4].Value.ToString() + "' ";
                MessageBox.Show(dgvAdvisor.Rows[e.RowIndex].Cells[6].Value.ToString());
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                DataTable data = new DataTable();

                string Query = "SELECT p.Designation, p.Salary FROM Evaluation p";
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(Query, connection);
                sda.Fill(data);
                foreach (DataRow dataRow in data.Rows)
                {
                    foreach (var item in dataRow.ItemArray)
                    {
                        MessageBox.Show(item.ToString());
                    }
                }
                BindingSource src = new BindingSource();
                src.DataSource = data;
                dgvAdvisor.DataSource = src;

                var EditButton = new DataGridViewButtonColumn();
                EditButton.Name = "dataGridViewDeleteButton";
                EditButton.HeaderText = "Edit";
                EditButton.Text = "Edit";
                EditButton.UseColumnTextForButtonValue = true;
                this.dgvAdvisor.Columns.Add(EditButton);

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                this.dgvAdvisor.Columns.Add(deleteButton);



                MessageBox.Show("Data Deleted Successfully");
            }
        }
    }
}
