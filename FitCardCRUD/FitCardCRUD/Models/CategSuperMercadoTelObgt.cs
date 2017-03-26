using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FitCardCRUD.Models
{
    public class CategSuperMercadoTelObgt : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var estabelecimento = (Estabelecimento)validationContext.ObjectInstance;

            if (estabelecimento.CategoriaId != Categoria.Supermercado)
            {
                return ValidationResult.Success;
            }
            else if(estabelecimento.estabTelefone == "") { 
                return new ValidationResult("Telefone é obrigatório.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}
