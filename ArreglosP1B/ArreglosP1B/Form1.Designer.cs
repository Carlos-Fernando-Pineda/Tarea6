
namespace ArreglosP1B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.buttonOrdNombres = new System.Windows.Forms.Button();
            this.buttonProm = new System.Windows.Forms.Button();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.textBoxP3 = new System.Windows.Forms.TextBox();
            this.buttonMayor = new System.Windows.Forms.Button();
            this.buttonMenor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(316, 2);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(75, 23);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            this.buttonArreglo.Click += new System.EventHandler(this.buttonArreglo_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(316, 31);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(352, 154);
            this.listBoxResultado.TabIndex = 1;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(2, 2);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(75, 23);
            this.buttonCargar.TabIndex = 2;
            this.buttonCargar.Text = "Cargar Archivo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(2, 31);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContenido.Size = new System.Drawing.Size(278, 155);
            this.textBoxContenido.TabIndex = 3;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(593, 2);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(75, 23);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(593, 191);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdenar.TabIndex = 7;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // buttonOrdNombres
            // 
            this.buttonOrdNombres.Location = new System.Drawing.Point(461, 2);
            this.buttonOrdNombres.Name = "buttonOrdNombres";
            this.buttonOrdNombres.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdNombres.TabIndex = 8;
            this.buttonOrdNombres.Text = "OrdenarN";
            this.buttonOrdNombres.UseVisualStyleBackColor = true;
            this.buttonOrdNombres.Click += new System.EventHandler(this.buttonOrdNombres_Click);
            // 
            // buttonProm
            // 
            this.buttonProm.Location = new System.Drawing.Point(300, 345);
            this.buttonProm.Name = "buttonProm";
            this.buttonProm.Size = new System.Drawing.Size(75, 23);
            this.buttonProm.TabIndex = 9;
            this.buttonProm.Text = "Promedio";
            this.buttonProm.UseVisualStyleBackColor = true;
            this.buttonProm.Click += new System.EventHandler(this.buttonProm_Click);
            // 
            // textBoxP1
            // 
            this.textBoxP1.Location = new System.Drawing.Point(180, 316);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(100, 23);
            this.textBoxP1.TabIndex = 10;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Location = new System.Drawing.Point(286, 316);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(100, 23);
            this.textBoxP2.TabIndex = 11;
            // 
            // textBoxP3
            // 
            this.textBoxP3.Location = new System.Drawing.Point(392, 316);
            this.textBoxP3.Name = "textBoxP3";
            this.textBoxP3.Size = new System.Drawing.Size(100, 23);
            this.textBoxP3.TabIndex = 12;
            // 
            // buttonMayor
            // 
            this.buttonMayor.Location = new System.Drawing.Point(205, 345);
            this.buttonMayor.Name = "buttonMayor";
            this.buttonMayor.Size = new System.Drawing.Size(75, 23);
            this.buttonMayor.TabIndex = 13;
            this.buttonMayor.Text = "Mayor";
            this.buttonMayor.UseVisualStyleBackColor = true;
            this.buttonMayor.Click += new System.EventHandler(this.buttonMayor_Click);
            // 
            // buttonMenor
            // 
            this.buttonMenor.Location = new System.Drawing.Point(392, 345);
            this.buttonMenor.Name = "buttonMenor";
            this.buttonMenor.Size = new System.Drawing.Size(75, 23);
            this.buttonMenor.TabIndex = 14;
            this.buttonMenor.Text = "Menor";
            this.buttonMenor.UseVisualStyleBackColor = true;
            this.buttonMenor.Click += new System.EventHandler(this.buttonMenor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Primer Parcial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Segundo Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tercer Parcial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMenor);
            this.Controls.Add(this.buttonMayor);
            this.Controls.Add(this.textBoxP3);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.buttonProm);
            this.Controls.Add(this.buttonOrdNombres);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.textBoxContenido);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Button buttonOrdNombres;
        private System.Windows.Forms.Button buttonProm;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxP2;
        private System.Windows.Forms.TextBox textBoxP3;
        private System.Windows.Forms.Button buttonMayor;
        private System.Windows.Forms.Button buttonMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

