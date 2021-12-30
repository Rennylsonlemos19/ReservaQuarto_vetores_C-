using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VECT_reservaQuartos.net
{
    internal class estudante
    {
        public string Nome { get; set; }
        public string Email{ get; set; }

        public estudante(string nome,string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return Nome
                + ", "
                + Email
                 + ".";
        }
    }
}
