using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitCardCRUD.ViewModel
{
    public class EstabecimentoViewModel
    {
        public Models.Estabelecimento Estabelecimento { get; set; }
        public IEnumerable<Models.Categoria> Categorias { get; set; }
    }
}