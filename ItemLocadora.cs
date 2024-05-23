using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public abstract class ItemLocadora
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }

        public abstract void ExibirDetalhe();
    }
}