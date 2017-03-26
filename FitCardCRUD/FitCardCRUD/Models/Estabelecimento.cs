using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitCardCRUD.Models
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Razão social")]
        public string estabNome { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string estabNomeFantasia { get; set; }
        [Required]
        [Display(Name = "CNPJ")]
        public string estabCNPJ { get; set; }
        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        public string estabEmail { get; set; }

        [Display(Name = "Telefone")]
        [CategSuperMercadoTelObgt]
        public string estabTelefone { get; set; }

        [Display(Name = "Status")]
        public bool estabStatus { get; set; }
        public Categoria categoria { get; set; }
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        //Categoria[Supermercado, Restaurante, Borracharia, Posto, Oficina];
    }
}