using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MidtermProject.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string TieuDe { get; set; }

        [Required]
        public string NoiDung { get; set; }

        public string TacGia { get; set; }

        public int CateId { get; set; }
        public Category Category { get; set; }
    }
}
