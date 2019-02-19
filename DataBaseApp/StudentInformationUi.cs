using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseApp.Models;

namespace DataBaseApp
{
    public partial class StudentInformationUi : Form
    {
        Student student = new Student();

        string connectionString = @"Server=LAB-301-03\SQLEXPRESS; Database=StudentDb; Integrated Security = true ";

        private SqlConnection sqlconnection;
        public StudentInformationUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //1
            

            student.Name = nameTextBox.Text;
            student.Address = addressTextBox.Text;
            student.RegNo = regNoTextBox.Text;

            student.ContactNo = contactNoTextBox.Text;
            student.DepartmentId = Convert.ToInt32(depatmentIdTextBox.Text);

            bool isSaved = Add(student);

            if (isSaved)
            {
                MessageBox.Show("Saved");
                
            }
            else
            {
                MessageBox.Show("Not Saved");
                
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private bool Add(Student student)
        {
            bool isSuccess = false;
           
            
            
            try
            {

                //2

                //3
                SqlConnection sqlconnetion = new SqlConnection(connectionString);
                //4
                string query = @"INSERT INTO Students (Name, Address, regNo, contact,departmentId) VALUES ('" + student.Name + "','" + student.Address + "','" + student.ContactNo + "','" + student.RegNo + "'," + student.DepartmentId + ")";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                //6
                sqlconnection.Open();
              //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    //MessageBox.Show("Saved");
                    isSuccess = true;
                }
                else
                {
                    //MessageBox.Show("Not Saved");
                    isSuccess = false;
                }
                //8
                sqlconnection.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            return isSuccess;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //1

            DataTable dataTable = new DataTable();
            
             dataTable= Show();

            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }

            else
            {
                showDataGridView.DataSource = null;
            }
           

        }

        private DataTable Show()
        {
            DataTable dataTable = new DataTable();
            try
            {
                //2
                string connectionString = @"Server=LAB-301-03\SQLEXPRESS; Database=StudentDb; Integrated Security = true ";
                //3
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //4
                string query = @"SELECT * FROM Students";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

               

                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();
               


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return dataTable;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //1
            student.Name = nameTextBox.Text;
            student.Address = addressTextBox.Text;
            student.RegNo = regNoTextBox.Text;

            student.ContactNo = contactNoTextBox.Text;
            student.DepartmentId = Convert.ToInt32(depatmentIdTextBox.Text);

            student.ID = Convert.ToInt32(IdTextBox.Text);
            
            bool isUpdated = Update(student);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not updated");
            }


        }

        private bool Update(Student student)
        {
            bool isSuccess = false;
            try
            {

                //2

                //3
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //4
                string query = @"UPDATE Students set Name='" + student.Name + "',Address='" + student.Address + "', regNo='" + student.RegNo + "', contact='" + student.ContactNo + "',departmentId=" + student.DepartmentId+" WHERE ID = "+student.ID+"";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                   // MessageBox.Show("Saved");
                    isSuccess = true;
                }
                else
                {
                   // MessageBox.Show("Not Saved");
                    isSuccess = false;
                }
                //8

                
                
                sqlConnection.Close();
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isSuccess;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            bool isDelete = Delete(student);

            if (isDelete)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private bool Delete(Student student)
        {
            bool isSuccess = false;
            try
            {
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //4
                string query = @"DELETE Students WHERE ID = " + student.ID + "";
                //5
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //6
                sqlConnection.Open();
                //7
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    // MessageBox.Show("Saved");
                    isSuccess = true;
                }
                else
                {
                    // MessageBox.Show("Not Saved");
                    isSuccess = false;
                }
                //8
                sqlConnection.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isSuccess;

        }

        private void FindButton_Click(object sender, EventArgs e)
        {   
            student.ID = Convert.ToInt32(IdTextBox.Text);
            
            bool isFind = Find(student);

            if (isFind)
            {
                MessageBox.Show("It Exists");
            }
            else
            {
                MessageBox.Show("Doesn't Exists");
            }
        }

        private bool Find(Student student)
        {
            bool isSuccess = false;
            
            try
            {
                string query = @"SELECT *FROM Students WHERE ID =" + student.ID + "";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
               
                DataTable dataTable = new DataTable();
                
                sqlDataAdapter.Fill(dataTable);
               
                if (dataTable.Rows.Count>0)
                {
                    isSuccess = true;
                }

                else
                {
                    isSuccess = false;
                }
              
                sqlconnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return isSuccess;
        }
    }
}
