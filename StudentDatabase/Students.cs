using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    [Serializable]
    public class Students
    {
        [CsvColumn(Name = "StudentName")]
        public string student_Name { get; set; }
        
        [CsvColumn(Name = "StudentRollNumber")]
        public string student_RollNo { get; set;}
        
        [CsvColumn(Name = "Subject Marks")]
        public int marks { get; set; }
        
        [CsvColumn(Name = "Subject Name")]
        public string subject_Name { get; set; }

        
       

    }
    public class Studentdetails 
    {
        //List<Students> studentslist = new List<Students>();
        //public void CreateStudents(Students stud) 
        //{
        //    studentslist.Add(stud);
        //}
    }
    
}
