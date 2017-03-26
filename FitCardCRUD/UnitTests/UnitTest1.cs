using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FitCardCRUD.Controllers;
using FitCardCRUD.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EstabelecimentoesController controller = new EstabelecimentoesController();
            Estabelecimento model = new Estabelecimento();
            model.estabCNPJ = "123";
            model.estabNome = "123";
            
            //ViewResult result = controller.Create(model) as ViewResult;

            Assert.IsTrue(ValidateModel(model).Count < 0);
        }

        private IList<ValidationResult> ValidateModel(object model)
        {
            var validationResults = new List<ValidationResult>();
            var ctx = new ValidationContext(model, null, null);
            Validator.TryValidateObject(model, ctx, validationResults, true);
            return validationResults;
        }
    }
}
