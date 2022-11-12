using System.ComponentModel.DataAnnotations;

namespace Collage_MVC.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
       
        public string Course_Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
