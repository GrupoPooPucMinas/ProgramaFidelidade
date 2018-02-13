using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProgramaFidelidade
{
    static class ProgramaFidelidade
    {
        static List<Cliente> Clientes = new List<Cliente>();
        static List<Cidade> Cidades = new List<Cidade>();
        static List<Voo> voos = new List<Voo>();

       static ProgramaFidelidade()
       {
            //Preenche as litas com o banco de dados 
            PreencheDados("pessoas.txt");
            PreencheDados("voos.txt");
            PreencheDados("reservas.txt");
            PreencheDados("cidades.txt");
            PreencheVoosCidades();
        }
    
        public static List<Cliente> clientes
        {
            get
            {
                return Clientes;
            }

            set
            {
                Clientes = value;
            }
        }

        public static List<Cidade> Cidades1
        {
            get
            {
                return Cidades;
            }

            set
            {
                Cidades = value;
            }
        }

        //Recebe o cpf do cliente para identificar sua posição da lista e poder analisar seus dados
        public static int PesquisarCliente(string CpfCliente)
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                if (Clientes[i].Cpf == CpfCliente)
                {
                    return i;
                }
            }
            //caso não exista tal cliente
            return -1;
        }
       
        //Método para exibir os dados do cliente
        public static string ExibirDadosCliente(int posicaoCliente)
        {
            string dados = "\r\nNome: " + Clientes[posicaoCliente].Nome + "\r\n CPF: " + Clientes[posicaoCliente].Cpf +
               "\r\n Categoria: " + Clientes[posicaoCliente].Categoria.ToString().Substring(19) + "\r\n Pontos: " + Clientes[posicaoCliente].PtosSaldo;
            return dados;
        }

        public static bool ComprarPassagem(string tipo, int posicaoCliente, string numVoo)
        {
            DateTime dt = DateTime.Now;

            switch(tipo)
            {
                case "Normal":
                    Voo.InsereReserva(dt, posicaoCliente, numVoo, 1);
                    return true;

                case "Promocional":
                    Voo.InsereReserva(dt, posicaoCliente, numVoo, 2);
                    return true;

                case "Fidelidade":
                    if (clientes[posicaoCliente].PtosSaldo >= 10000)
                    {
                        Voo.InsereReserva(dt, posicaoCliente, numVoo, 3);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                default:
                    return false;
                    
            }
        }
    public static Voo LocalizaIdVoo(string origem, string destino)
        {
            //Caso não encontre, retorna um Voo com variaveis vazias 
            Voo aux = new Voo("","","");
            try
            {
                for (int i = 0; i < voos.Count; i++)
                {
                    //Localiza o Voo de acordo com sua cidade de origem e destino
                    if (voos[i].CidadeOrigem == origem && voos[i].CidadeDestino == destino)
                    {
                        return voos[i];
                        //break;
                    }
                }
                return aux;
            }
            catch
            {
                return aux;
            }
        }  
        
        
        //Método para identificar os voos pedidos pelo cliente 
        public static String DeterminaVoos(string origem, string destino)
        {
            String conteudo = "";
            int aux = 0;

            while (aux < Cidades.Count)
            {
                //Se a cidade for a mesma que a pedida como origem
                if (Cidades[aux].NomeCidade == origem)
                {
                    //Percorre o vetor dessa cidade que guarda os voos apenas quando ela é origem 
                    for (int i = 0; i < Cidades[aux].VoosOrigens1.Count; i++)
                    {
                        //Identifica dentro desse vetor apenas de origem, qual possui o destino especifico
                        if (Cidades[aux].VoosOrigens1[i].CidadeDestino == destino)
                        {
                            //Armazena para poder imprimir todos os dados dos voos nos padrões 
                            conteudo += "Voo: " + Cidades[aux].VoosOrigens1[i].CidadeOrigem +
                                    " x " + Cidades[aux].VoosOrigens1[i].CidadeDestino + "\r\n Cidade de Origem: " + Cidades[aux].VoosOrigens1[i].CidadeOrigem +
                                    "\r\n Cidade de Destino: " + Cidades[aux].VoosOrigens1[i].CidadeDestino;
                        }
                    }
                    //Após encontrar a cidade certa, para o loop
                    break;
                }
                //Se não encontrou a cidade certa, adiciona mais um para conferir a próxima cidade 
                aux++;
            }
            return conteudo;
        }


        //Metodo que garante que cada cidade tenha uma lista apenas dos voos que a envolvem
        public static void PreencheVoosCidades()
        {
            int aux = 0;

            //Verifica cada cidade
            while (aux < Cidades.Count)
            {
                //Percorre cada voo
                for (int i = 0; i < voos.Count; i++)
                {
                    //Se a cidade for a cidade de origem 
                    if (Cidades[aux].NomeCidade == voos[i].CidadeOrigem)
                    {
                        //adiciona nessa cidade esse voo
                        Cidades[aux].VoosOrigens1.Add(voos[i]);  
                    }
                    //Se a cidade for a cidade de destino
                    else if (Cidades[aux].NomeCidade == voos[i].CidadeDestino)
                    {
                        //adiciona nessa cidade esse voo
                        Cidades[aux].VoosDestino1.Add(voos[i]);    
                    }
                }
                //Soma mais um pra poder verificar a próxima cidade 
                aux++;
            }
        }

        //Método que exibe todos os voos de um só cliente.
        public static string ExibeVoosdoCliente(string cpf)
        {
            string voosDoCliente = "";
            int aux = 0;
            while (aux < Clientes.Count)
            {
                if(cpf == Clientes[aux].Cpf)
                {
                    for (int j = 0; j < Clientes[aux].Voos.Count; j++)
                    {
                        voosDoCliente += Clientes[aux].Voos[j].IdentificaVoo +" "+  Clientes[aux].Voos[j].CidadeOrigem +
                                      " " + Clientes[aux].Voos[j].CidadeDestino + " " + Clientes[aux].Voos[j].DataAdesao.ToString("dd/MM/yyyy") + "\r\n";
                    }
                }
                aux++;
            }
           
            return voosDoCliente;
        }

        public static string ExibeVoosdoCliente(string cpf, int meses)
        {
            string voosDoCliente = "";
            int aux = 0;

            while(aux < Clientes.Count)
            {
                if(cpf == Clientes[aux].Cpf)
                {
                    List<Voo> voosComData = clientes[aux].CalculaPorPrazo(meses, clientes[aux].Voos);//Método calcula por prazo monta a lista de voos.

                    for (int j = 0; j < voosComData.Count; j++)
                    {
                        voosDoCliente += voosComData[j].IdentificaVoo + " " + voosComData[j].CidadeOrigem +
                                      " " + voosComData[j].CidadeDestino + " " + voosComData[j].DataAdesao.ToString("dd/MM/yyyy") + "\r\n";
                    }
                }
                aux++;
            }
            return voosDoCliente;
        }

        public static DateTime insereData(string datainserida)
        {
            //Converte para DateTime a data recebida no banco de dados
            DateTime dt = DateTime.Parse(datainserida);
            return dt;
        }

        //Método que recebe o nome do arquivo e faz a leitura devida 
        public static void PreencheDados(string nomeArquivo)
        {
            string txtAuxiliar;
            string[] campos;
            StreamReader arquivo = new StreamReader(nomeArquivo);

            while (!arquivo.EndOfStream)
            {
                try
                {
                    txtAuxiliar = arquivo.ReadLine();
                    campos = txtAuxiliar.Split(';');
                    //Se o arquivo for de pessoas
                    if (nomeArquivo == "pessoas.txt")
                    {
                        //Cria novos clientes e adiciona na lista de clientes do Programa 
                        Cliente cliente = new Cliente(campos[1], campos[0]);
                        Clientes.Add(cliente);
                    }
                    //Se o arquivo for de voos
                    else if (nomeArquivo == "voos.txt")
                    {
                        //Cria novos voos e adiciona na lista de voos disponíveis para compra do Programa
                        Voo viagem = new Voo(campos[0], campos[1], campos[2]);
                        voos.Add(viagem);
                    }
                    //Se o arquivo for o de reservas 
                    else if (nomeArquivo == "reservas.txt")
                    {
                        //Percorre a lista de clientes 
                        for (int i = 0; i < clientes.Count; i++)
                        {
                            //Se o cpf recebido for o mesmo do cliente 
                            if (campos[1] == clientes[i].Cpf)
                            {
                                //Percorre a lista de voos
                                for (int j = 0; j < voos.Count; j++)
                                {
                                    //Se o id do voo for o mesmo da lista de voos disponíveis 
                                    if(campos[0] == voos[j].IdentificaVoo)
                                    {
                                        //Verifica o tipo do voo 
                                        if (campos[3] == "1")
                                        {
                                            //Adiciona na lista de voos do cliente o voo já comprado 
                                            clientes[i].Voos.Add(new Normal(voos[j].IdentificaVoo, voos[j].CidadeOrigem, voos[j].CidadeDestino, insereData(campos[2])));
                                        }
                                        else if (campos[3] == "2")
                                        {
                                            clientes[i].Voos.Add(new Promocional(voos[j].IdentificaVoo, voos[j].CidadeOrigem, voos[j].CidadeDestino, insereData(campos[2])));  
                                        }

                                        else if (campos[3] == "3")
                                        {
                                            clientes[i].Voos.Add(new Fidelidade(voos[j].IdentificaVoo, voos[j].CidadeOrigem, voos[j].CidadeDestino, insereData(campos[2])));
                                        }
                                        //Se já entrou o cliente e todos os voos que ele comprou, interrompe o loop 
                                        break;
                                    }
                                }
                             }
                          }
                      }
                    //Se o arquivo for de cidade 
                    else
                    {
                        //Cria uma nova cidade e adiciona na lista de cidades no programa 
                        Cidade cidade = new Cidade(campos[0]);
                        Cidades.Add(cidade);
                    }
                }

                catch (FileNotFoundException e)
                {
                    throw;
                }
            }
           
            arquivo.Close();
        }
    }
}



