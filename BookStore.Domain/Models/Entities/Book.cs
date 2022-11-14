using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models.Entities
{
    public class Book
    {
        public string? Name { get; set; }
        public string? Title { get; set; }
        public decimal? Price { get; set; }
    }
}
