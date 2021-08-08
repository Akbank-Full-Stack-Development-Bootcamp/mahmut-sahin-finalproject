using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name field can not be empty!")]
        [MinLength(2, ErrorMessage ="Minimum length is 2!")]
        [MaxLength(200, ErrorMessage ="Maximum length is 200!")]
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public string CoverPath { get; set; }
        public int? GenreId { get; set; }
        // Navigation property
        public virtual Genre Genre { get; set; }
        public virtual IList<Author> Authors { get; set; }
    }
}
