using System.Collections.Generic;
using System.Web.Mvc;
namespace ExamProject.Models
{
    public static class MoviesGenre
    {
        public static List<SelectListItem> get()
        {
            return new List<SelectListItem>() {

                new SelectListItem {
                    Text = "Action",
                    Value = "Action"
                },
                new SelectListItem {
                    Text = "Animation",
                    Value = "Animation"
                },
                new SelectListItem {
                    Text = "Biography",
                    Value = "Biography"
                },
                new SelectListItem {
                    Text = "Comedy",
                    Value = "Comedy"
                },
                new SelectListItem {
                    Text = "Crime",
                    Value = "Crime"
                },
                new SelectListItem {
                    Text = "Drama",
                    Value = "Drama"
                },
                new SelectListItem {
                    Text = "Family",
                    Value = "Family"
                },
                new SelectListItem {
                    Text = "Fantasy",
                    Value = "Fantasy"
                },
                new SelectListItem {
                    Text = "History",
                    Value = "History"
                },
                new SelectListItem {
                    Text = "Music",
                    Value = "Music"
                },
                new SelectListItem {
                    Text = "Mystery",
                    Value = "Mystery"
                },
                new SelectListItem {
                    Text = "Sci-fi",
                    Value = "Scifi"
                },
                new SelectListItem {
                    Text = "Thriller",
                    Value = "Thriller"
                },
                 new SelectListItem {
                    Text = "War",
                    Value = "War"
                },
        };
        }
    }
}