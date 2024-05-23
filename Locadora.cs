using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class Locadora
    {
        List<ItemLocadora> lista = new();

        public void AdicionarItem(ItemLocadora item)
        {
            lista.Add(item);
        } 
        public void RemoverItem(int codigo)
        {
            var item = lista.FirstOrDefault(i => i.Codigo == codigo);

            if (item != null)
            {
                lista.Remove(item);
            }
        }
        public void ListarItens()
        {
            foreach(var item in lista)
            {
                item.ExibirDetalhe();
            }
        } 
    }
}