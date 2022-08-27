﻿using MovieLibrary.ServiceModels.Enums;

namespace MovieLibrary.ServiceModels.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
    }
}
