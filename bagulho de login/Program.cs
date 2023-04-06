// Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

// algoritmo
// entrada: nome e senhas do usuário
// processamento: comparar o nome com a senha, se forem iguais da erro

Console.WriteLine($"LOGIN");

Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua senha: ");
string senha = Console.ReadLine();

while (nome == senha)
{
    Console.WriteLine($"A senha não pode ser o seu nome, isso é pela sua segurança, repita com outra senha!");
    senha = Console.ReadLine();
}

Console.WriteLine($"Acesso permitido!");


