using System;
using System.Collections;
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
    public partial class EditData : Form
    {
        int  mark; string idno,studentName, subjectName;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }
        SqlConnection Con = new SqlConnection("server = DESKTOP-39SGDTH\\SQLEXPRESS; Database = studentsRecord; integrated Security = true");

        private void buttonSave_Click(object sender, EventArgs e)
        {
            idno = textBoxRollNo.Text;
            studentName = textBoxStudentName.Text;
            subjectName = textBoxSubName.Text;
            mark = Convert.ToInt32(textBoxSubMark.Text);
            SqlCommand cmd = new SqlCommand($"Update studentMarks set subjectMarks = {mark} Where StudentRollNo = '{idno}' and studentName = '{studentName}'and SubjectName = '{subjectName}'", Con);
            Con.Open();
            cmd.ExecuteNonQuery();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show($"StudentID: {idno}\n\nSubjectName: {studentName}\n\nSubjectMark: {mark}\n\nSuccessfully Updated","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Failed Updating studentRecord\nStudentID: {idno} \nSubjectName: {studentName} \nSubjectMark {mark}", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            Con.Close();
            Con.Close();
            
        }

        public EditData(string rollNo, string sName, string subName, int sMark)
        {
            InitializeComponent();
            idno = rollNo;
            studentName = sName;
            subjectName = subName;
            mark = sMark;
        } 

        private void EditData_Load(object sender, EventArgs e)
        {
            textBoxRollNo.Text = idno.ToString();
            textBoxStudentName.Text = studentName;
            textBoxSubName.Text = subjectName;
            textBoxSubMark.Text = mark.ToString();
        }

        

    }
}
