using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramaFidelidade
{
    class Voo
    {
        String identificaVoo, cidadeOrigem, cidadeDestino;
        DateTime dataAdesao;
        int bonus;

        public int Bonus
        {
            get
            {
                return bonus;
            }

            set
            {
                bonus = value;
            }
        }

        public string IdentificaVoo
        {
            get
            {
                return identificaVoo;
            }

            set
            {
                identificaVoo = value;
            }
        }

        public string CidadeOrigem
        {
            get
            {
                return cidadeOrigem;
            }

            set
            {
                cidadeOrigem = value;
            }
        }

        public string CidadeDestino
        {
            get
            {
                return cidadeDestino;
            }

            set
            {
                cidadeDestino = value;
            }
        }

        public DateTime DataAdesao
        {
            get
            {
                return dataAdesao;
            }

            set
            {
                dataAdesao = value;
            }
        }


        //Caracteristicas recebidas para criar os voos com data ou sem data
        public Voo(string nome, string origem, string destino, DateTime dt)
        {
            this.identificaVoo = nome;
            this.cidadeDestino = destino;
            this.cidadeOrigem = origem;
            this.dataAdesao = dt;
        }

        public Voo(string nome, string origem, string destino)
        {
            this.identificaVoo = nome;
            this.cidadeDestino = destino;
            this.cidadeOrigem = origem;
        }

        //Adiona no txt a nova reserva feita 
        static public void InsereReserva(DateTime dt, int numCliente, string codVoo, int tipo)
        {
            StreamWriter arquivo = new StreamWriter("reservas.txt", true);

            string insert = codVoo + ";" + ProgramaFidelidade.clientes[numCliente].Cpf + ";" + dt.ToString("dd/MM/yyyy") + ";" + tipo;

            arquivo.WriteLine(insert);

            arquivo.Close();
        }
    }
}
