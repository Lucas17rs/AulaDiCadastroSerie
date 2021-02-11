using System;

namespace Dio_Series
{
    class Program
    {
        static SerieRepositorio repositorio=new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while(opcaoUsuario.ToUpper()!="X"){
                switch(opcaoUsuario){
                    case"1":
                        ListarSeries();
                        break;
                    case"2":
                        inserirSerie();
                        break;
                    case"3":
                        AtualizaSerie();
                        break;                    
                    case"4":
                        ExcluirSerie();
                        break;
                    case"5":
                        VisualizarSerie();
                        break;
                    case"C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }//swith
                opcaoUsuario = ObterOpcaoUsuario();
            }//while
            
        }

        private static void VisualizarSerie()
        {
            Console.Write("digite o ID da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorID(indiceSerie);
            Console.WriteLine(serie);
        }//VisualizarSerie

        private static void ExcluirSerie()
        {
            Console.WriteLine("Dite o ID da série que para excluir: ");
            int indiceSerie=int.Parse(Console.ReadLine());
            repositorio.Exclui(indiceSerie);
        }//ExcluirSerie

        private static void AtualizaSerie()
        {
            Console.WriteLine("Atualizar Série: ");
            Console.WriteLine("Digite o ID da série");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));             
            }
            Console.Write("gigite o denêro entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("digite o título da Série: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição da serie: ");
            string entadaDescricao =Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero:(Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entadaDescricao);
            
            repositorio.Atuaza(indiceSerie, atualizaSerie);

        }//AtualizaSerie()
        

        private static void inserirSerie()
        {
            Console.WriteLine("Inserir Serie");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o Gênero ente as opções acima: ");
            int entadaGenero =int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da serie: ");
            string entadaTitulo =Console.ReadLine();

            Console.Write("Digite o Ano de inicío da série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da serie: ");
            string entadaDescricao =Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoID(),
                                            genero: (Genero)entadaGenero,
                                            titulo: entadaTitulo,
                                            descricao: entadaDescricao,
                                            ano: entradaAno);

            repositorio.Insere(novaSerie);
        }//inserirSerie

        private static void ListarSeries()
        {
            Console.WriteLine("Lista de Series: ");
            var lista = repositorio.Lista();
            if(lista.Count==0){
                Console.WriteLine("Nenhuma série cadastada.");
                return;
            }
            foreach(var serie in lista){
                var excluido =serie.retornaExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaID(), serie.retornaTitulo(), (excluido ? "*Excluido*":"") );
            }
        }//ListarSeries

        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("L7 Séries!");
            Console.WriteLine("informe a opção desejada");

            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualzar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar serie");
            Console.WriteLine("C- limpar tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }//ObterOpcaoUsuario
    }
}
