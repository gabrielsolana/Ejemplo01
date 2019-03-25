using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class TresEnRaya
    {
        public int[,] tablero = new int[3, 3];
        public bool turno;

        public void reset()
        {
            for (int i = 0; i < tablero.Length; i++)
            {
                for (int j = 0; j < tablero.Length; j++)
                {
                    tablero[i, j] = 0;
                }
            }
        }
        public void pulsaBoton (int fila, int columna)
        {
            if (tablero[fila,columna] == 0)
            {
                if (turno)
                    tablero[fila, columna] = 1;
                else
                    tablero[fila, columna] = 2;

                turno = !turno;
            }
        }

        public string comprobarGanador()
        {
            string resultado = "";

            if (tablero[0, 0] > 0 && tablero[0, 0] == tablero[1, 1] && tablero[0, 0] == tablero[2, 2])
                return $"Ha ganado el jugador {tablero[0,0]}";
            if (tablero[2, 0] > 0 && tablero[2, 0] == tablero[1, 1] && tablero[0, 0] == tablero[2, 2])
                return $"Ha ganado el jugador {tablero[0, 0]}";
        }

    }
}
