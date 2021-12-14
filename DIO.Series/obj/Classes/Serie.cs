/* Criando um APP simples de casdatro de series em .NET - Parte 2 

explicação incia no segundo video sobre "Series".

*/
namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        
        private Genero genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private bool Excluido {get; set;} // Foi adicionado na parte 4

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano) 
        {
                this.Id= id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = false; // Foi adicionado na parte 4
        }
        
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: "+ this.Genero + Enviroment.NewLine;
            retorno += "Titulo: "+ this.Titulo + Enviroment.NewLine;
            retorno += "Descrição: "+ this.Descricao + Enviroment.NewLine;
            retorno += "Ano de Início: "+ this.Ano + Enviroment.NewLine;
            retorno += "Excluido: "+ this.Excluido;

            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        /*public bool retornaExcluido() // Foi adicionado na parte 4
        {
            return this.Excluido;
        }*/
        public void Excluir() // Foi adicionado na parte 4
        {
            this.Ecluido = true;
        }
        
    }
}