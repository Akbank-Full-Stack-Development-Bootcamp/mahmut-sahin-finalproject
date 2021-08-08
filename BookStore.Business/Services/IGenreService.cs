using BookStore.Business.DTOs;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.Services
{
    public interface IGenreService
    {
        IList<GenresListResponseDTO> GetAll();
        int Add(AddGenreRequestDTO newGenre);
        Genre GetById(int id);
        int UpdateGenre(EditGenreRequestDTO request);
        void DeleteGenre(int id);
    }
}
