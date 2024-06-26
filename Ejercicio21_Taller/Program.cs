﻿namespace Ejercicio21_Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:
            //Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente
            //Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable
            //Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso
            //Si el IMC es mayor de 29,9 entonces tiene obesidad.
            //Mostrar en pantalla la categoría de cada uno de los pacientes. La aplicación debe estar en capacidad de pedirle al usuario si quiere volver a calcular.

            //Declaracion variable para respuesta si desea continuar calculando
            string respuesta;

            do
            {
                //Declaracion variables para calculos IMC
                double peso, altura, imc, alturaT;

                Console.Write("\nIngrese el Peso del paciente en (KG): ");
                peso = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la Altura del Paciente en (Mts): ");
                altura = double.Parse(Console.ReadLine());

                // Operacion entre Altura * Altura para la formula IMC
                alturaT = altura * altura;

                // Formula para calcular indice de masa corporal
                imc = (peso / alturaT);
                //Validacion de condiciones 

                if (imc < 18.5)
                    Console.WriteLine("\nEl paciente tiene un IMC de " + imc + " y se encuentra en la categoría: PESO INSUFICIENTE");
                else if (imc >= 18.5 && imc <= 24.9)
                    Console.WriteLine("\nEl paciente tiene un IMC de " + imc + " y se encuentra en la categoría: PESO SALUDABLE");
                else if (imc >= 25 && imc <= 29.9)
                    Console.WriteLine("\nEl paciente tiene un IMC de " + imc + " y se encuentra en la categoría: SOBREPESO");
                else
                    Console.WriteLine("\nEl paciente tiene un IMC de " + imc + " y se encuentra en la categoría: OBESIDAD");

                Console.WriteLine("\n¿Quiere volver a calcular un nuevo Paciente? (s/n)");
                respuesta = Console.ReadLine();
            } while (respuesta.ToLower() == ("s"));
        }
    }
}