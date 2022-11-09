using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Data;

namespace WebLinqExercises.Pages
{
    public class MovieModel : PageModel
    {
        public Movie Movie { get; set; }
        public void OnGet(int id)
        {
            Movie = Repository.GetAllMovies().First(m => m.Id == id);
        }
    }
}
