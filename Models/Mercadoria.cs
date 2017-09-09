using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ValemobiWeb.Models
{
    public enum TipoNegocio
    {
        Compra,
        Venda
    }

    public class Mercadoria
    {
        public int ID { get; set; }

        [Required(ErrorMessage="Por favor, informe o tipo de mercadoria.")]
        [StringLength(50, MinimumLength = 3, 
        ErrorMessage="Tipo de mercadoria deve ter entre 3 a 100 caracteres.")]
        public string Tipo { get; set; }

        [Required(ErrorMessage="Por favor, informe o nome da mercadoria.")]
        [StringLength(100, MinimumLength = 3, 
        ErrorMessage="Nome da mercadoria deve ter entre 3 a 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage="Por favor, informe a quantidade de itens.")]
        [Range(1, Int32.MaxValue,
        ErrorMessage = "Quantidade deve ser maior ou igual a 1.")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage="Por favor, informe um preço de mercadoria.")]
        [DisplayFormat(ApplyFormatInEditMode = true, 
        DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required(ErrorMessage="Por favor, informe a categoria da mercadoria.")]
        [DisplayName("Categoria")]
        public TipoNegocio Negocio { get; set; }

        public Mercadoria() { }
        public Mercadoria(int id)
        {
            this.ID = id;
        }
    }
}