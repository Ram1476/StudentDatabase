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
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Security.Cryptography.X509Certificates;

namespace StudentDatabase
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
            
        }
        Studentdetails Adding = new Studentdetails();
        DateTime NowTime = DateTime.Now;
        int count = 0;
        public static int Transfer;

       private void btnStart_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["StudentData.CSV"];
            string processed = ConfigurationManager.AppSettings["Processed.CSV"];
            string error = ConfigurationManager.AppSettings["Error.CSV"];

            
            string FilePath = Path.GetFileNameWithoutExtension(path) + $"({NowTime.ToString("h-mm-tt")}).csv";
            //System.IO.File.AppendAllText(@"C:\Users\Admin\Desktop\Ram\Assessment\Error\StudentMarks.csv", Environment.NewLine + "Duration: " + Path.GetFileNameWithoutExtension(path) + Environment.NewLine);
            int result;
            if (File.Exists(path))
                {

                    var csvFiledescription = new CsvFileDescription
                    {
                        FirstLineHasColumnNames = true,
                        IgnoreUnknownColumns = true,
                        SeparatorChar = ','
                    };
                   
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDBCS"].ConnectionString);
                    try
                    {
                        var csvContext = new CsvContext();
                        var students = csvContext.Read<Students>("StudentMarks.csv", csvFiledescription);
                        
                        int checkvalue = 0;

                        var Rechecking = new List<string> ();
                        foreach (var student in students)
                        {

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
                                    SqlCommand da = new SqlCommand($"insert into studentMarks(studentRollno,SubjectID,SubjectName,StudentID,StudentName,SubjectMarks)\r\n" +
                                        $"select '{student.student_RollNo}',{id2},'{student.subject_Name}',{id1},'{student.student_Name}',{student.marks}" +
                                        $"where not exists (Select * from Studentmarks where studentRollno = '{student.student_RollNo}' and SubjectID = {id2} and" +
                                        $" SubjectName = '{student.subject_Name}' and StudentID = {id1} and StudentName = '{student.student_Name}' and SubjectMarks = {student.marks});", con);

                                    result = da.ExecuteNonQuery();
                                    if (result == 1) 
                                    {
                                        checkvalue += 1;
                                        if (!(Rechecking.Contains(student.student_RollNo)))
                                            {
                                            Rechecking.Add(student.student_RollNo);
                                            }
                                    }
                                

                                
                                    dr1.Close();
                                }
                                con.Close();

                            }
                        }
                        if (count == checkvalue)
                        {
                            string destination = processed + FilePath;
                            File.Move(path,destination);
                            MessageBox.Show($"Successfully Processed the CSV File\n\nTotal No.of Rows in the File:{count}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show($"Student Data Uploaded to  SQL Server\n\nNo.of Student Record Processed : {groupResult.Count()}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else 
                        {
                            if (checkvalue == 0) 
                            {
                                throw new Exception("Data Already Exist in the dataBase");
                            }
                            else 
                            {
                                int valueNew = Rechecking.Count();
                                string destination = processed + FilePath;
                                MessageBox.Show($"Successfully Processed the CSV File\n\nTotal No.of Rows in the File:{count}\n\n Total Rows Processed {checkvalue}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show($"Student Data Uploaded to  SQL Server\n\nNo.of Student Record Processed : {valueNew}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                File.Move(path, destination);

                        }

                            
                        }
                        Transfer = count;
                    }
                    catch (Exception ex)
                    {
                        string destination = error + FilePath  ;
                        File.Move(path, destination);
                        MessageBox.Show($"Error Processing the CSV File : {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("No CSV file found in the preferred path","Failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
            
          
            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchOption s1 = new SearchOption();
            s1.Show();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
           
        }
    }
   
}
