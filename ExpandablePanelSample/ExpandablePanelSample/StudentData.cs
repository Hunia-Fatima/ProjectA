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
    public partial class StudentData : Form
    {
        public string connectionString = "Data Source=HN;Initial Catalog=ProjectA;Integrated Security=True";
        public DataTable data = new DataTable();
        public StudentData()
        {
            InitializeComponent();
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //MessageBox.Show("Connection opened");
            //string Query = "SELECT p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', s.RegistrationNo as 'Registration No' FROM Person p INNER JOIN Student s ON p.Id = s.Id";
            //SqlDataAdapter sda = new SqlDataAdapter();
            //sda.SelectCommand = new SqlCommand(Query, connection);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //foreach (DataRow dataRow in data.Rows)
            //{
            //    foreach (var item in dataRow.ItemArray)
            //    {
            //        MessageBox.Show(item.ToString());
            //    }
            //}
            //BindingSource src = new BindingSource();
            //src.DataSource = data;
            //dgvStudent.DataSource = src;

            //var EditButton = new DataGridViewButtonColumn();
            //EditButton.Name = "dataGridViewDeleteButton";
            //EditButton.HeaderText = "Edit";
            //EditButton.Text = "Edit";
            //EditButton.UseColumnTextForButtonValue = true;
            //this.dgvStudent.Columns.Add(EditButton);

            //var deleteButton = new DataGridViewButtonColumn();
            //deleteButton.Name = "dataGridViewDeleteButton";
            //deleteButton.HeaderText = "Delete";
            //deleteButton.Text = "Delete";
            //deleteButton.UseColumnTextForButtonValue = true;
            //this.dgvStudent.Columns.Add(deleteButton);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.ColumnIndex == 0)
            //{
            //    MessageBox.Show("Editing");
            //    dgvStudent.Rows[e.RowIndex].ReadOnly = false;
            //}
            //else if(e.ColumnIndex == 1)
            //{
            //    MessageBox.Show("Deleting");
            //    SqlConnection connection = new SqlConnection(connectionString);
            //    connection.Open();
            //    string query = "Delete From Student where RegistrationNo = '" + dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString() + "'";
            //    MessageBox.Show(dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString());
            //    SqlCommand cmd1 = new SqlCommand(query, connection);
            //    cmd1.ExecuteNonQuery();

            //    query = "Delete From Person where FirstName + ' ' + LastName = '" + dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and Email = '" + dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString() + "'and Contact = '" + dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString() + "' ";
            //    MessageBox.Show(dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString());
            //    cmd1 = new SqlCommand(query, connection);
            //    cmd1.ExecuteNonQuery();


            //    string Query = "SELECT p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', s.RegistrationNo as 'Registration No' FROM Person p INNER JOIN Student s ON p.Id = s.Id";
            //    SqlDataAdapter sda = new SqlDataAdapter();
            //    sda.SelectCommand = new SqlCommand(Query, connection);
            //    sda.Fill(data);
            //    foreach (DataRow dataRow in data.Rows)
            //    {
            //        foreach (var item in dataRow.ItemArray)
            //        {
            //            MessageBox.Show(item.ToString());
            //        }
            //    }
            //    BindingSource src = new BindingSource();
            //    src.DataSource = data;
            //    dgvStudent.DataSource = src;

            //    var EditButton = new DataGridViewButtonColumn();
            //    EditButton.Name = "dataGridViewDeleteButton";
            //    EditButton.HeaderText = "Edit";
            //    EditButton.Text = "Edit";
            //    EditButton.UseColumnTextForButtonValue = true;
            //    this.dgvStudent.Columns.Add(EditButton);

            //    var deleteButton = new DataGridViewButtonColumn();
            //    deleteButton.Name = "dataGridViewDeleteButton";
            //    deleteButton.HeaderText = "Delete";
            //    deleteButton.Text = "Delete";
            //    deleteButton.UseColumnTextForButtonValue = true;
            //    this.dgvStudent.Columns.Add(deleteButton);



            //    MessageBox.Show("Data Deleted Successfully");
        
            
        }
    }
}
