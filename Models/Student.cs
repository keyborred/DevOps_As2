using System.ComponentModel.DataAnnotations;

namespace Cholo_841665_As1.Models
{
    //student class
    public class Student
    {
        //declaration of variables used
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal GPA { get; set; }

    }
}
