using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValemobiWeb.Models;

namespace ValemobiWeb.Data.Access
{
    public class MercadoriaDAO
    {
        private readonly Context _context;

        public MercadoriaDAO(Context context)
        {
            this._context = context;
        }

        public List<Mercadoria> GetList()
        {
            return this._context.Mercadorias.ToList();
        }

        public Mercadoria GetByID(int id)
        {
            return this._context.Mercadorias.FirstOrDefault(
                m => m.ID.Equals(id)
            );
        }

        public async void Create(Mercadoria mercadoria)
        {
            this._context.Add(mercadoria);
            await this._context.SaveChangesAsync();
        }

        public async void Edit(Mercadoria mercadoria)
        {
            this._context.Update(mercadoria);
            await this._context.SaveChangesAsync();
        }

        public async void Remove(Mercadoria mercadoria)
        {
            this._context.Remove(mercadoria);
            await this._context.SaveChangesAsync();
        }
    }
}