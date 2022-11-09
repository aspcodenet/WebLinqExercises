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
            // SYFTE = Hämta data från tex databas, andra system, från fil
            // LÄGGA DATA I Properties

            //1. Löäs alla från movies.txt
            // 100 -tals rader

            Movies = Repository.GetAllMovies();
        }
    }
}
