using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace AuthIdentity.Models.HomeViewModels
{
    public class ClientViewModel
    {
        [Required]
        [Display(Name = "Cód")]
        [DeserializeAs(Name = "id")]
        public int Id {get;set;}

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Tipo")]
        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Região Venda")]
        [DeserializeAs(Name = "salesRegion")]
        public string SalesRegion { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Cidade")]
        [DeserializeAs(Name = "city")]
        public string City { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Limite")]
        [DeserializeAs(Name = "limit")]
        public double Limit { get; set; }
    }
}
