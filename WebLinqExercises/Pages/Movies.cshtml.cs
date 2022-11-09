using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Data;

namespace WebLinqExercises.Pages
{
    public class MoviesModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        public void OnGet()
        {
            Movies = Repository.GetAllMovies();
        }
    }
}
