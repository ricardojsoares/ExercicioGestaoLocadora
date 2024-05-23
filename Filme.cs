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

        public override void ExibirDetalhe()
        {
            throw new NotImplementedException();
        }
    }
}