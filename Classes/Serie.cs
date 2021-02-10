using System;
namespace Dio_Series
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero Genero {get;set;}
        private string Titulo{get;set;}
        private string Descricao{get;set;}
        private int Ano {get;set;}

        private bool Excluido{get;set;}
        
        //metodos

        public Serie(int id, Genero genero, string titulo, string descricao,int ano){
            this.Id=id;
            this.Genero=genero;
            this.Titulo=titulo;
            this.Descricao=descricao;
            this.Ano=ano;
            this.Excluido =false;
        }//inicializador

        public override string ToString()
        {
            string retorno ="";
            retorno+="Género: " + this.Genero + Environment.NewLine;
            retorno+="Titulo: " + this.Titulo + Environment.NewLine;
            retorno+="Descrição: " + this.Descricao + Environment.NewLine;
            retorno+="Ano de Inicio: " + this.Ano + Environment.NewLine;
            return retorno;
        }//toString

        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaID(){
            return this.Id;
        }

        public void Excluir(){
            this.Excluido=true;
        }

    }
}