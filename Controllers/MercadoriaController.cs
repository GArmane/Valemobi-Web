using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValemobiWeb.Data;
using ValemobiWeb.Data.Access;
using ValemobiWeb.Models;

namespace ValemobiWeb.Controllers
{
    public class MercadoriaController : Controller
    {
        private readonly MercadoriaDAO _dao;

        public MercadoriaController(Context context)
        {
            this._dao = new MercadoriaDAO(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var mercadorias = this._dao.GetList();
            return View(new MercadoriaViewModel(mercadorias));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return NotFound();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return NotFound();
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return NotFound();
        }
    }
}