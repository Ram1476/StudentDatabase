using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace StudentDatabase
{
    public partial class StartProcessing : Form
    {
        public StartProcessing()
        {
            InitializeComponent();
        }
        Studentdetails adding = new Studentdetails();
        private void btnStart_Click(object sender, EventArgs e)
        {
            string path = "D:\\Assessment\\Unprocessed\\StudentMarks.csv";
            
    

                if (File.Exists(path))
                {

                    var csvFiledescription = new CsvFileDescription
                    {
                        FirstLineHasColumnNames = true,
                        IgnoreUnknownColumns = true,
                        SeparatorChar = ','
                    };
                    SqlConnection con = new SqlConnection("server = DESKTOP-39SGDTH\\SQLEXPRESS; database = studentsRecord;integrated Security = true");
                    try
                    {
                        var csvContext = new CsvContext();
                        var students = csvContext.Read<Students>("StudentMarks.csv", csvFiledescription);
                        int count = 1;
                        foreach (var student in students)
                        {

                            //Students student1 = new Students();
                            //string rollno = student.student_RollNo;
                            //foreach (var student2 in students) 
                            //{
                            //    if (student2.student_RollNo == rollno) 
                            //    {
                            //        student1.student_Name = student2.student_Name;
                            //        student1.student_RollNo = student2.student_RollNo;
                            //        student1.marks = student2.marks;
                            //        student1.subject_Name = student2.subject_Name;
                            //        adding.CreateStudents(student1);

                            //    } 
                            //}

                            count++;
                        }
                        var groupResult = students.GroupBy(s => s.student_RollNo);
                        foreach (var group in groupResult)
                        {
                            foreach (var student in group)
                            {
                                if (group.Key == student.student_RollNo)
                                {
                                    SqlCommand dc = new SqlCommand($"Select ID from students where StudentName = '{student.student_Name}'", con);
                                    SqlCommand dc1 = new SqlCommand($"Select ID from subject where SubjectName = '{student.subject_Name}'", con);
                                    con.Open();
                                    SqlDataReader dr = dc.ExecuteReader();
                                    dr.Read();
                                    int id1 = Convert.ToInt32(dr["ID"]);
                                    dr.Close();

                                    SqlDataReader dr1 = dc1.ExecuteReader();

                                    dr1.Read();
                                    int id2 = Convert.ToInt32(dr1["ID"]);
                                    dr1.Close();
                                    SqlCommand da = new SqlCommand($"insert into studentMarks(studentRollno,SubjectID,SubjectName,StudentID,StudentName,SubjectMarks)\r\nvalues('{student.student_RollNo}',{id2},'{student.subject_Name}',{id1},'{student.student_Name}',{student.marks});", con);

                                    da.ExecuteNonQuery();


                                    dr1.Close();
                                }
                                con.Close();

                            }
                        }

                        File.Move("D:\\Assessment\\Unprocessed\\StudentMarks.csv", "D:\\Assessment\\Processed\\StudentMarks.csv");
                        MessageBox.Show($"Successfully Processed the CSV File\nTotal No.of Rows in the File:{count}");
                        MessageBox.Show($"Student Data Uploaded to  SQL Server\nNo.of Student Record Processed : {groupResult.Count()} ");

                    }
                    catch (Exception ex)
                    {
                        File.Move("D:\\Assessment\\Unprocessed\\StudentMarks.csv", "D:\\Assessment\\Error\\StudentMarks.csv");
                        MessageBox.Show("Error Processing the CSV File : " + Environment.NewLine + ex.Message);
                    }
                }
                else 
                {
                    MessageBox.Show("No CSV file found in the preferred path");

                }
            
          
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchOption s1 = new SearchOption();
            s1.Show();
        }
    }
   
}
