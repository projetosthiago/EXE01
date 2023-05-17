namespace herenca;
class program
{
    static void Main(string[] args)
    {
        cao Adalberto = new cao ();
        gato Fabio = new gato ();
        Homem Alberto = new Homem ();




        Console.WriteLine("Chamei o Gato e ele " + Fabio.fala());
        Console.WriteLine("Chamei o Cão e ele " + Adalberto.fala());
        Console.WriteLine("Chamei o Homem e ele " + Alberto.fala());
    }
}