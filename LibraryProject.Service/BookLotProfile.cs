using AutoMapper;
using LibraryProject.Model;
using LibraryProject.ViewModel;

namespace LibraryProject.Service
{
    public class BookLotProfile:Profile
    {
        public BookLotProfile()
        {
            CreateMap<Book, BookViewModel>()
            .ForMember(destinantinMember => destinantinMember.AuthorName, Options => Options.MapFrom(SourceMember => SourceMember.Author.Name))
            .ForMember(destinantinMember => destinantinMember.FeeStatusName, Options => Options.MapFrom(SourceMember => SourceMember.FeeStatus.Name))

            .ForMember(destinantinMember => destinantinMember.BookTypeName, Options => Options.MapFrom(SourceMember => SourceMember.BookType.Name));

            //.ForMember(destinantinMember => destinantinMember.BookTypeId, Options => Options.MapFrom(SourceMember => SourceMember.BookType.Id));

            
            CreateMap<BookViewModel, Book>();

        }

    }
}
