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
using System.Configuration;


namespace StudentDatabase
{
    public partial class SearchOption : Form
    {                                          
        public SearchOption()
        {
            InitializeComponent();
            displayGrid.Visible = false;
            displayGrid.AllowUserToDeleteRows = true;

            ScrollValue = 0;
           
            buttonNext.Visible = false;
            buttonPrevious.Visible = false;

        }

        int ScrollValue ;
        
        SqlConnection Con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDBCS"].ConnectionString);

        
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

                        MessageBox.Show("Student Detail Displayed SuccessFully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("No available Data to display based on your search options","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

                    if (displayGrid.RowCount > 0)
                    {

                        MessageBox.Show("Student Detail Displayed SuccessFully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No available Data to display based on your search options", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



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

            // TODO: This line of code loads data into the 'studentsRecordDataSet1.studentMarks' table. You can move, or remove it, as needed.
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
            
            DataGridViewRow row = displayGrid.Rows[e.RowIndex];
            string studentRollNo = (row.Cells[1].Value.ToString());
            string studentName = row.Cells[2].Value.ToString();
            string subjectName = row.Cells[3].Value.ToString();
            int subjectMark = Convert.ToInt32(row.Cells[4].Value);

            try
            {
                if (displayGrid.Columns[e.ColumnIndex].Name == "Delete")
                {

                    try  
                    {

                        if (MessageBox.Show($"Are you sure , You Want to delete this record: {row.Cells[1].Value} ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand($"Delete from studentMarks where StudentRollNo = '{row.Cells[1].Value}'  and SubjectName = '{row.Cells[3].Value}'", Con);

                            Con.Open();

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show($"StudentID: {row.Cells[1].Value}\n\nSubjectName:{row.Cells[3].Value}\n\nSuccessfully Deleted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                

                            }
                            else
                            {
                                MessageBox.Show($"Error Deleting\nStudentID: {row.Cells[0].Value}\n\nSubjectName:{row.Cells[2].Value}\n\nNot Deleted", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            Con.Close();
                            Con.Close();
                            

                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"Error Processing the Required Function\n\n{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                  
                }
                else
                {


                   
                    EditData editValue = new EditData(studentRollNo, studentName, subjectName, subjectMark);
                    editValue.ShowDialog();
                    
                    
                   
                }
                LoadData(studentName, studentRollNo, subjectName);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error Editing / Deleting your Data \n{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
          
            
        }

      
        public void LoadData(string StudentName,string StudentRollNo,string subjectName)
        {
            SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks Where studentName = '{StudentName}' and (studentRollNo = '{StudentRollNo}' and subjectName = '{subjectName}');", Con);

            DataSet ds = new DataSet();

            cmd.Fill(ds, "StudentMarks");

            displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

            displayGrid.Visible = true;

            displayGrid.AllowUserToAddRows = false;
        }

        private void SearchOp_Activated(object sender, EventArgs e)
        {
            
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MainMenu NewValue = new MainMenu();

            SqlCommand cmc = new SqlCommand("Select count (*) From StudentMarks", Con);
            Con.Open();
            int count = (int)cmc.ExecuteScalar();
            Con.Close();

            SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks;", Con);

            

            DataSet ds = new DataSet();

            ScrollValue += 5;

            if (ScrollValue <= 0) 
            {
                ScrollValue = 0;  
                
            }

            if (ScrollValue >= count) 
            {
                ScrollValue = ScrollValue - 5;
                MessageBox.Show("You have Reached the Maximum Limit ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            ds.Clear();
            

            cmd.Fill(ds, ScrollValue, 5, "StudentMarks");

            displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

            displayGrid.Visible = true;

            displayGrid.AllowUserToAddRows = false;

            

            

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            SqlCommand cmc = new SqlCommand("Select count (*)  From StudentMarks", Con);
            Con.Open();
            int count = (int)cmc.ExecuteScalar();
            Con.Close ();

            SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks;", Con);

            DataSet ds = new DataSet();

            ScrollValue -= 5;
            if (ScrollValue >  count)
            {
                ScrollValue = count-5;
            }
            else if (ScrollValue == count) 
            {
                ScrollValue = ScrollValue - 5;
            }
            ds.Clear();
            if (ScrollValue >= 0)
            {
                cmd.Fill(ds, ScrollValue, 5, "StudentMarks");
            }
            else 
            {
                ScrollValue = 0;
                cmd.Fill(ds, ScrollValue, 5, "StudentMarks");
                MessageBox.Show("You have Reached the minimum Limit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           
           
            displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

            displayGrid.Visible = true;

            displayGrid.AllowUserToAddRows = false;
            

        }

        private void buttonViewAll_Click_1(object sender, EventArgs e)
        {
            buttonNext.Visible = true;
            buttonPrevious.Visible = true;
            SqlCommand cmc = new SqlCommand("Select count (*)  From StudentMarks", Con);
            Con.Open();
            int count = (int)cmc.ExecuteScalar();
            Con.Close();

            SqlDataAdapter cmd = new SqlDataAdapter($"Select id,StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks;", Con);

            DataSet ds = new DataSet();

            cmd.Fill(ds, ScrollValue, 5, "StudentMarks");

            displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

            displayGrid.Visible = true;

            displayGrid.AllowUserToAddRows = false;
        }
    }
   
}
