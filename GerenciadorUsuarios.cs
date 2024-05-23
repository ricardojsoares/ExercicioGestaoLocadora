using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioGestaoLocadora
{
    public class GerenciadorUsuarios
    {
        List<Usuario> lista = new();

        public void AdicionarUsuario(Usuario usuario)
        {
            lista.Add(usuario);
        }
        public void RemoverUsuario(int id)
        {
            var item = lista.FirstOrDefault(i => i.Id == id);

            if (item != null)
            {
                lista.Remove(item);
            }
        }
        public void ListarUsuarios()
        {
            foreach(var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}