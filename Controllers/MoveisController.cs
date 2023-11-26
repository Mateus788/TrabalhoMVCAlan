using ListaMVCMoveisAlan.Models.ModelsView;
using Microsoft.AspNetCore.Mvc;

namespace ListaMVCMoveisAlan.Controllers
{
    public class MoveisController : Controller
    {
        public IActionResult ListaMoveis()
        {
            List<ItemModelView> itemModelViews = new List<ItemModelView>();
            itemModelViews.Add(new ItemModelView("Porta", true));
            itemModelViews.Add(new ItemModelView("Janela", true));
            itemModelViews.Add(new ItemModelView("Cadeira", false));
            itemModelViews.Add(new ItemModelView("Cama", false));
            itemModelViews.Add(new ItemModelView("Sofá", true));
            itemModelViews.Add(new ItemModelView("Mesa", false));
            itemModelViews.Add(new ItemModelView("Poltrona", true));
            itemModelViews.Add(new ItemModelView("Fogão", true));
            itemModelViews.Add(new ItemModelView("Microondas", true));
            itemModelViews.Add(new ItemModelView("Geladeira", false));
            itemModelViews.Add(new ItemModelView("Ventilador", true));
            itemModelViews.Add(new ItemModelView("Chaleira", false));
            return View(itemModelViews);
        }
    }
}
