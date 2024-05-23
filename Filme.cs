using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class Filme: ItemLocadora
    {

        public string Diretor { get; set; }
        public int Duracao { get; set; }

        public Filme(int codigo, string titulo, int ano, string diretor, int duracao) : base(codigo, titulo, ano)
        {
            this.Diretor = diretor;
            this.Duracao = duracao;
        }

        public override void ExibirDetalhe()
        {
            Console.WriteLine($"[Código: {this.Codigo}, Título: {this.Titulo}, Ano: {this.Ano}, Diretor: {this.Diretor}, Duração: {this.Duracao}]");
        }
    }
}