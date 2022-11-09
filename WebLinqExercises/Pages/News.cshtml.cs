using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Services;

namespace WebLinqExercises.Pages
{
    public class NewsModel : PageModel
    {
        public List<KrisInfo> KrisInfoLista { get; set; } = new List<KrisInfo>();
        //Pubklic list 
        public void OnGet()
        {
            //var service = new KrisInfoService();
            //KrisInfoLista = service.GetAll();
            //
            // krisInfoService.GetAll()
        }

        public void OnPost(string query)
        {
            var service = new KrisInfoService();
            KrisInfoLista = service.GetAll().Where(k=>k.Title.ToLower().Contains(query.ToLower()) || k.Text.ToLower().Contains(query.ToLower())).ToList();
        }


    }
}
