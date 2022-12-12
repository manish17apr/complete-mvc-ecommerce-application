using eTicketN.Data.Enums;
using eTicketN.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketN.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                         Name="Cinema 1",
                         Logo="http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                         Description="This is the description of first cinema"
                        },
                        new Cinema()
                        {
                         Name="Cinema 2",
                         Logo="http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                         Description="This is the description of Second cinema"
                        },
                        new Cinema()
                        {
                         Name="Cinema 3",
                         Logo="http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                         Description="This is the description of third cinema"
                        },
                         new Cinema()
                        {
                         Name="Cinema 4",
                         Logo="http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                         Description="This is the description of third cinema"
                        },
                          new Cinema()
                        {
                         Name="Cinema 5",
                         Logo="http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                         Description="This is the description of third cinema"
                        }
                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                         FullName="Actor 1",
                         Bio="This is the Bio of the first actor",
                         ProfilepictureURL="http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                         FullName="Actor 2",
                         Bio="This is the Bio of the Second actor",
                         ProfilepictureURL="http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                         new Actor()
                        {
                         FullName="Actor 3",
                         Bio="This is the Bio of the third actor",
                         ProfilepictureURL="http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                         FullName="Actor 4",
                         Bio="This is the Bio of the fourth actor",
                         ProfilepictureURL="http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                         FullName="Actor 5",
                         Bio="This is the Bio of the fifth actor",
                         ProfilepictureURL="http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                         FullName="Producer 1",
                         Bio="This is the Bio of the first Producer",
                         ProfilepictureURL="http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                         FullName="Producer 2",
                         Bio="This is the Bio of the Second Producer",
                         ProfilepictureURL="http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                         new Producer()
                        {
                         FullName="Producer 3",
                         Bio="This is the Bio of the third Producer",
                         ProfilepictureURL="http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                         FullName="Producer 4",
                         Bio="This is the Bio of the fourth Producer",
                         ProfilepictureURL="http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                         FullName="Producer 5",
                         Bio="This is the Bio of the fifth Producer",
                         ProfilepictureURL="http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                         Name="Scoob",
                         Description="This is the Scoob movie description",
                         Price=39.50,
                         ImageURL="http://dotnethow.net/images/movies/movie-1.jpeg",
                         StartDate=DateTime.Now.AddDays(-10),
                         EndDate=DateTime.Now.AddDays(-2),
                         CinemaId=1,
                         ProducerId=3,
                         MovieCategory=MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                         Name="The Shawshank redemption",
                         Description="This is the Shawshank redemptio movie description",
                         Price=25,
                         ImageURL="http://dotnethow.net/images/movies/movie-2.jpeg",
                         StartDate=DateTime.Now,
                         EndDate=DateTime.Now.AddDays(7),
                         CinemaId=4,
                         ProducerId=4,
                         MovieCategory=MovieCategory.Action
                        },
                        new Movie()
                        {
                         Name="Action King",
                         Description="This is the Action King movie description",
                         Price=75,
                         ImageURL="http://dotnethow.net/images/movies/movie-3.jpeg",
                         StartDate=DateTime.Now,
                         EndDate=DateTime.Now.AddDays(5),
                         CinemaId=5,
                         ProducerId=5,
                         MovieCategory=MovieCategory.Action
                        },
                        new Movie()
                        {
                         Name="Action Queen",
                         Description="This is the Action Queen movie description",
                         Price=98,
                         ImageURL="http://dotnethow.net/images/movies/movie-4.jpeg",
                         StartDate=DateTime.Now,
                         EndDate=DateTime.Now.AddDays(15),
                         CinemaId=1,
                         ProducerId=5,
                         MovieCategory=MovieCategory.Drama
                        },
                         new Movie()
                        {
                         Name="Sing a song",
                         Description="This is the Sing a song movie description",
                         Price=98,
                         ImageURL="http://dotnethow.net/images/movies/movie-5.jpeg",
                         StartDate=DateTime.Now.AddDays(5),
                         EndDate=DateTime.Now.AddDays(15),
                         CinemaId=1,
                         ProducerId=5,
                         MovieCategory=MovieCategory.Documentry
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movie.Any())
                {
                    context.Actors_Movie.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                         MovieId=1,
                         ActorId=1
                        },
                        new Actor_Movie()
                        {
                         MovieId=1,
                         ActorId=2
                        },
                        new Actor_Movie()
                        {
                         MovieId=1,
                         ActorId=3
                        },
                        new Actor_Movie()
                        {
                         MovieId=2,
                         ActorId=1
                        },
                        new Actor_Movie()
                        {
                         MovieId=2,
                         ActorId=5
                        },
                        new Actor_Movie()
                        {
                         MovieId=3,
                         ActorId=3
                        },
                        new Actor_Movie()
                        {
                         MovieId=3,
                         ActorId=5
                        },
                        new Actor_Movie()
                        {
                         MovieId=3,
                         ActorId=4
                        },
                        new Actor_Movie()
                        {
                         MovieId=4,
                         ActorId=4
                        },
                        new Actor_Movie()
                        {
                         MovieId=4,
                         ActorId=5
                        },
                        new Actor_Movie()
                        {
                         MovieId=5,
                         ActorId=1
                        },
                        new Actor_Movie()
                        {
                         MovieId=5,
                         ActorId=2
                        },
                        new Actor_Movie()
                        {
                         MovieId=5,
                         ActorId=3
                        },
                        new Actor_Movie()
                        {
                         MovieId=5,
                         ActorId=4
                        },
                        new Actor_Movie()
                        {
                         MovieId=5,
                         ActorId=5
                      }

                    });
                    context.SaveChanges();

                }

            }

        }
    }
}
