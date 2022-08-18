using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTela_login
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuario =new List<DadosUsuario>
        {
           new dadosUsuario()
           {
               Email = "aluno@etec" ,
               Nome = "Aluno" ,
               Senha = "123"

           },
           new dadosUsuario()
           {
             Email ="prof@etec" ,
             Nome = "Professor" ,
             Senha = "456"
           }
        }
    }
}
