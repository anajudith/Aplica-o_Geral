using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

class Menu
{
    private string CódPesq;

    private Operações MinhaOperação;
    private Dados MeusDados;

    public Menu(Operações O, Dados D)
    {
        MinhaOperação = O;
        MeusDados = D;
    }

    public void MostraMenu()
    {
        int Opção;
        do
        {
            Console.Clear();

            Console.WriteLine("Sistema de Cadastro de Alunos");
            Console.WriteLine("=============================\n");

            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Alterar");
            Console.WriteLine("3 - Excluir");
            Console.WriteLine("4 - Pesquisar");
            Console.WriteLine("5 - Listar");
            Console.WriteLine("6 - Ordenar");
            Console.WriteLine("7 - Salvar Dados em Arquivo XML");
            Console.WriteLine("8 - Ler Dados de Arquivos XML");
            Console.WriteLine("9 - Sair");

            Console.Write("\nOpção: ");
            Opção = int.Parse(Console.ReadLine());

            switch (Opção)
            {
                case 1:
                  do
                  {
                      Console.Clear();
                      Console.WriteLine("Cadastramento de Alunos");
                      Console.WriteLine("=====================\n");

                      MinhaOperação.Inserir(new Aluno(), MeusDados);
                      Console.WriteLine("\nInserir outro Registro? (ESC cancela...)");

                  } while (Console.ReadKey().Key != ConsoleKey.Escape);
                  
                    break;
                case 2:
                  //alterar
                    break;
                case 3:
                    Console.WriteLine("Exclusão do aluno do Cadastro");
                    Console.WriteLine("===========================\n");

                    Console.Write("Código do Aluno:  ");
                    CódPesq = Console.ReadLine();

                    MinhaOperação.Excluir(CódPesq, new Aluno(), MeusDados);

                    break;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Pesquisa no cadastro de Alunos");
                    Console.WriteLine("============================\n");

                    Console.Write("Código do Aluno:  ");
                    CódPesq = Console.ReadLine();

                    MinhaOperação.Pesquisar(CódPesq, new Aluno(), MeusDados);


                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Listagem geral do Cadastro de alunos");
                    Console.WriteLine("===================================\n");

                    MinhaOperação.Listar(MeusDados);
                    Console.ReadKey();
                    break;
                case 6:
                   //ordenar
                    break;
                case 7:
                  //Salvar Dados em Arquivo XML
                    break;
                case 8:
                    //Ler Dados de Arquivos XML
                    break;
                case 9:
                     Console.WriteLine("\nSaída do Sistema... ");
                     Thread.Sleep(2000);
                    break;
                default:
                    Console.Write("\nOpção Inválida!!!");
                    Thread.Sleep(2000);

                    break;

            }

        } while (Opção != 9);
    }
}