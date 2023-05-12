namespace ExamProject.Migrations
{
    using MvcMovie.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = 7,
                    Description = "Harry and Sally have known each other for years, and are very good friends, but they fear sex would ruin the friendship.",
                    Picture = "http://s3.amazonaws.com/mgm-assets/assets/Title/1264715234/2140/ItunesFull-WHENHARR-itunes-002.jpg",
                    Video = "https://www.youtube.com/watch?v=V8DgDmUHVto"
                },

                 new Movie
                 {
                     Title = "Ghostbusters",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = 6,
                     Description = "30 years after Ghostbusters took the world by storm, the beloved franchise makes its long-awaited return. Director Paul Feig brings his fresh take to the supernatural comedy, joined by some of the funniest actors working today.",
                     Picture = "http://cafmp.com/wp-content/uploads/2015/11/Ghostbusters-1984.jpg",
                     Video = "https://www.youtube.com/watch?v=w3ugHP-yZXw"
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = 7,
                     Description = "The discovery of a massive river of ectoplasm and a resurgence of spectral activity allows the staff of Ghostbusters to revive the business.",
                     Picture = "http://vignette2.wikia.nocookie.net/filmguide/images/0/01/Ghostbusters_ii_poster.jpg/revision/latest?cb=20130420021127",
                     Video = "https://www.youtube.com/watch?v=t6hlkIlGFCI"
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = 5,
                   Description = "A small-town sheriff in the American West enlists the help of a cripple, a drunk, and a young gunfighter in his efforts to hold in jail the brother of the local bad guy.",
                   Picture = "http://www.impawards.com/1959/posters/rio_bravo_xlg.jpg",
                   Video = "https://www.youtube.com/watch?v=WPO12ZzGS84"
               }
           );

        }
    }
}
