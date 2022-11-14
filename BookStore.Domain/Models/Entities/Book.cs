﻿namespace BookStore.Domain.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
    }
}
