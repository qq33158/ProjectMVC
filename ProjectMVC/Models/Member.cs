using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectMVC.Models
{
    public class Member
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [DisplayName("序號")]
        public int Id { get; set; }
        [Required(ErrorMessage ="姓名不可空白")]
        [DisplayName("姓名")]
        public string Name { get; set; }
        [DisplayName("信箱")]
        public string? Mail { get; set; }
    }
}
