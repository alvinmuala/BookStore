using BookStore.Domain.Models.Entities;

namespace BookStore.Domain.Config
{
    public class DefaultConfig
    {
        public List<Book> Books { get; set; }

        public DefaultConfig()
        {
            Books = new List<Book>
            {
                new Book
                {
                    Id = 1,
                    Name = "Fraser Riley",
                    Title =  "Foe Of Despair",
                    Price = 24.99m
                },
                new Book
                {
                    Id = 2,
                    Name = "Dexter May",
                    Title =  "Rebels And Knights",
                    Price = 19.99m
                },
                new Book
                {
                    Id = 3,
                    Name = "Aston Stevens",
                    Title =  "Deceiving The Fires",
                    Price = 229.99m
                },
                new Book
                {
                    Id = 4,
                    Name = "Rio Bell",
                    Title =  "Priests Of Time",
                    Price = 59.99m
                },
                new Book
                {
                    Id = 5,
                    Name = "Maxwell Scott",
                    Title =  "Friends Of The Nation",
                    Price = 9.99m
                },
                new Book
                {
                    Id = 6,
                    Name = "Hanna Willis",
                    Title =  "Hunters And Owls",
                    Price = 24.99m
                },
                new Book
                {
                    Id = 7,
                    Name = "Eve Evans",
                    Title =  "Soldier Of The Eclipse",
                    Price = 199.99m
                },
                new Book
                {
                    Id = 8,
                    Name = "Sarah Dean",
                    Title =  "Changing My Dreams",
                    Price = 39.99m
                },
                new Book
                {
                    Id = 9,
                    Name = "Blossom Gray",
                    Title =  "Planet Of Yesterday",
                    Price = 69.99m
                }
            };
        }
    }
}