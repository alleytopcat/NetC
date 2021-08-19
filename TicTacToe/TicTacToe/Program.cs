using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        // Crear arreglo bidimensional
        static int[,] tablero = new int[3, 3]; // 3 filas 3 columnas
        // crear un arreglo parasimbolos del tablero
        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {

            // Dibuja el tablero
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2 = X");

        } // Cierre de MAIN
        static void DibujarTablero()
        {
            // Variables de conteo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); // Margen del tablero
            Console.WriteLine("-------------"); // dibuja la linea horizontal
            for(fila = 0; fila < 3; fila ++)
            {
                Console.Write("|"); //Dibuja la primera linea vertical
                for(columna = 0; columna <3; columna++)
                {
                    // Asigna un: Espacio, O, X, segun corresponda
                    Console.Write(" {0} |", simbolo[tablero[fila,columna]]); // Dibuja las demas lineas verticales
                }
                Console.WriteLine();
                Console.WriteLine("-------------"); // lineas horizontales
            }
        }
        
        // Pregunta donde poner la ficha
        static void PreguntarPosicion(int jugador) // 1 = Jugador 1 ; 2 Jugador 2
        {
            int fila, columna;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Turno del Jugador: {0}", jugador);
                // Pedir el numero de Fila
                do
                {
                    Console.Write("Selecciona la fila (1 a la 3 ): ");
                    fila = Convert.ToInt32(Console.ReadLine());

                } while ((fila < 1) || (fila > 3)); // se ejecuta mientras fila sea menor a 1 o mayor a 3

                //Pedir numero de columna
                do
                {
                    Console.Write("Selecciona la columna (1 a la 3 ): ");
                    columna = Convert.ToInt32(Console.ReadLine());

                } while ((fila < 1) || (fila > 3));

                if (tablero[fila - 1, columna - 1] != 0)
                    Console.WriteLine("Casilla Ocupada!");

            } while (tablero[fila - 1, columna - 1] != 0);

            // Si todo es correcto, se le asigna al jugador correspondiente
            tablero[fila - 1, columna - 1] = jugador;
        }

        // Devolver True si hay 3 en linea
        static bool ComprobarGanador()
        {
            int fila = 0;
            int columna = 0;
            bool ticTacToe = false;

            // Si las filas son iguales y no estan vacias
            for (fila = 0; fila < 3; fila++)
            {
                if(   (tablero[fila,0] == tablero[fila,1])
                    &&(tablero[fila,0] == tablero[fila,2])
                    &&(tablero[fila,0]!= 0              ))

                {
                    ticTacToe = true;
                }
            }

            // Si alguna columna todas las casillas son iguales  y no estan vacias

            for (columna =0; columna < 3; columna ++)
            {
                if(    (tablero[columna, 0] == tablero[1,columna])
                    && (tablero[columna, 0] == tablero[2,columna])
                    && (tablero[columna, 0] != 0                ))
                {
                    ticTacToe = true;
                }
            }

            // Si en alguna diagonal todas las casillas son iguales y no estan vacias

            if (       (tablero[0 , 0] == tablero[1, 1])
                    && (tablero[0 , 0] == tablero[2, 2])
                    && (tablero[0 , 0] != 0           ))
            {
                ticTacToe = true;
            }

            if (       (tablero[0, 2] == tablero[1, 1])
                    && (tablero[0, 2] == tablero[2, 2])
                    && (tablero[0, 2] != 0           ))
            {
                ticTacToe = true;
            }

            return ticTacToe;
        }
    }
}
