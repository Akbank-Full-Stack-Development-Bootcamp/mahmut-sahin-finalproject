using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.DTOs
{
    public class AddGenreRequestDTO
    {
        [Required]
        [MinLength(3, ErrorMessage ="Minimum length is 3!")]
        public string Name { get; set; }
    }
}
