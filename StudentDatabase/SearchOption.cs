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
using System.Diagnostics;
using StudentDatabase.StudentsRecordDataSetTableAdapters;

namespace StudentDatabase
{
    public partial class SearchOption : Form
    {                                          
        public SearchOption()
        {
            InitializeComponent();
            displayGrid.Visible = false;
            displayGrid.AllowUserToDeleteRows = true;

        }
        SqlConnection Con = new SqlConnection("server = DESKTOP-39SGDTH\\SQLEXPRESS; Database = studentsRecord; integrated Security = true");
        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            
           
             
            try 
            {

                

                if (txtStName.Text != "" && txtStRollNo.Text != "" && txtSubName.Text != "")
                {
                    
                    SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks Where studentName = '{txtStName.Text}' and (studentRollNo = '{txtStRollNo.Text}' and subjectName = '{txtSubName.Text}');", Con);

                    DataSet ds = new DataSet();

                    cmd.Fill(ds, "StudentMarks");

                    displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;
                    

                    displayGrid.Visible = true;
                    displayGrid.AllowUserToAddRows = false;

                    if (displayGrid.RowCount > 0)
                    {

                        MessageBox.Show("Student Detail Displayed SuccessFully ");
                    }
                    else 
                    {
                        MessageBox.Show("No available Data to display based on your search options");
                    }
                }
                else 
                {
                    SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks Where studentName = '{txtStName.Text}' or (studentRollNo = '{txtStRollNo.Text}' or subjectName = '{txtSubName.Text}');", Con);

                    DataSet ds = new DataSet();

                    cmd.Fill(ds, "StudentMarks");

                    displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

                    displayGrid.Visible = true;
                    displayGrid.AllowUserToAddRows = false;
                    
                    

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Processing  - Check Student Details or Student Doesnot Exist" + Environment.NewLine + ex.Message);
            }
        }

        private void SearchOption_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentsRecordDataSet.studentMarks' table. You can move, or remove it, as needed.
            this.studentMarksTableAdapter.Fill(this.studentsRecordDataSet.studentMarks);


        }

        private void txtStRollNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }

        private void displayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            
            if (displayGrid.Columns[e.ColumnIndex].Name == "Delete") 
            {
                DataGridViewRow row = displayGrid.Rows[e.RowIndex];
                try
                {

                    if (MessageBox.Show($"Are you sure , You Want to delete this record {row.Cells[0].Value} ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SqlCommand cmd = new SqlCommand("Delete from studentMarks where StudentRollNo = @RollNo and SubjectName = @SubName",Con);
                        cmd.Parameters.AddWithValue("@RollNo", row.Cells[0].Value);
                        cmd.Parameters.AddWithValue("@SubName", row.Cells[1].Value);
                        Con.Open();
                        cmd.ExecuteNonQuery();
                        Con.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error Processing the Required Function" + Environment.NewLine+ ex.Message );
                }
            }
            LoadData();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks;", Con);

            DataSet ds = new DataSet();

            cmd.Fill(ds, "StudentMarks");

            displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

            displayGrid.Visible = true;

            displayGrid.AllowUserToAddRows = false;
        }
    }
}
