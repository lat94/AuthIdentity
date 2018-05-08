using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentity.Models.ManageViewModels
{
    public class IndexViewModel
    {
        [Display(Name = "Usuário")]
        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Telefone")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}
