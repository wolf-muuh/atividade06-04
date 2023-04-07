// Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:

// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.

int homens = 0; 
int mulheres = 0;
int somaIdadeH = 0; 
int somaIdadeM = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Dados da pessoa {i}:");
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine());

    string sexo = "";
    while (sexo != "M" && sexo != "F")
    {
        Console.Write("Sexo (M/F): ");
        sexo = Console.ReadLine().ToUpper();
        if (sexo != "M" && sexo != "F")
        {
            Console.WriteLine("Valor inválido. Tente novamente.");
        }
    }

    if (sexo == "M")
    {
        homens++;
        somaIdadeH += idade;
    }
    else
    {
        mulheres++;
        somaIdadeM += idade;
    }
}

double mediaIdadeHomens = somaIdadeH / homens;
double mediaIdadeMulheres = somaIdadeM / mulheres;

Console.WriteLine($"\nTotal de Homens: {homens}");
Console.WriteLine($"Total de Mulheres: {mulheres}");
Console.WriteLine($"Média de idade dos Homens: {mediaIdadeHomens:N2}");
Console.WriteLine($"Média de idade das mulheres: {mediaIdadeMulheres:N2}");

