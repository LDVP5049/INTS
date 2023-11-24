namespace INTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaNumeros numeros = new ListaEnlazadaNumeros();

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Ingresa numeros de la lista");

                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());

                Numeros nuevoNumero = new Numeros(numero);
                numeros.AgregarNumero(nuevoNumero);
            }
            Console.WriteLine("\nLista de los numeros");
            numeros.ImprimirLista();
        }
    }
}