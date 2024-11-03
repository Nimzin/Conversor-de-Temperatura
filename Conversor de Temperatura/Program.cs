class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao conversor de temperatura do NIM");
        Console.WriteLine("Escolha o tipo de conversão:");
        Console.WriteLine("1 - Celsius para Fahrenheit");
        Console.WriteLine("2 - Fahrenheit para Celsius");
        Console.Write("Opção: ");
        if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 1 || opcao > 2)
        {
            Console.WriteLine("Opção Inválida");
            return;
        }
        Console.Write("Digite a temperatura: ");
        if (!double.TryParse(Console.ReadLine(), out double temp))
        {
            Console.WriteLine("Opção invalida");
            return;
        }
        double resultado = 0;
        switch (opcao)
            
        {
            case 1: resultado = (temp * 9 / 5) + 32;
                break;
            case 2: resultado = (temp - 32) * 5 / 9;
                break;
        }
        Console.WriteLine($" A temperatura é: {resultado}");
    }
}