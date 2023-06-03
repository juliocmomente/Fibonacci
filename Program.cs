class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sequencia de Fibonacci!");
        System.Console.Write("informe a quantidade de termos (mínimo 3): ");
        int qtd = Convert.ToInt32(System.Console.ReadLine());
        System.Console.WriteLine();

        FibSeq fibonacci = new FibSeq();
        fibonacci.gerarSequenciaFibonacci(qtd);
        fibonacci.imprimirSequencia();

    }
}