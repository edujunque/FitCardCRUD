using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitCardCRUD.Models;

namespace FitCardCRUD.ViewModel
{
    public class EstabecimentoViewModel
    {
        public IEnumerable<Categoria> Categorias { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
    }
}