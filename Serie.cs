using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class Serie: ItemLocadora
    {

        public int Temporadas { get; set; }
        public int Epsodios { get; set; }

        public Serie(int codigo, string titulo, int ano, int temporadas, int epsodios) : base(codigo, titulo, ano)
        {
            this.Temporadas = temporadas;
            this.Epsodios = epsodios;
        }
        public override void ExibirDetalhe()
        {
            Console.WriteLine($"[Código: {this.Codigo}, Título: {this.Titulo}, Ano: {this.Ano}, Temporadas: {this.Temporadas}, Epsódios: {this.Epsodios}");
        }
    }
}