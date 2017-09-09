using System.Collections.Generic;

namespace ValemobiWeb.Models
{
    public class MercadoriaViewModel
    {
        public List<Mercadoria> Itens {get; private set;}
        
        public MercadoriaViewModel(List<Mercadoria> itens)
        {
            this.Itens = itens;
        }
    }
}