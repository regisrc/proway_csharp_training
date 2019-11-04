using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace imobiliariaWebApi.Models
{
    public class CustomValidator : ValidationAttribute
    {

        public string FildName { get; set; }

        public CustomValidator(string fild)
        {
            FildName = fild;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (FildName == "Nome")
            {
                ImobiliariaContext db = new ImobiliariaContext();

                if (db.Proprietarios.FirstOrDefault(i => i.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já cadastrado");
            }
            else
            if (FildName == "DataNascimento")
            {
                ImobiliariaContext db = new ImobiliariaContext();

                if (DateTime.Now.AddYears(-18) > Convert.ToDateTime(value) && Convert.ToDateTime(value) < DateTime.Now.AddYears(-150))
                    return new ValidationResult("Idade tem que ser maior que 18 e menor que 150");
            }

            return ValidationResult.Success;
        }
    }
}