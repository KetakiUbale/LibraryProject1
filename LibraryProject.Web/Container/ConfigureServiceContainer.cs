using System;
using AutoMapper;
using LibraryProject.Model;
using LibraryProject.Persistence;
using LibraryProject.Service;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryProject.Web
{
    public static class ConfigureServiceContainer
    {
        public static void AddTransientService(this IServiceCollection services)
        {
            services.AddTransient<BookContext>();
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
            services.AddTransient<IBookService, BookService>();

            services.AddTransient<IFeeStatusService, FeeStatusService>();

            services.AddTransient<IAuthorService, AuthorService>();

            services.AddTransient<IBookTypeService, BookTypeService>();


        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(m =>
              {
                  m.AddProfile(new BookLotProfile());

              });
            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
        }
    }

}
