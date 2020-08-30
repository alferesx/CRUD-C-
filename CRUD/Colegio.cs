using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD
{
    class Colegio
    {
        static List<string> alunos = new List<string>();
        public static void AdicionarAluno()
        {
          
            Aluno aluno = new Aluno();
            Console.Write("NOME:");
            aluno.nome = Console.ReadLine();
            Colegio.alunos.Add(aluno.nome);
            Console.WriteLine(" ");

            Console.Write("IDADE:");
            aluno.idade = int.Parse(Console.ReadLine());
            Colegio.alunos.Add(Convert.ToString(aluno.idade));

            Console.WriteLine(" ");

            Console.Write("SERIE:");
            aluno.serie = int.Parse(Console.ReadLine());
            Colegio.alunos.Add(Convert.ToString(aluno.serie));
            Console.WriteLine(" ");

            Console.WriteLine("ALUNO CADASTRADO COM SUCESSO");
        }

        public static void ListarAluno()
        {
            foreach (var item in Colegio.alunos)
            {
                Console.WriteLine(item);
            }

        }


        public static void AtualizarAluno()
        {
            Aluno aluno = new Aluno();
            int opcaoAtualizacao;
           
            Console.Write("O que voce deseja atualizar ?: ");
            Console.WriteLine("");
            Console.WriteLine("1 - NOME");
            Console.WriteLine("2 - IDADE");
            Console.WriteLine("3 - SERIE");
            opcaoAtualizacao = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (opcaoAtualizacao)
            {
                case 1:
                    Console.Write("Digite o nome que você deseja mudar:");
                    string nomeLista = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        if (Colegio.alunos[i].Contains(nomeLista))
                        {
                            Console.Write("Digite o novo nome: ");
                            string novoNome = Console.ReadLine();
                            Console.WriteLine(" ");
                            Colegio.alunos[i] = novoNome;
                        }
                    }
                    break;
                case 2:
                    Console.Write("Digite a idade que você deseja mudar:");
                    string idadeLista = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        if (Colegio.alunos[i].Contains(idadeLista))
                        {
                            Console.Write("Digite a nova  idade: ");
                            string novoIdade = Console.ReadLine();
                            Console.WriteLine(" ");
                            Colegio.alunos[i] = novoIdade;
                        }
                    }
                    break;
                case 3:
                    Console.Write("Digite a serie que você deseja mudar:");
                    string serieLista = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        if (Colegio.alunos[i].Contains(serieLista))
                        {
                            Console.Write("Digite a nova serie: ");
                            string novoSerie = Console.ReadLine();
                            Console.WriteLine(" ");
                            Colegio.alunos[i] = novoSerie;
                        }
                    }
                    break;

                default:
                    break;

            }
        }

        public static void deletarAluno()
        {
            int opcaoDeletar;
            Aluno aluno = new Aluno();
            Console.Write("O que você deseja excluir ?: ");
            Console.WriteLine("1 - NOME");
            Console.WriteLine("2 - IDADE");
            Console.WriteLine("3 - SERIE");
            Console.Write("OPÇÃO: ");
            Console.WriteLine(" ");
            opcaoDeletar = int.Parse(Console.ReadLine());
            switch (opcaoDeletar)
            {
                case 1:
                    Console.Write("Digite o nome que você deseja deletar:");
                    string nomeListaDeletar = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        if (Colegio.alunos[i].Contains(nomeListaDeletar))
                        {
                            Colegio.alunos.RemoveAt(i);
                            Console.WriteLine("NOME REMOVIDO COM SUCESSO");
                        }
                    }
                    break;
                case 2:
                    Console.Write("Digite a idade que você deseja deletar:");
                    string idadeListaDeletar = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        List<string> Colegioalunos = Colegio.alunos;
                        if (Colegioalunos[i].Contains(idadeListaDeletar))
                        {
                            Colegio.alunos.RemoveAt(i);
                            Console.WriteLine("IDADE REMOVIDO COM SUCESSO");
                        }
                    }
                    break;
                case 3:
                    Console.Write("Digite o nome que você deletar:");
                    string serieListaDeletar = Console.ReadLine();
                    for (int i = 0; i < Colegio.alunos.Count; i++)
                    {
                        if (Colegio.alunos[i].Contains(serieListaDeletar))
                        {
                            Colegio.alunos.RemoveAt(i);
                            Console.WriteLine("NOME REMOVIDO COM SUCESSO");
                        }
                    }
                    break;

                default:
                    break;
            }
        }
        public static void Print(string s)
        {
            Console.WriteLine(s);
        }


        public static void Menu()
        {
            int opcao = 0;
            while (opcao != 5)
            {

                Console.WriteLine("****************************************************COLEGIO************************************************************");
                Console.WriteLine("*****************************************************MENU**************************************************************");
                Console.WriteLine("1 - CADASTRAR ALUNO");
                Console.WriteLine("2 - LISTAR ALUNOS");
                Console.WriteLine("3 - ATUALIZAR ALUNO");
                Console.WriteLine("4 - EXCLUIR ALUNO");
                Console.WriteLine("5 - SAIR DO SISTEMA");
                Console.Write("OPCAO: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Colegio.AdicionarAluno();
                        break;
                    case 2:
                        Colegio.ListarAluno();
                        break;
                    case 3:
                        Colegio.AtualizarAluno();
                        break;
                    case 4:
                        Colegio.deletarAluno();
                        break;


                }
            }

        }
    }
}
