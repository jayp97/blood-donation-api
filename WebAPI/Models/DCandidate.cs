using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class DCandidate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")] public string FullName { get; set; }
        [Column(TypeName = "nvarchar(20)")] public string Mobile { get; set; }
        [Column(TypeName = "nvarchar(100)")] public string Address { get; set; }
        [Column(TypeName = "nvarchar(3)")] public string BloodGroup { get; set; }
        [Column(TypeName = "nvarchar(100)")] public string Email { get; set; }
        public int Age { get; set; }
    }
}
