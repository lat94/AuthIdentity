using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace AuthIdentity.Models.HomeViewModels
{
    public class CurvaABCViewModel
    {
        [Required]
        [Display(Name = "Cód")]
        [DeserializeAs(Name = "id")]
        public int Id {get;set;}

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        [DeserializeAs(Name = "employee_name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Salário")]
        [DeserializeAs(Name = "employee_salary")]
        public double Salary { get; set; }

        
    }
}
