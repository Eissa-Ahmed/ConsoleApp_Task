using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.DAL.Entity
{
    public class Posts
    {
        [Key]
        public int Id { get; set; }

        [Required , MinLength(5 , ErrorMessage = "Min Length 5")]
        public string Body { get; set; }
        public DateTime PublishingDate { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("users")]
        public int UserId { get; set; }
        public Users users { get; set; }
        public List<Comments> Comments { get; set; }
       
    }
}
