using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Model
{
    [Table("account")]
    public class Account
    {
        [Key]   
        public Guid AccountId { get; set; }

        [Required(ErrorMessage = "DateCreated is required.")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Account Type is required.")]
        public string AccountType { get; set; }

        [ForeignKey(nameof(Owner))]
        public Guid OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}