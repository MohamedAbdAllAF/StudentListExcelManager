using StudentListExcelManager.Models.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentListExcelManager.Models
{
    public class Phone
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        [Required, MaxLength(11)]
        [RegularExpression(@"^\d+$")]
        public string PhoneNumber { get; set; }

        public PhoneType Type { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
