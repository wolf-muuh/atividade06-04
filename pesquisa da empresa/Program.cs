// Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:

// O número de pessoas que responderam SIM.
// O número de pessoas que responderam NÃO;
// O número de mulheres que responderam SIM;
// A porcentagem de homens que responderam NÃO entre todos os homens analisados.



int s = 0;
int n = 0;
int mulheresS = 0;
int homensS = 0;
int homensN = 0;
int homensTotal = 0;

int i = 0;
while (i < 10)
{
    Console.Write($"Informe o sexo da {i + 1}ª pessoa (M/F): ");
    string sexo = Console.ReadLine();

    if (sexo.ToLower() == "m" || sexo.ToLower() == "f")
    {
        Console.Write($"Essa pessoa gostou do produto? (S/N): ");
        string resposta = Console.ReadLine();

        if (resposta.ToLower() == "s")
        {
            s++;
            if (sexo.ToLower() == "f")
            {
                mulheresS++;
            }
            else
            {
                homensS++;
            }
        }
        else if (resposta.ToLower() == "n")
        {
            n++;
            if (sexo.ToLower() == "m")
            {
                homensN++;
            }
        }
        else
        {
            Console.WriteLine("Resposta inválida. Tente novamente.");
            continue;
        }

        i++;
    }
    else
    {
        Console.WriteLine("Sexo inválido. Tente novamente.");
    }
}

homensTotal = homensS + homensN;
double homensNporcentagem = (double)homensN / homensTotal * 100;

Console.WriteLine($"Número de pessoas que responderam SIM: {s}");
Console.WriteLine($"Número de pessoas que responderam NÃO: {n}");
Console.WriteLine($"Número de mulheres que responderam SIM: {mulheresS}");
Console.WriteLine($"Porcentagem de homens que responderam NÃO: {homensNporcentagem}%");

