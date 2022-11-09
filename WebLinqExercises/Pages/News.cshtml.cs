using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLinqExercises.Services;

namespace WebLinqExercises.Pages
{
    public class NewsModel : PageModel
    {
        public List<KrisInfo> KrisInfoLista { get; set; }
        //Pubklic list 
        public void OnGet()
        {
            var service = new KrisInfoService();
            KrisInfoLista = service.GetAll();
            //
            // krisInfoService.GetAll()
        }
    }
}
