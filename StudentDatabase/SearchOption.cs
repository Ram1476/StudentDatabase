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

namespace StudentDatabase
{
    public partial class SearchOption : Form
    {                                          
        public SearchOption()
        {
            InitializeComponent();
            displayGrid.Visible = false;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //Student Name, Student Roll No, Subject Name and Subject Marks.
            displayGrid.Visible = true;
            try
            {
                SqlConnection Con = new SqlConnection("server = DESKTOP-39SGDTH\\SQLEXPRESS; Database = studentsRecord; integrated Security = true");
                
                
                SqlDataAdapter cmd = new SqlDataAdapter($"Select StudentName,StudentRollNo,SubjectName,SubjectMarks from StudentMarks Where studentName = '{txtStName.Text}' or (studentRollNo = '{txtStRollNo.Text}' or subjectName = '{txtSubName.Text}');", Con);

                DataSet ds = new DataSet();

                cmd.Fill(ds, "StudentMarks");

                displayGrid.DataSource = ds.Tables["studentMarks"].DefaultView;

                MessageBox.Show("Student Detail Displayed SuccessFully ");
                
               
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
    }
}
