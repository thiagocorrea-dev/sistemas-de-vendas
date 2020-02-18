using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Vendas_Estudo.ViewComponents
{
    public class VcMenu : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();

        }

    }
}