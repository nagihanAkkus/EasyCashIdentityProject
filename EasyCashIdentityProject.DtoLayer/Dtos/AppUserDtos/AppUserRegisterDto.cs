using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="İsim alanı zorunludur")]
        //[Display(Name ="İsim : ")]
        //[MaxLength(100,ErrorMessage ="En fazla 100 karakter girebilirsiniz.")]
       
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ConfirmPassword { get; set; }


    }
}
// name, surname, username, mail, password,confirmpassword