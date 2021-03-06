﻿using BerrasBio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BerrasBio.Data
{
    public class DbInitializer
    {
        public static void Initializer(BerraContext context)
        {
            context.Database.EnsureCreated();

            if (context.Movies.Any())
            {
                return;
            }


            var movies = new[] //Movie Array
            {
                new Movie{Title = "Deadpool 2"},
                new Movie{Title = "Infinity War"},
                new Movie{Title = "Black Panther"},
                new Movie{Title = "SkyScraper"}
            };

            foreach (Movie movie in movies)
            {
                context.Movies.Add(movie);
            }

            context.SaveChanges();

            var salons = new[] // Salons Array
            {
                new Salon{Name = "Uno", MaxSeats = 50}
            };

            foreach (Salon salon in salons)
            {
                context.Salons.Add(salon);
            }

            context.SaveChanges();

            var Shows = new[] // Shows Array
            {
                new Showing{MovieID = 1, SalonID = 1, Date = DateTime.Parse("2018-07-01 18:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 2, SalonID = 1, Date = DateTime.Parse("2018-07-01 21:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 3, SalonID = 1, Date = DateTime.Parse("2018-07-02 18:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 4, SalonID = 1, Date = DateTime.Parse("2018-07-02 21:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 1, SalonID = 1, Date = DateTime.Parse("2018-07-03 18:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 2, SalonID = 1, Date = DateTime.Parse("2018-07-03 21:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 3, SalonID = 1, Date = DateTime.Parse("2018-07-04 18:15:00", CultureInfo.InvariantCulture)},
                new Showing{MovieID = 4, SalonID = 1, Date = DateTime.Parse("2018-07-04 21:15:00", CultureInfo.InvariantCulture)}
            };

            foreach (var Show in Shows)
            {
                context.Showings.Add(Show);
            }
            context.SaveChanges();

            var bookings = new[] // AmountOfTickets Array
            {
                new Booking{ShowingID = 1, NumOfSeats = 0},
                new Booking{ShowingID = 2, NumOfSeats = 0},
                new Booking{ShowingID = 3, NumOfSeats = 0},
                new Booking{ShowingID = 4, NumOfSeats = 0},
                new Booking{ShowingID = 5, NumOfSeats = 0},
                new Booking{ShowingID = 6, NumOfSeats = 0},
                new Booking{ShowingID = 7, NumOfSeats = 0},
                new Booking{ShowingID = 8, NumOfSeats = 0}
            };
            foreach (var Ticket in bookings)
            {
                context.Bookings.Add(Ticket);
            }
            context.SaveChanges();
        }
    }
}
