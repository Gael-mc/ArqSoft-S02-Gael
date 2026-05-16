using System;
using System.Collections.Generic;
using System.Text;

namespace Ahorcado
{
    public class ConsolaUI
    {
        private readonly MotorAhorcado _motor;

        public ConsolaUI(MotorAhorcado motor)
        {
            _motor = motor;
        }

        // Método para elegir la categoría
        public static string PedirCategoria()
        {
            var categorias = PalabrasEnMemoria.ObtenerCategorias();

            Console.WriteLine("\nElige una categoría:");
            for (int i = 0; i < categorias.Count; i++)
                Console.WriteLine($"{i + 1}. {categorias[i]}");

            int opcion;
            do
            {
                Console.Write("Opción: ");
            }
            while (!int.TryParse(Console.ReadLine(), out opcion) ||
                   opcion < 1 ||
                   opcion > categorias.Count);

            return categorias[opcion - 1];
        }

        public void MostrarTablero()
        {
            Console.Clear();
            MostrarAhorcado();

            Console.WriteLine($"Intentos restantes: {_motor.IntentosRestantes}");
            Console.WriteLine($"Letras usadas: {string.Join(", ", _motor.LetrasUsadas)}");

            Console.Write("Palabra: ");
            foreach (char c in _motor.PalabraSecreta)
            {
                Console.Write(_motor.LetrasUsadas.Contains(c) ? c : '_');
                Console.Write(' ');
            }

            Console.WriteLine();

            if (_motor.MostrarPista)
                Console.WriteLine($"Pista: la palabra empieza con '{_motor.PalabraSecreta[0]}'");
        }

        public char PedirLetra()
        {
            Console.Write("\nIngresa una letra: ");
            return Console.ReadLine()[0];
        }

        public void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        public bool PreguntarOtraVez()
        {
            Console.Write("\n¿Jugar otra vez? (s/n): ");
            return Console.ReadLine()?.ToLower() == "s";
        }

        private void MostrarAhorcado()
        {
            string[] etapas = new string[]
            {
                // 0 errores
                @"  +---+
  |   |
      |
      |
      |
      |
=========",

                // 1 error
                @"  +---+
  |   |
  O   |
      |
      |
      |
=========",

                // 2 errores
                @"  +---+
  |   |
  O   |
  |   |
      |
      |
=========",

                // 3 errores
                @"  +---+
  |   |
  O   |
 /|   |
      |
      |
=========",

                // 4 errores
                @"  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========",

                // 5 errores
                @"  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========",

                // 6 errores
                @"  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
========="
            };

            int indice = 6 - _motor.IntentosRestantes;

            if (indice < 0)
                indice = 0;
            if (indice >= etapas.Length)
                indice = etapas.Length - 1;

            Console.WriteLine(etapas[indice]);
        }
    }
}