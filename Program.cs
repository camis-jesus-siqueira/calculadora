﻿using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome");
            string nome = Console.ReadLine();

             Console.WriteLine("Entre com sua altura. Ex: 1,65");
            float altura = Convert.ToSingle(Console.ReadLine());

             Console.WriteLine("Entre com o seu peso em kg. Ex:67,7");
             float peso = Convert.ToSingle(Console.ReadLine());

             double imc = peso / (altura* altura);
             
             Console.WriteLine("{0} sua altura é {1} e o seu peso {2}", nome, altura, peso);
             Console.WriteLine("Seu IMC é {0}", imc);

             if(imc < 17){
                Console.WriteLine("Você está bem abaixo do peso");
            }else if(imc > 17 && imc < 18.5){
                Console.WriteLine("Você está abaixo do peso");
            }else if(imc > 18.5 && imc < 25){
                Console.WriteLine("Você está com o peso ideal");
            }else if(imc > 25 && imc < 30){
                Console.WriteLine("Você está acima do peso");
            }else if(imc > 30 && imc < 35){
                Console.WriteLine("Você está com obesidade tipo I");
            }else if(imc > 35 && imc < 40){
                Console.WriteLine("Você está com  Obesidade severa tipo II");
            }else  if (imc > 40){
                Console.WriteLine(" voce esta com Obesidade mórbida tipo III");
            }
        }
    }
}
