﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Business.DTOs
{
    public class EditGenreRequestDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}