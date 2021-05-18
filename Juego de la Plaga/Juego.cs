using System;
using System.Drawing;
using System.Windows.Forms;

namespace Juego_de_la_Plaga
{
    public partial class Juego : Form
    {
        int ban = 0;    //bandear que permite saber que jugador esta de turno-- J1=0-- J2=1
        int puntaje1 = 0;
        int puntaje2 = 0;
        Button[,] tablero = new Button[10, 10];
        public Juego()
        {
            InitializeComponent();
        }
        private void Juego_Load(object sender, EventArgs e)
        {
            Ini_Tablero();
            LblTurno.Text = "Jugador 1";
        }
        void PintarCuadro(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            bool movimiento = false;
            Coordenadas(sender, e, ref x, ref y);
            if(tablero[x, y].BackColor == Color.White)
            {
                if (ban == 0)
                {
                    if (y > 0 && x > 0 && tablero[x - 1, y - 1].BackColor == Color.LightCoral)   //posicion esquina superior izquierda
                    {
                        movimiento = true;
                    }
                    else if (x > 0 && tablero[x - 1, y].BackColor == Color.LightCoral)  //posicion lado superior
                    {
                        movimiento = true;
                    }
                    else if (x > 0 && y < 9 && tablero[x - 1, y + 1].BackColor == Color.LightCoral)   //posicion esquina superior derecha
                    {
                        movimiento = true;
                    }
                    else if (y > 0 && tablero[x, y - 1].BackColor == Color.LightCoral)  //posicion lado izquierdo
                    {
                        movimiento = true;
                    }
                    else if (y < 9 && tablero[x, y + 1].BackColor == Color.LightCoral)  //posicion lado derecho
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && y > 0 && tablero[x + 1, y - 1].BackColor == Color.LightCoral)   //posicion esquina inferior izquierda
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && tablero[x + 1, y].BackColor == Color.LightCoral)  // posicion lado inferior
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && y < 9 && tablero[x + 1, y + 1].BackColor == Color.LightCoral)   //posicion esquina inferior derecha
                    {
                        movimiento = true;
                    }
                }
                else
                {
                    if (y > 0 && x > 0 && tablero[x - 1, y - 1].BackColor == Color.DodgerBlue)   //posicion esquina superior izquierda
                    {
                        movimiento = true;
                    }
                    else if (x > 0 && tablero[x - 1, y].BackColor == Color.DodgerBlue)  //posicion lado superior
                    {
                        movimiento = true;
                    }
                    else if (x > 0 && y < 9 && tablero[x - 1, y + 1].BackColor == Color.DodgerBlue)   //posicion esquina superior derecha
                    {
                        movimiento = true;
                    }
                    else if (y > 0 && tablero[x, y - 1].BackColor == Color.DodgerBlue)  //posicion lado izquierdo
                    {
                        movimiento = true;
                    }
                    else if (y < 9 && tablero[x, y + 1].BackColor == Color.DodgerBlue)  //posicion lado derecho
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && y > 0 && tablero[x + 1, y - 1].BackColor == Color.DodgerBlue)   //posicion esquina inferior izquierda
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && tablero[x + 1, y].BackColor == Color.DodgerBlue)  // posicion lado inferior
                    {
                        movimiento = true;
                    }
                    else if (x < 9 && y < 9 && tablero[x + 1, y + 1].BackColor == Color.DodgerBlue)   //posicion esquina inferior derecha
                    {
                        movimiento = true;
                    }
                }
                if (movimiento == true)
                {
                    Jugada(x, y, ref ban);
                }
            }
        
        }
        void PintarCuadroAdyacente(int x, int y, int ban)
        {
            if (ban == 0)  //si esta jugando el J1
            {
                if (y > 0 && x > 0 && tablero[x - 1, y - 1].BackColor == Color.DodgerBlue)   //posicion esquina superior izquierda
                {
                    tablero[x - 1, y - 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (x > 0 && tablero[x - 1, y].BackColor == Color.DodgerBlue)  //posicion lado superior
                {
                    tablero[x - 1, y].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (x > 0 && y < 9 && tablero[x - 1, y + 1].BackColor == Color.DodgerBlue)   //posicion esquina superior derecha
                {
                    tablero[x - 1, y + 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (y > 0 && tablero[x, y - 1].BackColor == Color.DodgerBlue)  //posicion lado izquierdo
                {
                    tablero[x, y - 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (y < 9 && tablero[x, y + 1].BackColor == Color.DodgerBlue)  //posicion lado derecho
                {
                    tablero[x, y + 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (x < 9 && y > 0 && tablero[x + 1, y - 1].BackColor == Color.DodgerBlue)   //posicion esquina inferior izquierda
                {
                    tablero[x + 1, y - 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (x < 9 && tablero[x + 1, y].BackColor == Color.DodgerBlue)  // posicion lado inferior
                {
                    tablero[x + 1, y].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
                if (x < 9 && y < 9 && tablero[x + 1, y + 1].BackColor == Color.DodgerBlue)   //posicion esquina inferior derecha
                {
                    tablero[x + 1, y + 1].BackColor = Color.LightCoral;
                    Puntaje(ban);
                }
            }
            else    //si esta jugando el J2
            {
                if (y > 0 && x > 0 && tablero[x - 1, y - 1].BackColor == Color.LightCoral)   //posicion esquina superior izquierda
                {
                    tablero[x - 1, y - 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (x > 0 && tablero[x - 1, y].BackColor == Color.LightCoral)  //posicion lado superior
                {
                    tablero[x - 1, y].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (x > 0 && y < 9 && tablero[x - 1, y + 1].BackColor == Color.LightCoral)   //posicion esquina superior derecha
                {
                    tablero[x - 1, y + 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (y > 0 && tablero[x, y - 1].BackColor == Color.LightCoral)  //posicion lado izquierdo
                {
                    tablero[x, y - 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (y < 9 && tablero[x, y + 1].BackColor == Color.LightCoral)  //posicion lado derecho
                {
                    tablero[x, y + 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (x < 9 && y > 0 && tablero[x + 1, y - 1].BackColor == Color.LightCoral)   //posicion esquina inferior izquierda
                {
                    tablero[x + 1, y - 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (x < 9 && tablero[x + 1, y].BackColor == Color.LightCoral)  // posicion lado inferior
                {
                    tablero[x + 1, y].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
                if (x < 9 && y < 9 && tablero[x + 1, y + 1].BackColor == Color.LightCoral)   //posicion esquina inferior derecha
                {
                    tablero[x + 1, y + 1].BackColor = Color.DodgerBlue;
                    Puntaje(ban);
                }
            }
        }
        void Jugada(int x,int y,ref int ban)
        {
            if(ban==0)
            {
                tablero[x, y].BackColor = Color.LightCoral;
                PintarCuadroAdyacente(x, y, ban);
                Puntaje(ban);
                ban = 1;
                LblTurno.Text = "Jugador 2";
            }
            else
            {
                tablero[x, y].BackColor = Color.DodgerBlue;
                PintarCuadroAdyacente(x, y, ban);
                Puntaje(ban);
                ban = 0;
                LblTurno.Text = "Jugador 1";
            }
        }
        void Puntaje(int ban)
        {
            if(ban==0)
            {
                puntaje1++;
                LblPuntaje1.Text = puntaje1.ToString();
            }
            else
            {
                puntaje2++;
                LblPuntaje2.Text = puntaje2.ToString();
            }
        }
        void Coordenadas(object sender, EventArgs e, ref int x, ref int y)    //Funcion que toma el nombre del boton seleccionado, splitea y obtiene el valo de x e y.
        {
            string nombre = ((Button)sender).Name;
            string[] cadena = nombre.Split("n");
            string[] cadena1 = cadena[1].Split("_");
            x = Int32.Parse(cadena1[0]);
            y = Int32.Parse(cadena1[1]);
            //return x,y;
        }
        void Ini_Tablero()      //Funcion que inicializara el tablero cargando una matriz de botones referenciadas desde la intefaz grafica
        {
            //fila 0
            tablero[0, 0] = new Button(); tablero[0, 0] = Btn0_0;
            tablero[0, 1] = new Button(); tablero[0, 1] = Btn0_1;
            tablero[0, 2] = new Button(); tablero[0, 2] = Btn0_2;
            tablero[0, 3] = new Button(); tablero[0, 3] = Btn0_3;
            tablero[0, 4] = new Button(); tablero[0, 4] = Btn0_4;
            tablero[0, 5] = new Button(); tablero[0, 5] = Btn0_5;
            tablero[0, 6] = new Button(); tablero[0, 6] = Btn0_6;
            tablero[0, 7] = new Button(); tablero[0, 7] = Btn0_7;
            tablero[0, 8] = new Button(); tablero[0, 8] = Btn0_8;
            tablero[0, 9] = new Button(); tablero[0, 9] = Btn0_9;
            //fila 1
            tablero[1, 0] = new Button(); tablero[1, 0] = Btn1_0;
            tablero[1, 1] = new Button(); tablero[1, 1] = Btn1_1;
            tablero[1, 2] = new Button(); tablero[1, 2] = Btn1_2;
            tablero[1, 3] = new Button(); tablero[1, 3] = Btn1_3;
            tablero[1, 4] = new Button(); tablero[1, 4] = Btn1_4;
            tablero[1, 5] = new Button(); tablero[1, 5] = Btn1_5;
            tablero[1, 6] = new Button(); tablero[1, 6] = Btn1_6;
            tablero[1, 7] = new Button(); tablero[1, 7] = Btn1_7;
            tablero[1, 8] = new Button(); tablero[1, 8] = Btn1_8;
            tablero[1, 9] = new Button(); tablero[1, 9] = Btn1_9;
            //fila 2
            tablero[2, 0] = new Button(); tablero[2, 0] = Btn2_0;
            tablero[2, 1] = new Button(); tablero[2, 1] = Btn2_1;
            tablero[2, 2] = new Button(); tablero[2, 2] = Btn2_2;
            tablero[2, 3] = new Button(); tablero[2, 3] = Btn2_3;
            tablero[2, 4] = new Button(); tablero[2, 4] = Btn2_4;
            tablero[2, 5] = new Button(); tablero[2, 5] = Btn2_5;
            tablero[2, 6] = new Button(); tablero[2, 6] = Btn2_6;
            tablero[2, 7] = new Button(); tablero[2, 7] = Btn2_7;
            tablero[2, 8] = new Button(); tablero[2, 8] = Btn2_8;
            tablero[2, 9] = new Button(); tablero[2, 9] = Btn2_9;
            //fila 3
            tablero[3, 0] = new Button(); tablero[3, 0] = Btn3_0;
            tablero[3, 1] = new Button(); tablero[3, 1] = Btn3_1;
            tablero[3, 2] = new Button(); tablero[3, 2] = Btn3_2;
            tablero[3, 3] = new Button(); tablero[3, 3] = Btn3_3;
            tablero[3, 4] = new Button(); tablero[3, 4] = Btn3_4;
            tablero[3, 5] = new Button(); tablero[3, 5] = Btn3_5;
            tablero[3, 6] = new Button(); tablero[3, 6] = Btn3_6;
            tablero[3, 7] = new Button(); tablero[3, 7] = Btn3_7;
            tablero[3, 8] = new Button(); tablero[3, 8] = Btn3_8;
            tablero[3, 9] = new Button(); tablero[3, 9] = Btn3_9;
            //fila 4
            tablero[4, 0] = new Button(); tablero[4, 0] = Btn4_0;
            tablero[4, 1] = new Button(); tablero[4, 1] = Btn4_1;
            tablero[4, 2] = new Button(); tablero[4, 2] = Btn4_2;
            tablero[4, 3] = new Button(); tablero[4, 3] = Btn4_3;
            tablero[4, 4] = new Button(); tablero[4, 4] = Btn4_4;
            tablero[4, 5] = new Button(); tablero[4, 5] = Btn4_5;
            tablero[4, 6] = new Button(); tablero[4, 6] = Btn4_6;
            tablero[4, 7] = new Button(); tablero[4, 7] = Btn4_7;
            tablero[4, 8] = new Button(); tablero[4, 8] = Btn4_8;
            tablero[4, 9] = new Button(); tablero[4, 9] = Btn4_9;
            //fila 5
            tablero[5, 0] = new Button(); tablero[5, 0] = Btn5_0;
            tablero[5, 1] = new Button(); tablero[5, 1] = Btn5_1;
            tablero[5, 2] = new Button(); tablero[5, 2] = Btn5_2;
            tablero[5, 3] = new Button(); tablero[5, 3] = Btn5_3;
            tablero[5, 4] = new Button(); tablero[5, 4] = Btn5_4;
            tablero[5, 5] = new Button(); tablero[5, 5] = Btn5_5;
            tablero[5, 6] = new Button(); tablero[5, 6] = Btn5_6;
            tablero[5, 7] = new Button(); tablero[5, 7] = Btn5_7;
            tablero[5, 8] = new Button(); tablero[5, 8] = Btn5_8;
            tablero[5, 9] = new Button(); tablero[5, 9] = Btn5_9;
            //fila 6
            tablero[6, 0] = new Button(); tablero[6, 0] = Btn6_0;
            tablero[6, 1] = new Button(); tablero[6, 1] = Btn6_1;
            tablero[6, 2] = new Button(); tablero[6, 2] = Btn6_2;
            tablero[6, 3] = new Button(); tablero[6, 3] = Btn6_3;
            tablero[6, 4] = new Button(); tablero[6, 4] = Btn6_4;
            tablero[6, 5] = new Button(); tablero[6, 5] = Btn6_5;
            tablero[6, 6] = new Button(); tablero[6, 6] = Btn6_6;
            tablero[6, 7] = new Button(); tablero[6, 7] = Btn6_7;
            tablero[6, 8] = new Button(); tablero[6, 8] = Btn6_8;
            tablero[6, 9] = new Button(); tablero[6, 9] = Btn6_9;
            //fila 7
            tablero[7, 0] = new Button(); tablero[7, 0] = Btn7_0;
            tablero[7, 1] = new Button(); tablero[7, 1] = Btn7_1;
            tablero[7, 2] = new Button(); tablero[7, 2] = Btn7_2;
            tablero[7, 3] = new Button(); tablero[7, 3] = Btn7_3;
            tablero[7, 4] = new Button(); tablero[7, 4] = Btn7_4;
            tablero[7, 5] = new Button(); tablero[7, 5] = Btn7_5;
            tablero[7, 6] = new Button(); tablero[7, 6] = Btn7_6;
            tablero[7, 7] = new Button(); tablero[7, 7] = Btn7_7;
            tablero[7, 8] = new Button(); tablero[7, 8] = Btn7_8;
            tablero[7, 9] = new Button(); tablero[7, 9] = Btn7_9;
            //fila 8
            tablero[8, 0] = new Button(); tablero[8, 0] = Btn8_0;
            tablero[8, 1] = new Button(); tablero[8, 1] = Btn8_1;
            tablero[8, 2] = new Button(); tablero[8, 2] = Btn8_2;
            tablero[8, 3] = new Button(); tablero[8, 3] = Btn8_3;
            tablero[8, 4] = new Button(); tablero[8, 4] = Btn8_4;
            tablero[8, 5] = new Button(); tablero[8, 5] = Btn8_5;
            tablero[8, 6] = new Button(); tablero[8, 6] = Btn8_6;
            tablero[8, 7] = new Button(); tablero[8, 7] = Btn8_7;
            tablero[8, 8] = new Button(); tablero[8, 8] = Btn8_8;
            tablero[8, 9] = new Button(); tablero[8, 9] = Btn8_9;
            //fila 9
            tablero[9, 0] = new Button(); tablero[9, 0] = Btn9_0;
            tablero[9, 1] = new Button(); tablero[9, 1] = Btn9_1;
            tablero[9, 2] = new Button(); tablero[9, 2] = Btn9_2;
            tablero[9, 3] = new Button(); tablero[9, 3] = Btn9_3;
            tablero[9, 4] = new Button(); tablero[9, 4] = Btn9_4;
            tablero[9, 5] = new Button(); tablero[9, 5] = Btn9_5;
            tablero[9, 6] = new Button(); tablero[9, 6] = Btn9_6;
            tablero[9, 7] = new Button(); tablero[9, 7] = Btn9_7;
            tablero[9, 8] = new Button(); tablero[9, 8] = Btn9_8;
            tablero[9, 9] = new Button(); tablero[9, 9] = Btn9_9;

            tablero[0, 0].BackColor = Color.LightCoral;
            tablero[9, 9].BackColor = Color.DodgerBlue;
        }
    }
}
