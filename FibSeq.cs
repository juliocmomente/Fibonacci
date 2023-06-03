class FibSeq
{
    private List<int> sequenciaFibonacci = new List<int> { 0, 1 };

    public void gerarSequenciaFibonacci(int qtdTermos)
    {
        if (qtdTermos < 2)
        {
            System.Console.WriteLine("A quantidade mínima é 3");
        }

        for (int i = 2; i < qtdTermos; i++)
        {
            int proximo = sequenciaFibonacci[i - 2] + sequenciaFibonacci[i - 1];
            sequenciaFibonacci.Add(proximo);
        }
    }

    public void imprimirSequencia()
    {
        foreach (int item in sequenciaFibonacci)
        {
            System.Console.WriteLine($"[{sequenciaFibonacci.IndexOf(item) + 1}] - {item}");
        }
    }
}