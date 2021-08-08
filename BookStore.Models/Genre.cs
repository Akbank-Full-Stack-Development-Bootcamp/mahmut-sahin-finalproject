using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name field can not be empty!")]
        public string Name { get; set; }
        // navigation property
        public virtual IList<Book> Books { get; set; }

    }
}
