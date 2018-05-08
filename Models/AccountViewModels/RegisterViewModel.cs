using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthIdentity.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email inválido!")]
        public string Email { get; set; }

        [Display(Name = "Usuário")]
        [DataType(DataType.Text, ErrorMessage = "Usuário Inválido")]
        [StringLength(20, ErrorMessage = "O {0} deve ser pelo menos {2} e no máximo {1} de tamanho.", MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O {0} deve ser pelo menos {2} e no máximo {1} de tamanho.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirme a senha")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação de senha não são iguais.")]
        public string ConfirmPassword { get; set; }
    }
}
