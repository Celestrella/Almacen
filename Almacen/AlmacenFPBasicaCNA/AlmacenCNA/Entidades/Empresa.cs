using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Empresa
    {

        public String NombreEmpresa { get; set; }
        public String Logo { get; set; }



        public Empresa(string nombreEmpresa, string logo)
        {
            NombreEmpresa = nombreEmpresa;
            Logo = logo;
           
        }

        public Empresa()
        {
        }

        public Empresa(string nombreEmpresa)
        {
            NombreEmpresa = nombreEmpresa;
        }

        public override bool Equals(object obj)
        {
            return obj is Empresa empresa &&
                   NombreEmpresa.ToUpper() == empresa.NombreEmpresa.ToUpper();
        }
    }
}
