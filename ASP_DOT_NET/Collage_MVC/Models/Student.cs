using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Collage_MVC.Models
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
       
        public string Student_Name { get; set; }
        public DateTime Student_dob { get; set; }

        // public string Course_Name { get; set; }
       /* public int Course_id { get; set; }
        
        public int Club_id { get; set; }*/

       
    }
}
