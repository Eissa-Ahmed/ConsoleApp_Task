using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DAL.Entity;

namespace Task.BL.ModelVM
{
    public class UserVM
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(10, ErrorMessage = "Max Length 30")]
        public string FName { get; set; }
        public string? LName { get; set; }

        [Required, MaxLength(50, ErrorMessage = "Max Length 50")]
        public string Email { get; set; }

        [Required, MaxLength(20, ErrorMessage = "Max Length 20")]
        public string Password { get; set; }
        public bool IsDeleted { get; set; }

    }
}
