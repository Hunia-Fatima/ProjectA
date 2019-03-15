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
        public int EditId = 0;
        public Advisor()
        {
            InitializeComponent();
            lblDOBError.Hide();
            lblEmailError.Hide();
            lblFNameError.Hide();
            lblDesignationError.Hide();
            dgvAdvisor.ReadOnly = true;


            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Query = "SELECT p.Id, p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', a.Designation, a.Salary FROM Person p INNER JOIN Advisor a ON p.Id = a.Id";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            DataTable data = new DataTable();
            sda.Fill(data);

            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvAdvisor.DataSource = src;
            this.dgvAdvisor.Columns["Id"].Visible = false;

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
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                lblFNameError.Show();

            }
            else if (txtEmail.Text == "")
            {
                lblEmailError.Show();
            }
            else if (cmbDesignation.Text == "")
            {
                lblDesignationError.Show();
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
                string Designation = cmbDesignation.Text;
                decimal Salary = numSalary.Value;
                DateTime DOB = dtpDOB.Value;
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string Filter = "SELECT Id FROM Lookup Where Value = '" + cmbGender.Text + "'";
                SqlCommand cmd = new SqlCommand(Filter, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                int Gender = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Gender = reader.GetInt32(0);
                    }
                }
                else
                {
                    MessageBox.Show("No Id found against the given data");
                }

                reader.Close();

                Filter = "SELECT Id FROM Lookup Where Value = '" + cmbDesignation.Text + "'";
                cmd = new SqlCommand(Filter, connection);
                reader = cmd.ExecuteReader();
                int DesignationId = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DesignationId = reader.GetInt32(0);
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
                string IdQuery = "Select * from Person";
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = new SqlCommand(IdQuery, connection);
                DataTable data = new DataTable();
                sda.Fill(data);
                foreach (DataRow dataRow in data.Rows)
                {
                    if (dataRow[1].ToString() == FirstName && dataRow[4].ToString() == Email && dataRow[3].ToString() == Contact)
                    {
                        Id = Convert.ToInt32(dataRow[0]);
                    }
                }

                string query2 = "INSERT INTO Advisor(Id,Designation,Salary) values('" + Id + "','" + DesignationId + "','" + Salary + "')";
                SqlCommand cmd2 = new SqlCommand(query2, connection);
                cmd2.ExecuteNonQuery();
                string Query = "SELECT p.Id, p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', a.Designation, a.Salary FROM Person p INNER JOIN Advisor a ON p.Id = a.Id";
                SqlDataAdapter sda1 = new SqlDataAdapter();
                DataTable data1 = new DataTable();
                sda1.SelectCommand = new SqlCommand(Query, connection);
                sda1.Fill(data1);
                BindingSource src = new BindingSource();
                src.DataSource = data1;
                dgvAdvisor.DataSource = src;
                this.dgvAdvisor.Columns["Id"].Visible = false;

                MessageBox.Show("data inserted successfully");
            }
        }

        private void dgvAdvisor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string[] names = dgvAdvisor.Rows[e.RowIndex].Cells[3].Value.ToString().Split(' ');
                txtFName.Text = names[0];
                txtLName.Text = names[1];
                txtEmail.Text = dgvAdvisor.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtContact.Text = dgvAdvisor.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvAdvisor.Rows[e.RowIndex].Cells[6].Value.ToString());
                cmbDesignation.Text = dgvAdvisor.Rows[e.RowIndex].Cells[7].Value.ToString();
                EditId = Convert.ToInt32(dgvAdvisor.Rows[e.RowIndex].Cells[2].Value);



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


                    string Filter = "SELECT Id FROM Person Where FirstName + ' ' + LastName = '" + dgvAdvisor.Rows[e.RowIndex].Cells[3].Value.ToString() + "' and Email = '" + dgvAdvisor.Rows[e.RowIndex].Cells[4].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(Filter, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int PersonId = 0;
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            PersonId = reader.GetInt32(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Account found against the given data");
                    }

                    reader.Close();

                    string query = "Delete From Advisor where Id = '" + PersonId + "'";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();

                    query = "Delete From Person where Id = '" + PersonId + "' ";
                    cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();
                    DataTable data = new DataTable();

                    string Query = "SELECT p.Id, p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', a.Designation ,a.Salary FROM Person p INNER JOIN Advisor a ON p.Id = a.Id";
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = new SqlCommand(Query, connection);
                    sda.Fill(data);

                    BindingSource src = new BindingSource();
                    src.DataSource = data;
                    dgvAdvisor.DataSource = src;
                    this.dgvAdvisor.Columns["Id"].Visible = false;

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

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesignationError.Hide();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
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

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            DataTable data = new DataTable();

            string Filter = "SELECT Id FROM Lookup Where Value = '" + cmbDesignation.Text + "'";
            SqlCommand cmd = new SqlCommand(Filter, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int DesignationId = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    DesignationId = reader.GetInt32(0);
                }
            }
            else
            {
                MessageBox.Show("No Id found against the given data");
            }
            reader.Close();

            MessageBox.Show(EditId.ToString());
            string query = "UPDATE Person SET FirstName = '" + txtFName.Text.ToString() + "',  LastName = '" + txtLName.Text.ToString() + "',Email = '" + txtEmail.Text.ToString() + "', Contact = '" + txtContact.Text.ToString() + "',DateOfBirth = '" + dtpDOB.Value + "'Where Id = '" + EditId + "'";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            query = "UPDATE Advisor SET Designation = '" + DesignationId + "', Salary = '" + numSalary.Value+ "'Where Id = '" + EditId + "'";
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            string Query = "SELECT p.Id, p.FirstName + ' ' + p.LastName as Name, p.Email, p.Contact, p.DateOfBirth as 'Date of Birth', a.Designation, a.Salary FROM Person p INNER JOIN Advisor a ON p.Id = a.Id";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = new SqlCommand(Query, connection);
            sda.Fill(data);

            BindingSource src = new BindingSource();
            src.DataSource = data;
            dgvAdvisor.DataSource = src;
            this.dgvAdvisor.Columns["Id"].Visible = false;

            MessageBox.Show("Data updated succesfully");
        }
    }
}
