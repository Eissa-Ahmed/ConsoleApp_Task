using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entity
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(5, ErrorMessage = "Min Length 5")]
        public string Body { get; set; }
        public DateTime PublishingDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? UserId { get; set; }
        public int PostId { get; set; }

        [ForeignKey(nameof(UserId))]
        public Users? User { get; set; }

        [ForeignKey(nameof(PostId))]
        public Posts Posts { get; set; }
    }
}
