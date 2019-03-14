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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
            lblDOBError.Hide();
            lblEmailError.Hide();
            lblFNameError.Hide();
            lblRegNoError.Hide();
            dgvStudent.ReadOnly = true;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            MessageBox.Show("Connection opened");
            string Query = "SELECT p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', s.RegistrationNo as 'Registration No' FROM Person p INNER JOIN Student s ON p.Id = s.Id";
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
            dgvStudent.DataSource = src;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "dataGridViewDeleteButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.dgvStudent.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "dataGridViewDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.dgvStudent.Columns.Add(deleteButton);


        }
        public string connectionString = "Data Source=HN;Initial Catalog=ProjectA;Integrated Security=True";

        private void cmdAdd_Click(object sender, EventArgs e)
        {

        }
        private void cmdAdd_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Add button Clicked");
            if (txtFName.Text == "")
            {
                lblFNameError.Show();

            }
            else if (txtEmail.Text == "")
            {
                lblEmailError.Show();
            }
            else if (txtRegNo.Text == "")
            {
                lblRegNoError.Show();
            }
            else if (dtpDOB.Value.Year >= DateTime.Now.Year && dtpDOB.Value.Date != DateTime.Today.Date)
            {
                lblDOBError.Show();
            }
            else
            {
                string FirstName = txtFName.Text;
                string LastName = txtLName.Text;
                string Email = txtEmail.Text;
                string Contact = txtContact.Text;
                string RegNo = txtRegNo.Text;
                DateTime DOB = dtpDOB.Value;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection opened");
                string Filter = "SELECT Id FROM Lookup Where Value = '" + cmbGender.Text + "'";
                SqlCommand cmd = new SqlCommand(Filter, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                int Gender = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show(reader.GetInt32(0).ToString());
                        Gender = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No Id found against the given data");
                }
                reader.Close();
                string query = "INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('" + FirstName + "','" + LastName + "','" + Contact + "','" + Email + "','" + DOB + "','" + Gender + "')";
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();

                int Id = 0;
                MessageBox.Show("Break");

                string IdQuery = "Select * from Person";
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(IdQuery, connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                foreach (DataRow dataRow in data.Rows)
                {
                    MessageBox.Show(dataRow[0] + "   " + dataRow[1] + "   " + dataRow[3] + "   " + dataRow[4]);
                    if(dataRow[1].ToString() == FirstName && dataRow[4].ToString() == Email && dataRow[3].ToString() == Contact)
                    {
                        MessageBox.Show(Convert.ToInt32(dataRow[0]).ToString());
                        Id = Convert.ToInt32(dataRow[0]);
                    }
                    else
                    {
                        MessageBox.Show("No Match");
                    }
                }

                string query2 = "INSERT INTO Student(Id,RegistrationNo) values('" + Id + "','" + RegNo + "')";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("data inserted successfully");
            }
        }

        private void txtFName_TextChanged_1(object sender, EventArgs e)
        {
            lblFNameError.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblEmailError.Hide();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            lblDOBError.Hide();
        }

        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            lblRegNoError.Hide();
        }
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Editing");
                string[] names = dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString().Split(' ');
                txtFName.Text = names[0];
                txtLName.Text = names[1];
                txtEmail.Text = dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtContact.Text = dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvStudent.Rows[e.RowIndex].Cells[5].Value.ToString());
                txtRegNo.Text = dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString();
                


            }
            else if (e.ColumnIndex == 1)
            {
                MessageBox.Show("Deleting");
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string query = "Delete From Student where RegistrationNo = '" + dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString() + "'";
                MessageBox.Show(dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString());
                SqlCommand cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();

                query = "Delete From Person where FirstName + ' ' + LastName = '" + dgvStudent.Rows[e.RowIndex].Cells[2].Value.ToString() + "' and Email = '" + dgvStudent.Rows[e.RowIndex].Cells[3].Value.ToString() + "'and Contact = '" + dgvStudent.Rows[e.RowIndex].Cells[4].Value.ToString() + "' ";
                MessageBox.Show(dgvStudent.Rows[e.RowIndex].Cells[6].Value.ToString());
                cmd1 = new SqlCommand(query, connection);
                cmd1.ExecuteNonQuery();
                DataTable data = new DataTable();

                string Query = "SELECT p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', s.RegistrationNo as 'Registration No' FROM Person p INNER JOIN Student s ON p.Id = s.Id";
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
                dgvStudent.DataSource = src;

                var EditButton = new DataGridViewButtonColumn();
                EditButton.Name = "dataGridViewDeleteButton";
                EditButton.HeaderText = "Edit";
                EditButton.Text = "Edit";
                EditButton.UseColumnTextForButtonValue = true;
                this.dgvStudent.Columns.Add(EditButton);

                var deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "dataGridViewDeleteButton";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                this.dgvStudent.Columns.Add(deleteButton);



                MessageBox.Show("Data Deleted Successfully");
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable data = new DataTable();
            string query = "UPDATE Person SET FirstName = '" + txtFName.Text.ToString() + "',  LastName = '" + txtLName.Text.ToString() + "',Email = '" + txtEmail.Text.ToString() + "', Contact = '" + txtContact.Text.ToString() + "',DateOfBirth = '" + dtpDOB.Value + "'" ;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = "UPDATE Student SET RegistrationNo = '" + txtRegNo.Text.ToString() + "'";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            string Query = "SELECT p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', s.RegistrationNo as 'Registration No' FROM Person p INNER JOIN Student s ON p.Id = s.Id";
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
            dgvStudent.DataSource = src;

            MessageBox.Show("Data updated succesfully");

        }
    }
}
