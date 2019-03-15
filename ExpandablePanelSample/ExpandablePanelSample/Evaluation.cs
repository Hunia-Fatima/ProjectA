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
    public partial class Evaluation : Form
    {
        public Evaluation()
        {
            InitializeComponent();
            lblMarksError.Hide();
            lblNameError.Hide();
            lblWeightageError.Hide();
            dgvEvaluation.ReadOnly = true;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Connection opened");
            string Query = "SELECT e.Name, e.TotalMarks, e.TotalWeightage FROM Evaluation e";
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
            dgvEvaluation.DataSource = src;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "dataGridViewDeleteButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.dgvEvaluation.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvEvaluation.Columns.Add(deleteButton);
        }
        public string connectionString = "Data Source=HN;Initial Catalog=ProjectA;Integrated Security=True";

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add button Clicked");
            if (txtName.Text == "")
            {
                lblNameError.Show();

            }
            else if (NumMarks.Value == 0)
            {
                lblMarksError.Show();

            }
            else if (NumMarks.Value == 0)
            {
                lblWeightageError.Show();

            }
            else
            {
                string Name = txtName.Text;
                int Marks = Convert.ToInt32(NumMarks.Value);
                int Weightage = Convert.ToInt32(NumWeightage.Value);
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection opened");
                string query = "INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) values('" + Name + "','" + Marks + "','" + Weightage + "')";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Evaluation Type has been inserted successfully");
            }
        }

        private void dgvEvaluation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Editing");
                txtName.Text = dgvEvaluation.Rows[e.RowIndex].Cells[2].Value.ToString();
                NumMarks.Value= Convert.ToInt32(dgvEvaluation.Rows[e.RowIndex].Cells[3].Value.ToString());
                NumWeightage.Value = Convert.ToInt32(dgvEvaluation.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            else if (e.ColumnIndex == 1)
            {
                MessageBox.Show("Deleting");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                MessageBox.Show(dgvEvaluation.Rows[e.RowIndex].Cells[2].Value.ToString());

                string query = "Delete From Evaluation where Name = '" + dgvEvaluation.Rows[e.RowIndex].Cells[2].Value.ToString() + "' ";
                MessageBox.Show(dgvEvaluation.Rows[e.RowIndex].Cells[2].Value.ToString());
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                DataTable data = new DataTable();

                string Query = "SELECT e.Name, e.TotalMarks, e.TotalWeightage FROM Evaluation e";
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
                dgvEvaluation.DataSource = src;


                MessageBox.Show("Data Deleted Successfully");
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable data = new DataTable();
            string query = "UPDATE Evaluation SET Name = '" + txtName.Text.ToString() + "',  TotalMarks = '" + NumMarks.Value + "',  TotalWeightage = '" + NumWeightage.Value + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            MessageBox.Show("In Middle");
            string Query = "SELECT e.Name, e.TotalMarks, e.TotalWeightage FROM Evaluation e";
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
            dgvEvaluation.DataSource = src;

            MessageBox.Show("Data updated succesfully");
        }
    }
}
