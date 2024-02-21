Console.WriteLine("Digite um Numero: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O Numero: " + numero + " é Par.");
}
else
{
    Console.WriteLine("O Numero: " + numero + " é Ímpar.");
}