﻿using System.ComponentModel.DataAnnotations;

namespace JamesVIdeoGameStore.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a platform (Xbox, PS5, PC, etc.)")]
        public string Platform { get; set; }

        [Required(ErrorMessage = "Please enter a genre")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Please enter a developer")]
        public string Developer { get; set; }

        [Required(ErrorMessage = "Please enter a release date")]
        [DataType(DataType.DateTime)]
        public string ReleaseDate { get; set; }


    }
}