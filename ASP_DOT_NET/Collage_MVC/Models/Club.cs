using System.ComponentModel.DataAnnotations;

namespace Collage_MVC.Models
{
    public class Club
    {
        [Key]
        public int id { get; set; }
        
        public string Club_Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
