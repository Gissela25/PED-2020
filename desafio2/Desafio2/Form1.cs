using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        int total = 0;
        int total2 = 0;
        Random numeros = new Random();


        int cont = 0;
        int dato = 0;
        int datb = 0;
        int cont2 = 0;
        int pintaR = 0;
        //int n1;
        //int n2;
        //int n3;
        //int n4;
        //int n5;
        //char l1;
        //char l2;
        //char l3;
        //char l4;
        //char l5;
        
        DibujaAVL arbolAVL = new DibujaAVL(null);
        DibujaAVL arbolAVL_Letra = new DibujaAVL(null);
        Graphics g;
       

        public Form1()
        {
            InitializeComponent();
            txttotal.Text = Convert.ToString(total);
            textBox20.Text = Convert.ToString(total2);

        }
         
        private void btningresar_Click(object sender, EventArgs e)
        {
            //    n1 = numeros.Next(97, 123);
            //    n2 = numeros.Next(97, 123);
            //    n3 = numeros.Next(97, 123);
            //    n4 = numeros.Next(97, 123);
            //    n5 = numeros.Next(97, 123);
            //    l1 = Convert.ToChar(n1);
            //    l2 = Convert.ToChar(n2);
            //    l3 = Convert.ToChar(n3);
            //    l4 = Convert.ToChar(n4);
            //    l5 = Convert.ToChar(n5);
            if (total == 7)
            { MessageBox.Show("La cola está llena"); }
            else
            {
                total++;
                txttotal.Text = Convert.ToString(total);

                switch (total)
                {
                    case 1:
                        textBox1.Text = Convert.ToString(numeros.Next(1,99));
                        textBox1.Visible = true;
                        break;
                    case 2:
                        textBox2.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox2.Visible = true;
                        break;
                    case 3:
                        textBox3.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox3.Visible = true;
                        break;
                    case 4:
                        textBox4.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox4.Visible = true;
                        break;
                    case 5:
                        textBox5.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox5.Visible = true;
                        break;
                    case 6:
                        textBox7.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox7.Visible = true;
                        break;
                    case 7:
                        textBox8.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox8.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error en la cola");
                        break;
                }
            }
            timer1.Enabled = true;
        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            if (total == 0)
            { MessageBox.Show("Cola vacía, no puede eliminar datos"); }
            else
            {
                textBox6.Text = textBox1.Text;
                textBox1.Text = textBox2.Text;
                textBox2.Text = textBox3.Text;
                textBox3.Text = textBox4.Text;
                textBox4.Text = textBox5.Text;
                textBox5.Text = textBox7.Text;
                textBox8.Text = textBox8.Text;
                

                if (total == 1) textBox1.Visible = false;
                if (total == 2) textBox2.Visible = false;
                if (total == 3) textBox3.Visible = false;
                if (total == 4) textBox4.Visible = false;
                if (total == 5) textBox5.Visible = false;
                if (total == 6) textBox7.Visible = false;
                if (total == 7) textBox8.Visible = false;
                total--;
                txttotal.Text = Convert.ToString(total);
                timer2.Enabled = true;
                if(total == 1)
                {
                    label2.Text = textBox6.Text;
                }
                if(total == 2)
                {
                    label2.Text = textBox6.Text;
                }
                if(total == 3)
                {
                    label2.Text = textBox6.Text; 
                }
                if(total == 4)
                {
                    label2.Text = textBox6.Text;
                }
                if(total == 5)
                {
                    label2.Text = textBox6.Text;
                }
                if (total == 6)
                {
                    label2.Text = textBox6.Text;
                }
                if (total == 7)
                {
                    label2.Text = textBox6.Text;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //btningresar.Enabled = false;
            //if (total == 1)
            //{
            //    pictureBox1.Left = pictureBox1.Left + 5;
            //    if (pictureBox1.Left >= 300) timer1.Enabled = false;
            //}
            //if (total == 2)
            //{
            //    pictureBox2.Left = pictureBox2.Left + 5;
            //    if (pictureBox2.Left >= 250) timer1.Enabled = false;
            //}
            //if (total == 3)
            //{
            //    pictureBox3.Left = pictureBox3.Left + 5;
            //    if (pictureBox3.Left >= 200) timer1.Enabled = false;
            //}
            //if (total == 4)
            //{
            //    pictureBox4.Left = pictureBox4.Left + 5;
            //    if (pictureBox4.Left >= 150) timer1.Enabled = false;
            //}
            //if (total == 5)
            //{
            //    pictureBox5.Left = pictureBox5.Left + 5;
            //    if (pictureBox5.Left >= 100) timer1.Enabled = false;
            //}
            //if (timer1.Enabled == false) btningresar.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //btnextraer.Enabled = false;
            //pictureBox1.Left = pictureBox1.Left + 5;
            //if (pictureBox1.Left >= 600)
            //{
            //    pictureBox1.Left = 300;
            //    if (total == 4) pictureBox5.Left = -50;
            //    if (total == 3) pictureBox4.Left = -50;
            //    if (total == 2) pictureBox3.Left = -50;
            //    if (total == 1) pictureBox2.Left = -50;
            //    if (total == 0) pictureBox1.Left = -50;
            //    timer2.Enabled = false;
            //}
            //if (timer2.Enabled == false) btnextraer.Enabled = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            arbolAVL.DibujarArbol(g, this.Font,
            Brushes.White, Brushes.Black, Pens.White, datb, Brushes.Black);
            datb = 0;



            if (pintaR == 1)
            {
                arbolAVL.colorear(g, this.Font, Brushes.Black, Brushes.Yellow, Pens.Blue, arbolAVL.Raiz, radioButton1.Checked,
                radioButton2.Checked, radioButton3.Checked);
                pintaR = 0;
            }

            if (pintaR == 2)
            {
                arbolAVL.colorearB(g, this.Font, Brushes.White, Brushes.Red, Pens.White, arbolAVL.Raiz,
                int.Parse(label2.Text));
                pintaR = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errores.Clear();
            if (label2.Text == "")
            {
                errores.SetError(label2, "Valor obligatorio");
            }
            else
            {
                try
                {
                    dato = int.Parse(label2.Text);

                    arbolAVL.Insertar(dato);
                    label2.Text = "";
                    label2.Focus();
                    label3.Text = arbolAVL.Raiz.getAltura(arbolAVL.Raiz).ToString();
                    cont++;
                    Refresh();
                    Refresh();
                    if (radioButton1.Checked == true)
                    {
                        textBox1.Text = (arbolAVL.preorden()).ToString();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        textBox1.Text = (arbolAVL.inorden()).ToString();
                    }
                    else if (radioButton3.Checked == true)
                    {
                        textBox1.Text = (arbolAVL.postorden()).ToString();
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    errores.SetError(label2, "Debe ser numérico");
                }
            }
            errores.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            errores.Clear();
            if (textBox9.Text == "")
            {
                errores.SetError(textBox9, "Valor obligatorio");
            }

            else
            {
                try
                {
                    dato = int.Parse(textBox9.Text);
                    //textBox9.Clear();
                    //label4.Text = textBox9.Text;
                    arbolAVL.Eliminar(dato);
                    label3.Text = arbolAVL.Raiz.getAltura(arbolAVL.Raiz).ToString();
                    Refresh();
                    Refresh();
                    cont2++;

                }
                catch (Exception ex)
                {
                    errores.SetError(textBox9, "Debe ser numerico");
                }

            }
            Refresh();
            Refresh();
            Refresh();

            if (total2 == 10)
            { MessageBox.Show("La cola está llena"); }
            else
            {
                total2++;
                txttotal.Text = Convert.ToString(total2);

                switch (total2)
                {
                    case 1:
                        textBox10.Text = Convert.ToString(textBox9.Text);
                        textBox10.Visible = true;
                        break;
                    case 2:
                        textBox11.Text = Convert.ToString(textBox9.Text);
                        textBox11.Visible = true;
                        break;
                    case 3:
                        textBox12.Text = Convert.ToString(textBox9.Text);
                        textBox12.Visible = true;
                        break;
                    case 4:
                        textBox13.Text = Convert.ToString(textBox9.Text);
                        textBox13.Visible = true;
                        break;
                    case 5:
                        textBox14.Text = Convert.ToString(textBox9.Text);
                        textBox14.Visible = true;
                        break;
                    case 6:
                        textBox15.Text = Convert.ToString(textBox9.Text);
                        textBox15.Visible = true;
                        break;
                    case 7:
                        textBox16.Text = Convert.ToString(textBox9.Text);
                        textBox16.Visible = true;
                        break;
                    case 8:
                        textBox17.Text = Convert.ToString(textBox9.Text);
                        textBox17.Visible = true;
                        break;
                    case 9:
                        textBox18.Text = Convert.ToString(textBox9.Text);
                        textBox18.Visible = true;
                        break;
                    case 10:
                        textBox19.Text = Convert.ToString(textBox9.Text);
                        textBox19.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error en la cola");
                        break;
                }
            }
            timer3.Enabled = true;
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = e.Graphics;

            arbolAVL.DibujarArbol(g, this.Font,
            Brushes.White, Brushes.Black, Pens.White, datb, Brushes.Black);
            datb = 0;



            if (pintaR == 1)
            {
                arbolAVL.colorear(g, this.Font, Brushes.Black, Brushes.Yellow, Pens.Blue, arbolAVL.Raiz, radioButton1.Checked,
                radioButton2.Checked, radioButton3.Checked);
                pintaR = 0;
            }

            if (pintaR == 2)
            {
                arbolAVL.colorearB(g, this.Font, Brushes.White, Brushes.Red, Pens.White, arbolAVL.Raiz,
                int.Parse(label2.Text));
                pintaR = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (total2 == 0)
            {
                MessageBox.Show("Cola vacia, no puede eliminar datos");
            }
            else
            {
                textBox10.Text = textBox11.Text;
                textBox11.Text = textBox12.Text;
                textBox13.Text = textBox14.Text;
                textBox14.Text = textBox15.Text;
                textBox15.Text = textBox16.Text;
                textBox17.Text = textBox18.Text;
                textBox18.Text = textBox19.Text;

                if (total2 == 1) textBox10.Visible = false;
                if (total2 == 2) textBox11.Visible = false;
                if (total2 == 3) textBox12.Visible = false;
                if (total2 == 4) textBox13.Visible = false;
                if (total2 == 5) textBox14.Visible = false;
                if (total2 == 6) textBox15.Visible = false;
                if (total2 == 7) textBox16.Visible = false;
                if (total2 == 8) textBox17.Visible = false;
                if (total2 == 9) textBox18.Visible = false;
                if (total2 == 10) textBox19.Visible = false;
                total2--;
                textBox20.Text = Convert.ToString(total2);
            }
            }
        }
    }

