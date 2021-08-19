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
        } // Cierre de MAIN
        static void DibujarTablero()
        {
            // Variables de conteo
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); // Margen del tablero
            Console.WriteLine("-------------");
        }
    }
}
