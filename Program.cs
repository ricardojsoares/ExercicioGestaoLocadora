using ExercicioGestaoLocadora;

class Program
{
    static void Main(string [] args)
    {
        Locadora locadora = new();

        locadora.AdicionarItem(new Filme(1, "De vota para o futuro", 1984, "Stiven Spilberg", 120));
        locadora.AdicionarItem(new Documentario(1, "A vida dos animais", 2000, "Natureza"));
        locadora.ListarItens();
    }
}