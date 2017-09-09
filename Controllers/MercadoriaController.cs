using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValemobiWeb.Data;
using ValemobiWeb.Models;

namespace ValemobiWeb.Controllers
{
    public class MercadoriaController : Controller
    {
        private readonly Context _context;

        public MercadoriaController(Context context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var mercadorias = this._context.Mercadorias.AsNoTracking().ToList();
            return View(new MercadoriaViewModel(mercadorias));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] Mercadoria mercadoria)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    this._context.Add(mercadoria);
                    await this._context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError(
                    "Mercadoria", 
                    "Não foi possível " + 
                    "cadastrar uma nova mercadoria. " + 
                    "Tente novamente mais tarde ou se o erro persistir, " + 
                    "contate o administrador."
                );
            }
            return View(mercadoria);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var mercadoria = await this._context.Mercadorias
                .AsNoTracking().FirstOrDefaultAsync(m => m.ID.Equals(id));
            
            if(mercadoria.Equals(null))
            {
                return NotFound();
            }
            else
            {
                return View(mercadoria);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var mercadoria = await this._context.Mercadorias
                .FirstOrDefaultAsync(m => m.ID.Equals(id));
            
            if(mercadoria.Equals(null))
            {
                return NotFound();
            }
            else
            {
                return View(mercadoria);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var mercadoria = await this._context.Mercadorias
                .FirstOrDefaultAsync(m => m.ID.Equals(id));
            
            if(mercadoria.Equals(null))
            {
                return NotFound();
            }
            else
            {
                this._context.Remove(mercadoria);
                await this._context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}