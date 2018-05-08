using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace AuthIdentity.Models.HomeViewModels
{
    public class SalesViewModel
    {
        [Required]
        [Display(Name = "cod")]
        [DeserializeAs(Name = "id")]
        public int Id {get;set;}

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Usuário")]
        [DeserializeAs(Name = "userName")]
        public string Username { get; set; }

        
        [DataType(DataType.Date)]
        [Display(Name = "Entrega")]
        [DeserializeAs(Name = "dtArrival")]
        public DateTime DateArrival { get; set; }


        [Required]
        [Display(Name = "Empresa")]
        [DeserializeAs(Name = "idCompany")]
        public int IdCompany {get;set;}


        [Required]
        [Display(Name = "Situação")]
        [DeserializeAs(Name = "status")]
        public string Status {get;set;}


        [Required]
        [Display(Name = "Pedido")]
        [DeserializeAs(Name = "order")]
        public int Order {get;set;}

        
        [Display(Name = "Romaneio")]
        [DeserializeAs(Name = "freight")]
        public int Freight {get;set;}


        [Required]
        [Display(Name = "Cliente")]
        [DeserializeAs(Name = "client")]
        public string Client {get;set;}


        [Required]
        [Display(Name = "Pagamento")]
        [DeserializeAs(Name = "payment")]
        public string Payment {get;set;}




        
    }
}
