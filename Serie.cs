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

        public override void ExibirDetalhe()
        {
            throw new NotImplementedException();
        }
    }
}