using AutoMapper;
using BookStore.Business.DTOs;
using BookStore.DataAccess.Repositories;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository repository;
        private readonly IMapper mapper;

        public GenreService(IGenreRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public int Add(AddGenreRequestDTO genreRequest)
        {
            var newGenre = mapper.Map<Genre>(genreRequest);
            int newId = repository.Add(newGenre);
            return newId;
        }

        public void DeleteGenre(int id)
        {
            repository.Delete(id);
        }

        public IList<GenresListResponseDTO> GetAll()
        {
            var genreList = repository.GetAll().ToList();
            var dtoList = mapper.Map<List<GenresListResponseDTO>>(genreList);
            return dtoList;
        }

        public Genre GetById(int id)
        {
            var result = repository.GetById(id);
            return result;
        }

        public int UpdateGenre(EditGenreRequestDTO request)
        {
            var genre = mapper.Map<Genre>(request);
            int id = repository.Update(genre);
            return id;
        }
    }
}
