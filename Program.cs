using System;
using static System.Console;

namespace IMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Digite seu nome: ");
            string nome = ReadLine();
            WriteLine($"Olá {nome} digite sua idade: ");
            string age = ReadLine();
            WriteLine("Insira seu  peso atual: ");
            float wheight = (float)Convert.ToDouble(ReadLine());
            WriteLine("Insira sua altura: ");
            float higth = (float)Convert.ToDouble(ReadLine());

            float imc = wheight / (higth * higth);
            string text;

            if (imc < 18.5)
            {
                text = "seu IMC é: " + Math.Round(imc, 2) + "e está abaixo do peso.";
            }
            else if (imc < 25)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e está com peso normal.";
            else if (imc < 30)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e está com sobrepeso.";
            else if (imc < 40)
                text = "seu IMC é: " + Math.Round(imc, 2) + " e está com obesidade.";
            else
                text = "seu IMC é: " + Math.Round(imc, 2) + " e está com obesidade grave.";

            WriteLine($@"{nome}, você tem: {age} anos de idade, {text}");


        }
    }
}
