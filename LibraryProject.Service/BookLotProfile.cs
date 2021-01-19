using AutoMapper;
using LibraryProject.Model;
using LibraryProject.ViewModel;

namespace LibraryProject.Service
{
    public class BookLotProfile:Profile
    {
        public BookLotProfile()
        {
            CreateMap<Book, BookViewModel>();
        }
    }
}
