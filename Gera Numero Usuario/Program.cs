Console.WriteLine("Quantos Numeros Aleatorios Deseja: ");
int limiteAleatorio = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual o Numero Limite Maximo: ");
int numeroLimite = Convert.ToInt32(Console.ReadLine());

Random randnum = new Random();

for (int i = 0; i < limiteAleatorio; i++) 
{ 
Console.WriteLine(randnum.Next(0, numeroLimite));
}