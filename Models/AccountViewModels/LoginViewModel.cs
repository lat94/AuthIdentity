using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentity.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido!")]
        public string Email { get; set; }


        [Display(Name = "Usuário")]
        [DataType(DataType.Text, ErrorMessage = "Usuário Inválido")]
        [StringLength(20, ErrorMessage = "O {0} deve ser pelo menos {2} e no máximo {1} de tamanho.", MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembrar-me?")]
        public bool RememberMe { get; set; }
    }
}
