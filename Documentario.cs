using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class Documentario: ItemLocadora
    {
        public string Assunto { get; set; }

        public override void ExibirDetalhe()
        {
            throw new NotImplementedException();
        }
    }
}