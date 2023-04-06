// Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

// algoritmo
// entrada: nota do aluno
// processo: comparar a nota do aluno com a média pedida

Console.WriteLine($"digite sua nota (lembrando a nota só vai de 0 a 10)");
float nota = float.Parse(Console.ReadLine());

while (nota < 0 || nota > 10)
{
    Console.WriteLine($"Nota inválida");
    nota = float.Parse(Console.ReadLine());
}

