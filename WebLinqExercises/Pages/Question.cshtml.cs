using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Data;

namespace WebLinqExercises.Pages
{
    public class QuestionModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public QuestionModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(string id)
        {
            if (id == "1")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "2")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "3")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "4")
            {
                ViewData["data"] = Data.Repository.GetAllActors().ToHtmlTable();
            }
            else if (id == "5")
            {
                ViewData["data"] = Data.Repository.GetAllActors().ToHtmlTable();
            }
            else if (id == "6")
            {
                ViewData["data"] = Data.Repository.GetAllActors()/* .Select(...) */.ToHtmlTable();
            }
            else if (id == "7")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "8")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "9")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "10")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }
            else if (id == "11")
            {
                ViewData["data"] = Data.Repository.GetAllMovies().ToHtmlTable();
            }

        }
    }
}