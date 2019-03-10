using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRepo
{
    class Dependentes
    {
        private string nome;
        private int cod;
        private long cpf;
        private string data_nasc;

        public string Nome { get => nome; set => nome = value; }
        public int Cod { get => cod; set => cod = value; }
        public long Cpf { get => cpf; set => cpf = value; }
        public string Data_nasc { get => data_nasc; set => data_nasc = value; }
    }
}
