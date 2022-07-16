using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinemas
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1 (Bahman)",
                            Logo = "https://www.google.com/maps/uv?pb=!1s0x3f8e011cec80db7d%3A0xe9a7289a03ca6464!3m1!7e115!4shttps%3A%2F%2Flh5.googleusercontent.com%2Fp%2FAF1QipMs0Sjq2nz1k-K-MjoghzYYggyTvsmP1Dl_asUY%3Dw162-h108-n-k-no!5z2YTbjNiz2Kog2LPbjNmG2YXYp9mH2KcgLSBHb29nbGUgU2VhcmNo!15sCgIgAQ&imagekey=!1e10!2sAF1QipMs0Sjq2nz1k-K-MjoghzYYggyTvsmP1Dl_asUY&hl=en&sa=X&ved=2ahUKEwjUgP_92fv4AhXQXfEDHUxCC1AQ7ZgBKAJ6BAgQEAQ",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2 (Markazi)",
                            Logo = "https://www.google.com/maps/uv?pb=!1s0x3f8e011d6c3bc90b%3A0x92efe659174dbd4a!3m1!7e115!4shttps%3A%2F%2Flh5.googleusercontent.com%2Fp%2FAF1QipMpzGfaVH_7sS2IMIgNr-jWvHNTYarQyQQHWUux%3Dw325-h218-n-k-no!5z2YTbjNiz2Kog2LPbjNmG2YXYp9mH2KcgLSBHb29nbGUgU2VhcmNo!15sCgIgAQ&imagekey=!1e10!2sAF1QipN8bXKvAB6eXFpUrw3V6IYYjXj-5XpImldUBOoY&hl=en&sa=X&ved=2ahUKEwj2xLWu2vv4AhUJQ_EDHbeVB_wQ7ZgBKAB6BAgQEAI",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3 (Azadi)",
                            Logo = "https://www.google.com/maps/uv?pb=!1s0x3f8e015848d4c3cb%3A0x6155de3bd536156f!3m1!7e115!4shttps%3A%2F%2Flh5.googleusercontent.com%2Fp%2FAF1QipPoq9o-g3jHg8urAnajF8J-vrD-CPSbSct0l0A2%3Dw325-h218-n-k-no!5z2YTbjNiz2Kog2LPbjNmG2YXYp9mH2KcgLSBHb29nbGUgU2VhcmNo!15sCgIgAQ&imagekey=!1e10!2sAF1QipNq0GrR5mv7sXs7R_v-V8WTZ0IjvWCAE3WqYAv_&hl=en&sa=X&ved=2ahUKEwiO3ZvY2vv4AhWaVfEDHQuVBzkQ7ZgBKAB6BAgSEAI",
                            Description = "This is the description of the third cinema"
                        }
                    }
                    );
                    context.SaveChanges();
                }

                //Actoors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1 (Parsa PirouzFar)",
                            ProfilePictureURL = "https://files.namnak.com/users/sf/aup/202206/129_pics/%D9%BE%D8%A7%D8%B1%D8%B3%D8%A7-%D9%BE%DB%8C%D8%B1%D9%88%D8%B2%D9%81%D8%B1.jpg",
                            Bio = "This is the Bio of the first actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2 (Hamed Ahangi)",
                            ProfilePictureURL = "https://static3.rasadeghtesadi.com/servev2/PLgRCZLfrP3F/m1MI1kFsYl0,/%D8%AD%D8%A7%D9%85%D8%AF+%D8%A2%D9%87%D9%86%DA%AF%DB%8C.jpg",
                            Bio = "This is the Bio of the second actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3 (Kambiz Dirbaz)",
                            ProfilePictureURL = "https://static3.borna.news/thumbnail/md5IiJpdMWHO/zKlnR2CgDMsLPypExSqkWVexFSgSRltNvp3exfX06vug6WJOtspsxLwVvO9faXc9wvplisndFdUHpxCkrVbVYcwyrR1qqAVx/1677109.jpg",
                            Bio = "This is the Bio of the third actor"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4 (Parviz Parastooie)",
                            ProfilePictureURL = "https://fararu.com/files/fa/news/1400/10/16/1112363_684.jpg",
                            Bio = "This is the Bio of the forth actor"
                        }
                    }
                    );
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1 (Saeed AbouTaleb)",
                            ProfilePictureURL = "https://media.mehrnews.com/d/2018/05/07/3/2777401.jpg",
                            Bio = "This is the Bio of the first producer"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2 (Ebrahim HatamiKia)",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/f/f9/Exodus_movie_press_conference_2020-02-07_37.jpg",
                            Bio = "This is the Bio of the second producer"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3 (Maziar Hashemi)",
                            ProfilePictureURL = "https://api.salamcinama.ir/uploads/user/image/271567/large_892790ad-771f-4fc9-b15a-45005fe1fdc6.jpg",
                            Bio = "This is the Bio of the third producer"
                        }
                    }
                    );
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Yaghi",
                            Description = "This is the description of the first movie (Yaghi)",
                            Price = 20.5,
                            ImageURL = "https://media.hamshahrionline.ir/d/2022/07/13/4/4700785.jpg?ts=1657708534000",
                            StartDate = DateTime.Now.AddDays(-20),
                            EndDate = DateTime.Now.AddDays(-2),
                            MovieCategory = MovieCategory.Drama,
                            CinemaId = 1,
                            ProducerId = 3
                        },
                        new Movie()
                        {
                            Name = "Mafia",
                            Description = "This is the description of the second movie (Mafia)",
                            Price = 17.75,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/fa/a/a3/%D8%B4%D8%A8%E2%80%8C%D9%87%D8%A7%DB%8C_%D9%85%D8%A7%D9%81%DB%8C%D8%A7.png",
                            StartDate = DateTime.Now.AddDays(-17),
                            EndDate = DateTime.Now.AddDays(-5),
                            MovieCategory = MovieCategory.Comedy,
                            CinemaId = 2,
                            ProducerId = 1
                        },
                        new Movie()
                        {
                            Name = "Bodyguard",
                            Description = "This is the description of the third movie (Bodyguard)",
                            Price = 12.0,
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/4/49/Bodyguard_%282016_film%29.jpg",
                            StartDate = DateTime.Now.AddDays(-400),
                            EndDate = DateTime.Now.AddDays(-370),
                            MovieCategory = MovieCategory.Action,
                            CinemaId = 3,
                            ProducerId = 2
                        },
                    }
                    );
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 2
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2
                        }
                    }
                    );
                    context.SaveChanges();
                }

            }
        }
    }
}
