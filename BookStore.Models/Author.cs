using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name field can not be empty!")]
        [MinLength(2, ErrorMessage = "Minimum length is 2!")]
        [MaxLength(200, ErrorMessage = "Maximum length is 200!")]
         public string Name { get; set; }
        public string Surname { get; set; }
        public string Bio { get; set; }
        public virtual IList<Book> Books { get; set; }
    }
}
