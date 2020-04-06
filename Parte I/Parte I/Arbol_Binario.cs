using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing; //librería para dibujar figuras geométricas
using System.Threading; //librería para manejo de hilos
using System.Windows.Forms;

namespace Parte_I
{
    class Arbol_Binario:Nodo_Arbol
    {

        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;

        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }


        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }






        // Función para agregar un nuevo nodo (valor) al Árbol Binario.
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
        }
        // Función para eliminar un nodo (valor) del Árbol Binario.
        public void Eliminar(int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }
        public void Buscar(int x)
        {
            if (Raiz != null)
            {
                Raiz.buscar(x, Raiz);
            }
        }

        //*******Funciones para dibujar el árbol binario en el formulario **********
        //Función para dibujar árbol binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Brush
        encuentro)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (Raiz == null)
                return;
            Raiz.PosicionNodo(ref x, y); //Posición de cada nodo
            Raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }

        public int x1 = 400;
        // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;
        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente, Pen
       Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else
            if (preor == true)
            {
                if
                (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000);
                    // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                     inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                }
            }
            else
            if
            (post == true)
            {
                if
                (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }


        public int Cantidad()
        {
            int cant = 0;
            Cantidad(this.Raiz, ref cant);
            return cant;
        }

        public void Cantidad(Nodo_Arbol reco, ref int cant)
        {
            if (reco != null)
            {
                cant++;
                Cantidad(reco.Izquierdo, ref cant);
                Cantidad(reco.Derecho, ref cant);
            }
        }

        //altura de un árbol
        public int altura(Nodo_Arbol aux, ref int h)

        {

            if (aux == null)
            {
                return 0;
            }
            else
            {
                h = 1 + Math.Max(altura(aux.Izquierdo, ref h), altura(aux.Derecho, ref h));
                return h;
            }
        }
        public int altura()
        {
            int sum = 0;
            altura(Raiz, ref sum);
            return sum;

        }
        //Profundidad de un nodo

        public int profundidad(ref int num)
        {
            int altura = 0;
            return profundidad(Raiz, altura, ref num);
        }
        public int profundidad(Nodo_Arbol raiz, int altura, ref int num)
        {

            while (raiz != null)
            {
                if (num == raiz.info)
                    return altura; /* encontrado: devolver altura */
                else
                {
                    altura++; /* Incrementamos la altura, seguimos buscando */
                    if (num < raiz.info) raiz = raiz.Izquierdo;
                    else if (num > raiz.info) raiz = raiz.Derecho;
                }
            }
            return -1; /* No está en árbol, devolver -1 */
        }


        //Suma de los nodos
        private void sumar(Nodo_Arbol rama, ref int num)
        {
            num += rama.info;
        }

        public int suma1()
        {
            int num = 0;
            return suma2(this.Raiz, ref num);
        }

        private int suma2(Nodo_Arbol rama, ref int num)
        {
            if (rama != null)
            {
                sumar(rama, ref num);

                suma2(rama.Izquierdo, ref num);
                suma2(rama.Derecho, ref num);
            }

            return num;
        }





        //RECORRIDOS
        private void visitar(Nodo_Arbol rama, ref String cadena)
        {
            if (String.IsNullOrEmpty(cadena) == true)
            {
                cadena += rama.info;
            }
            else
            {
                cadena += ", " + rama.info;
            }
        }

        public string preorden()
        {
            string cadena = "";
            return preorden2(this.Raiz, ref cadena);
        }

        private string preorden2(Nodo_Arbol rama, ref string cadena)
        {
            if (rama != null)
            {
                visitar(rama, ref cadena);

                preorden2(rama.Izquierdo, ref cadena);
                preorden2(rama.Derecho, ref cadena);
            }

            return cadena;
        }


        public string postorden()
        {
            string cadena = "";
            return postorden2(this.Raiz, ref cadena);
        }

        private string postorden2(Nodo_Arbol rama, ref string cadena)
        {
            if (rama != null)
            {
                postorden2(rama.Izquierdo, ref cadena);
                postorden2(rama.Derecho, ref cadena);
                visitar(rama, ref cadena);
            }

            return cadena;
        }


        public string inorden()
        {
            string cadena = "";

            return inorden2(this.Raiz, ref cadena);
        }

        private string inorden2(Nodo_Arbol rama, ref string cadena)
        {
            if (rama != null)
            {
                inorden2(rama.Izquierdo, ref cadena);

                visitar(rama, ref cadena);

                inorden2(rama.Derecho, ref cadena);
            }

            return cadena;
        }
    }
}

