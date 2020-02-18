using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sistema_Vendas_Estudo.ViewComponents
{
    public class VcHeader : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();

        }

    }
}