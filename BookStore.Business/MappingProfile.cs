using AutoMapper;
using BookStore.Business.DTOs;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Genre, GenresListResponseDTO>().ReverseMap();
            CreateMap<AddGenreRequestDTO, Genre>().ReverseMap();
            CreateMap<EditGenreRequestDTO, Genre>().ReverseMap();
        }
    }
}
