using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class Documentario: ItemLocadora
    {

        public string Assunto { get; set; }

        public Documentario(int codigo, string titulo, int ano, string assunto) : base(codigo, titulo, ano)
        {
            this.Assunto = assunto;
        }
        public override void ExibirDetalhe()
        {
            Console.WriteLine($"[Código: {this.Codigo}, Título: {this.Titulo}, Ano: {this.Ano}, Assunto: {this.Assunto}]");
        }
    }
}