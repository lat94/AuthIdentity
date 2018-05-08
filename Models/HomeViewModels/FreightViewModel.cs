using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace AuthIdentity.Models.HomeViewModels
{
    public class FreightViewModel
    {
        [Required]
        [Display(Name = "Pedido")]
        [DeserializeAs(Name = "order")]
        public int Order {get;set;}

        [DataType(DataType.Date)]
        [Display(Name = "Emissão")]
        [DeserializeAs(Name = "dtSent")]
        public DateTime DateSent { get; set; }


        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Valor")]
        [DeserializeAs(Name = "value")]
        public double Value { get; set; }


        [Required]
        [Display(Name = "Cód")]
        [DeserializeAs(Name = "freight")]
        public int Freight {get;set;}


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome")]
        [DeserializeAs(Name = "name")]
        public string Name { get; set; }


        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Entrega")]
        [DeserializeAs(Name = "address")]
        public string Address { get; set; }



        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "CEP")]
        [DeserializeAs(Name = "zipCode")]
        public string ZipCode { get; set; }



        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Cidade")]
        [DeserializeAs(Name = "city")]
        public string City { get; set; }


        

        
    }
}
