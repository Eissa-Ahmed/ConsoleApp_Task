using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entity;

namespace Task.BL.ModelVM
{
    public class PostsVM
    {
        [Key]
        public int Id { get; set; }

        [Required, MinLength(5, ErrorMessage = "Min Length 5")]
        public string Body { get; set; }
        public DateTime PublishingDate { get; set; }
        public bool IsDeleted { get; set; }
        public int UserId { get; set; }
        public Users user { get; set; }

    }
}
