using System;
using CSharpShellCore;
namespace ConversorDeMoeda{
class Classe{
public static void Main(String[] args){

Console.WriteLine("pressione (m) para utilizar o conversor de moeda ou qualquer outro coisa para o conversor de temperatura: ");
string resposta = Console.ReadLine();

if(resposta == "m")
{

Console.WriteLine("você escolheu o conversor de moeda");
Console.WriteLine("digite (a) para converter real ou qualquer outra moeda para dóllar: ");
string escolha = Console.ReadLine();

if(escolha == "a")
{

Console.WriteLine("insira a quantia em reais: ");
float real = float.Parse(Console.ReadLine());
float dollar = real * 4.96f;
Console.WriteLine("o valor em dollar é: "+ dollar.ToString("0.00"));

}

else
{
    
Console.WriteLine("insira a quantia em dollar: ");
float dollar = float.Parse(Console.ReadLine());
float real = dollar / 4.96f;
Console.WriteLine("a quantia em reais é: "+ real.ToString("0.00"));

}


}
else
{

Console.WriteLine("bem vindo ao conversor de temperatura");
Console.WriteLine("digite (c) para converter de celsius para farenheit ou qualquer outra coisa para converter de farenheit para celsius: ");
string escolha = Console.ReadLine();

if(escolha == "c")
{

Console.WriteLine("insira a temperatura em celsius: ");
float celsius = float.Parse(Console.ReadLine());
float farenheit = celsius * 1.18f + 32f;
Console.WriteLine(" a temperatura em farenheit é: "+ farenheit);


}
else

{

Console.WriteLine("insira a temperatura em farenheit: ");
float farenheit = float.Parse(Console.ReadLine());
float celsius = (farenheit - 32f) / 1.18f;
Console.WriteLine("a temperatura em celsius é: "+celsius);

}



}

}
}
}