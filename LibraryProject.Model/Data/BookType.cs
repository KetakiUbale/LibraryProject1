using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Model
{
   public class BookType
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string  Description { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
