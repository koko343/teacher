using System.ComponentModel.DataAnnotations;

namespace Teacher.Core.Entities.Base
{
    public class EntityBase
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
