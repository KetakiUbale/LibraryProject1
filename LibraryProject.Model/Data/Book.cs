using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryProject.Model
{
    public class Book
    {

        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Price { get; set; }

        [Required]
        public int AuthorId {get; set;}

        [Required]
        public int BookTypeId { get; set; }

        [Required]
        public int FeeStatusId { get; set; }

        [Required]
        public virtual Author Author { get; set; }

        [Required]
        public virtual BookType BookType { get; set; }

        [Required]
        public virtual FeeStatus FeeStatus { get; set; }



    }
}
