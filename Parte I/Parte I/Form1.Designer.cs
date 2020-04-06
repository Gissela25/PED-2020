namespace Parte_I
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.RadioButton();
            this.ino = new System.Windows.Forms.RadioButton();
            this.pre = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfundidadNodo = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblProfundidad = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.post);
            this.panel3.Controls.Add(this.ino);
            this.panel3.Controls.Add(this.pre);
            this.panel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(15, 856);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 336);
            this.panel3.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(458, 35);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // post
            // 
            this.post.AutoSize = true;
            this.post.Location = new System.Drawing.Point(183, 159);
            this.post.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(168, 34);
            this.post.TabIndex = 2;
            this.post.TabStop = true;
            this.post.Text = "Post Orden";
            this.post.UseVisualStyleBackColor = true;
            this.post.CheckedChanged += new System.EventHandler(this.post_CheckedChanged);
            // 
            // ino
            // 
            this.ino.AutoSize = true;
            this.ino.Location = new System.Drawing.Point(185, 102);
            this.ino.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ino.Name = "ino";
            this.ino.Size = new System.Drawing.Size(143, 34);
            this.ino.TabIndex = 1;
            this.ino.TabStop = true;
            this.ino.Text = "En orden";
            this.ino.UseVisualStyleBackColor = true;
            this.ino.CheckedChanged += new System.EventHandler(this.ino_CheckedChanged);
            // 
            // pre
            // 
            this.pre.AutoSize = true;
            this.pre.Location = new System.Drawing.Point(185, 33);
            this.pre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(145, 34);
            this.pre.TabIndex = 0;
            this.pre.TabStop = true;
            this.pre.Text = "Preorden";
            this.pre.UseVisualStyleBackColor = true;
            this.pre.CheckedChanged += new System.EventHandler(this.pre_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProfundidadNodo);
            this.panel1.Controls.Add(this.valor);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.Ingresar);
            this.panel1.Controls.Add(this.eliminar);
            this.panel1.Controls.Add(this.buscar);
            this.panel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 501);
            this.panel1.TabIndex = 13;
            // 
            // btnProfundidadNodo
            // 
            this.btnProfundidadNodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProfundidadNodo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfundidadNodo.Location = new System.Drawing.Point(93, 369);
            this.btnProfundidadNodo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnProfundidadNodo.Name = "btnProfundidadNodo";
            this.btnProfundidadNodo.Size = new System.Drawing.Size(262, 87);
            this.btnProfundidadNodo.TabIndex = 5;
            this.btnProfundidadNodo.Text = "Profundidad de un nodo";
            this.btnProfundidadNodo.UseVisualStyleBackColor = false;
            this.btnProfundidadNodo.Click += new System.EventHandler(this.btnProfundidadNodo_Click);
            // 
            // valor
            // 
            this.valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.valor.Location = new System.Drawing.Point(93, 33);
            this.valor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(256, 35);
            this.valor.TabIndex = 1;
            this.valor.TextChanged += new System.EventHandler(this.valor_TextChanged);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(129, 300);
            this.salir.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(174, 54);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Ingresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar.Location = new System.Drawing.Point(93, 94);
            this.Ingresar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(262, 54);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Agregar Dato";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.eliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar.Location = new System.Drawing.Point(129, 231);
            this.eliminar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(174, 54);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Eliminar Dato";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(129, 162);
            this.buscar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(174, 54);
            this.buscar.TabIndex = 2;
            this.buscar.Text = "Buscar Dato";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNumero);
            this.panel2.Controls.Add(this.lblProfundidad);
            this.panel2.Controls.Add(this.lblSuma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblaltura);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 548);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 287);
            this.panel2.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(346, 158);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(19, 25);
            this.lblNumero.TabIndex = 28;
            this.lblNumero.Text = "-";
            // 
            // lblProfundidad
            // 
            this.lblProfundidad.AutoSize = true;
            this.lblProfundidad.Location = new System.Drawing.Point(344, 210);
            this.lblProfundidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProfundidad.Name = "lblProfundidad";
            this.lblProfundidad.Size = new System.Drawing.Size(19, 25);
            this.lblProfundidad.TabIndex = 27;
            this.lblProfundidad.Text = "-";
            this.lblProfundidad.Click += new System.EventHandler(this.lblProfundidad_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(344, 104);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(19, 25);
            this.lblSuma.TabIndex = 26;
            this.lblSuma.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Profundidad del nodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Número de nodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Suma de los nodos";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(344, 52);
            this.lblaltura.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(23, 30);
            this.lblaltura.TabIndex = 22;
            this.lblaltura.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Altura de arbol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1782, 1256);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton post;
        private System.Windows.Forms.RadioButton ino;
        private System.Windows.Forms.RadioButton pre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfundidadNodo;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblProfundidad;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label label1;
    }
}

