using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Parte_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Dato = 0;
        int cont = 0;
        int h = 0;
        Nodo_Arbol mi_nodo = new Nodo_Arbol(); //Creación del objeto Árbol
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); //Creación del objeto Árbol
        Graphics g; //Definición del objeto gráfico

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (valor.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else if (!isInt32(valor.Text))
            {
                MessageBox.Show("Debe Ingresar un valor entero");
            }
            else
            {
                Dato = int.Parse(valor.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    mi_Arbol.Insertar(Dato);
                    valor.Clear();
                    valor.Focus();
                    cont++;
                    Refresh();
                    Refresh();
                    //Recorridos
                    //SUMA
                    //Suma.Visible = true;
                    lblSuma.Text = (mi_Arbol.suma1()).ToString();
                    //# NODOS
                    // Numeronodos.Visible = true;
                    lblNumero.Text = (mi_Arbol.Cantidad()).ToString();
                    //ALTURA
                    lblaltura.Text = (mi_Arbol.altura()).ToString();
                }
            }
           
        }
        public bool isInt32(String num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void pre_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = mi_Arbol.preorden();
        }

        private void ino_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = mi_Arbol.inorden();
        }

        private void post_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = mi_Arbol.postorden();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (valor.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a eliminar");
            }
            else if (!isInt32(valor.Text))
            {
                MessageBox.Show("Debe Ingresar un valor entero");
            }
            else
            {
                Dato = Convert.ToInt32(valor.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Sólo se adminten valores entre 1 y 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Eliminar(Dato);
                    valor.Clear();
                    valor.Focus();
                    cont--;
                    Refresh();
                    Refresh();
                    //SUMA DE NODOS
                    lblSuma.Text = (mi_Arbol.suma1()).ToString();
                    //# DE NODOS
                    lblNumero.Text = (mi_Arbol.Cantidad()).ToString();
                    //altura del árbol 
                    lblaltura.Text = (mi_Arbol.altura()).ToString();
                }
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (valor.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor a buscar");
            }
            else if (!isInt32(valor.Text))
            {
                MessageBox.Show("Debe Ingresar un valor entero");
            }
            else
            {
                Dato = Convert.ToInt32(valor.Text);
                if (Dato <= 0 || Dato >= 100)
                {
                    MessageBox.Show("Sólo se admiten valores entre 1 y 99", "Error de Ingreso");
                }
                else
                {
                    mi_Arbol.Buscar(Dato);
                    valor.Clear();
                    valor.Focus();
                    Refresh();
                    Refresh();
                }
            }
        }

     

        private void btnProfundidadNodo_Click(object sender, EventArgs e)
        {
            if (valor.Text == "")
            {
                MessageBox.Show("Error, no ha ingresado un nodo");
            }
            else if (!isInt32(valor.Text))
            {
                MessageBox.Show("Debe Ingresar un valor entero");
            }
            else
            {
                int dato2 = Convert.ToInt32(valor.Text);
                if ((mi_Arbol.profundidad(ref dato2) <= -1))
                {
                    MessageBox.Show("Error.El nodo ingresado no existe");
                }
                else
                {
                    lblProfundidad.Text = (mi_Arbol.profundidad(ref dato2)).ToString();
                    lblProfundidad.Visible = true;
                }
                valor.Clear();
                valor.Focus();
                Refresh();
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;
            mi_Arbol.DibujarArbol(g, this.Font, Brushes.Blue, Brushes.White, Pens.Black, Brushes.White);
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void lblProfundidad_Click(object sender, EventArgs e)
        {

        }
    }
}
