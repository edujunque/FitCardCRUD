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
        public string estabNome { get; set; }
        [Required]
        public string estabNomeFantasia { get; set; }
        [Required]
        public string estabCNPJ { get; set; }
        public string estabEmail { get; set; }
        public string estabTelefone { get; set; }
        public bool estabStatus { get; set; }
        public Categoria categoria { get; set; }
        public int CategoriaId { get; set; }
        //Categoria[Supermercado, Restaurante, Borracharia, Posto, Oficina];
    }
}