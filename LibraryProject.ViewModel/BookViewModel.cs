using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryProject.ViewModel
{
   public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int BookTypeId { get; set; }
        public string BookTypeName { get; set; }
        public int FeeStatusId { get; set; }
        public string FeeStatusName { get; set; }

    }
}
