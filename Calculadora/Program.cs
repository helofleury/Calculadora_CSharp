void ExibirMensagem()
{
    Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
}
int Somar(int a, int b)
{
    return a + b;
}

int Subtrair(int a, int b)
{
    return a - b; 
}

int Multiplicar(int a, int b)
{
    return a * b; 
}

int Dividir(int a, int b)
{
    return a / b;
}

int num1;
int num2;
int opcao;
int resultado;

opcao = 0;

ExibirMensagem();

while (opcao != 5)
{
    Console.WriteLine("Escolha uma operação:");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisão");
    Console.WriteLine("5 - Sair");

    opcao = int.Parse(Console.ReadLine());

    if (opcao >= 1 && opcao <= 4)
    {
        Console.WriteLine("Digite o primeiro número:");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        num2 = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            resultado = Somar(num1, num2);
            Console.WriteLine($"O resultado da soma de {num1} + {num2} é {resultado}");
        }
        else if (opcao == 2)
        {
            resultado = Subtrair(num1, num2);
            Console.WriteLine($"O resultado da subtração de {num1} - {num2} é {resultado}");
        }
        else if (opcao == 3)
        {
            resultado = Multiplicar(num1, num2);
            Console.WriteLine($"O resultado da multiplicação de {num1} * {num2} é {resultado}");
        }
        else if (opcao == 4)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Erro: divisão por zero não é permitida.");
            }
            else
            {
                resultado = Dividir(num1, num2);
                Console.WriteLine($"O resultado da divisão de {num1} / {num2} é {resultado}");
            }
        }
    }
}