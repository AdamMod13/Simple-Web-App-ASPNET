﻿using System.ComponentModel.DataAnnotations;

namespace Simple_Web_App
{
    public class Game
    {
        public int ID { get; set; }
        
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RelaseDate { get; set; }
        
        public string Genre { get; set; }
        
        public string Platforms { get; set; }
        
        public decimal Price { get; set; }
    }
}
