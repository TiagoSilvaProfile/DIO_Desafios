/* Criando um APP simples de casdatro de series em .NET - Parte 4 

explicação incia no quarto video sobre o "Programa".

*/

using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio(); //Explicação na parte 4 : 08:50 mm:ss 
        static void Main(string[] args)
        {
           string opcaoUsuario = ObterOpcaoUsuario(); // Aqui onde será filtrado a opção do usuario.

           while (opcaoUsuario.ToUpper() !="X")// A aplicação do ToUpper irá converter a opção em Maiúsculo.
           {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
           }

           Console.WriteLine("Obrigado por utilizar nossos serviços.");
           Console.WriteLine();
        }

        private static void ExcluirSerie() // Foi adicionado na parte 5
        {
            Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie() // Foi adicionado na parte 5
        {
            Console.WriteLine("Digite o ID da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }
        private static void AtualizarSerie() // Foi adicionado na parte 5
        {
            Console.WriteLine("Digite o id da serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {              
                Console.WriteLine("{0}-{1}", i, Enum.GetNames(typeof(Genero), i));
            }

            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            int entradaTitulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série: ");
            int entradaDescricao = int.Parse(Console.ReadLine());

            Serie atualizaSerie = new Serie (id: indiceSerie,
                                            genero: (GenericUriParserOptions)entradaGenero,
                                            titulo: entradaTitulo,
                                            descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
        private static void ListarSeries() // explicação parte 4 : 8:50 mm:ss
        {
            Console.WriteLine("Listar Séries");

            var lista = repositorio.Lista();

            if (lista.count == 0)
            {
                Console.WriteLine("Nenhuma Série cadastrada.");
                return;
            }

            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido(); // Foi adicionado na parte 5

                Console.WriteLine("#ID {0}: -{1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*" : ""));

            }
        }
        private static void InserirSerie() // explicação parte 4 : 11:00 mm:ss
        {
            Console.WriteLine("Inserir nova série");
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {              
                Console.WriteLine("{0}-{1}", i, Enum.GetNames(typeof(Genero), i));
            }
            
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Título da Série: ");
            int entradaTitulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da Série: ");
            int entradaDescricao = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                         genero: (Genero)entradaGenero,
                                         titulo: entradaTitulo,
                                         ano: entradaAno,
                                         descricao: entradaDescricao);
                                         repositorio.Insere(novaSerie);

            repositorio.Insere(novaSerie);
        }
        private static string ObterOpcaoUsuario()
        {
            
            Console.WriteLine();
            Console.WriteLine("DIO Series a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Lista séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();
            
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
            
        }
    }
}
