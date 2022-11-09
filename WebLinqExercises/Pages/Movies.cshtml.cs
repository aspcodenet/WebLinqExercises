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
            // SYFTE = H�mta data fr�n tex databas, andra system, fr�n fil
            // L�GGA DATA I Properties

            //1. L��s alla fr�n movies.txt
            // 100 -tals rader

            Movies = Repository.GetAllMovies();
        }
    }
}
