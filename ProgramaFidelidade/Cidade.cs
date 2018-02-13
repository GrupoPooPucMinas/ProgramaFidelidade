using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramaFidelidade
{
    class Cidade
    {
        String nomeCidade;
        List<Voo> VoosDestino = new List<Voo>();
        List<Voo> VoosOrigens = new List<Voo>();

        public Cidade(String nome)
        {
            this.nomeCidade = nome;
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }

            set
            {
                nomeCidade = value;
            }
        }

        internal List<Voo> VoosDestino1
        {
            get
            {
                return VoosDestino;
            }

            set
            {
                VoosDestino = value;
            }
        }

        internal List<Voo> VoosOrigens1
        {
            get
            {
                return VoosOrigens;
            }

            set
            {
                VoosOrigens = value;
            }
        }
    }
}
