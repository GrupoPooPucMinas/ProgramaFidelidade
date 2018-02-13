using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramaFidelidade
{
    class Cliente
    {
        String nome, cpf;
        Double ptosSaldo;
        ICategoria categoria;
        List<Voo> voos = new List<Voo>();
        
        //caracteristicas recebidas para criar cliente
        public Cliente(string nomeCliente, string Cpf)
        {
            this.nome = nomeCliente;
            this.cpf = Cpf;
            VerificaCategoria(this.voos);
        }

        public void VerificaCategoria(List<Voo> voo)
        {
            //Verifica os voos que encaixam no prazo de doze meses
            List<Voo> lista = CalculaPorPrazo(12, voo);

            //Calcula o total de pontos que o usuário ganhou nesse periodo
            double selCategoria = CalculaPontos(lista);

            //Verifica as condições para cada categoria
            if (selCategoria >= 15000)
            {
                this.categoria = new Manga();
            }
            else if (selCategoria >= 10000 && selCategoria < 15000)
            {
                this.categoria = new Abacate();
            }
            else
            {
                this.categoria = new Laranja();
            }
        }

        public List<Voo> CalculaPorPrazo(int meses, List<Voo> voo)
        {
            //Determina a data final como a atual no sistema
            DateTime datafinal = DateTime.Now;

            //Soma um valor negativo para encontrar a quantidade de meses anteriores determinado: 12 ou 24 meses
            DateTime datainicial = datafinal.AddMonths(meses*-1);

            List<Voo> aux = new List<Voo>();
             
            for (int i = 0; i < voo.Count; i++)
            {
                //Se a data registrada do voo for maior que a data calculada no tempo determinado
                if (voo[i].DataAdesao >= datainicial) 
                {
                    //Adiciona o voo que encaixa no padrão
                    aux.Add(voo[i]);
                }
            }

            return aux;
        }

        public List<Voo> VerificaVoosFuturos()
        {
            //Determina a data atual do sistema como a primeira data que deve ser analisada
            DateTime dataInicial = DateTime.Now;
            List<Voo> aux = new List<Voo>();
            for (int i = 0; i < voos.Count; i++)
            {
                //Se a data do sistema for menor que a data salva no voo
                if (dataInicial <= this.voos[i].DataAdesao)
                {
                    //Adiciona o voo dentro do padrão
                    aux.Add(voos[i]);
                }
            }

            return aux;
        }

        public double CalculaPontos(List<Voo> voo)
        {
            double aux = 0;
            //Soma os pontos de acordo com o tipo de Voo que entra, de acordo com cada bonus
            for (int i = 0; i < voo.Count; i++)
            {
                // método aplicado em cada interface com os respectivos cálculos.
                aux += categoria.CalcBonus(voo[i].Bonus,voo[i].Bonus);
            }

            return aux;
        }

        public static void CadastraClienteArquivo(string cpf, string nome)
        {
            StreamWriter arquivo = new StreamWriter("pessoas.txt", true);

            string insert = cpf + ";" + nome;

            arquivo.WriteLine(insert);

            arquivo.Close();
        }

        public double PtosSaldo
        {
            get
            {
                return ptosSaldo;
            }

            set
            {
                ptosSaldo = value;
            }
        }

        public ICategoria Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public List<Voo> Voos
        {
            get
            {
                return voos;
            }

            set
            {
                voos = value;
            }
        }

    }
}
