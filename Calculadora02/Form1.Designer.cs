namespace Calculadora01
{
    partial class Calculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.PantallaTxt = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.resultadoTxt = new System.Windows.Forms.Label();
            this.btnMemoria = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.operationTxt = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonComa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PantallaTxt
            // 
            this.PantallaTxt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PantallaTxt.Location = new System.Drawing.Point(12, 12);
            this.PantallaTxt.Name = "PantallaTxt";
            this.PantallaTxt.Size = new System.Drawing.Size(186, 20);
            this.PantallaTxt.TabIndex = 0;
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSumar.Location = new System.Drawing.Point(180, 79);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(31, 23);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRestar.Location = new System.Drawing.Point(180, 108);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(31, 23);
            this.btnRestar.TabIndex = 3;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMultiplicar.Location = new System.Drawing.Point(180, 138);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(31, 23);
            this.btnMultiplicar.TabIndex = 4;
            this.btnMultiplicar.Text = "x";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnDividir.Location = new System.Drawing.Point(180, 167);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(31, 23);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.AutoSize = true;
            this.resultadoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTxt.Location = new System.Drawing.Point(292, 229);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.Size = new System.Drawing.Size(0, 20);
            this.resultadoTxt.TabIndex = 6;
            // 
            // btnMemoria
            // 
            this.btnMemoria.BackColor = System.Drawing.Color.Cornsilk;
            this.btnMemoria.Location = new System.Drawing.Point(70, 37);
            this.btnMemoria.Name = "btnMemoria";
            this.btnMemoria.Size = new System.Drawing.Size(32, 30);
            this.btnMemoria.TabIndex = 8;
            this.btnMemoria.Text = "M";
            this.btnMemoria.UseVisualStyleBackColor = false;
            this.btnMemoria.Click += new System.EventHandler(this.btnMemoria_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(167, 236);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // operationTxt
            // 
            this.operationTxt.AutoSize = true;
            this.operationTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.operationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationTxt.Location = new System.Drawing.Point(135, 2);
            this.operationTxt.Name = "operationTxt";
            this.operationTxt.Size = new System.Drawing.Size(0, 31);
            this.operationTxt.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(34, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(71, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(108, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(34, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Cornsilk;
            this.button5.Location = new System.Drawing.Point(71, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(108, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(34, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Cornsilk;
            this.button8.Location = new System.Drawing.Point(71, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Cornsilk;
            this.button9.Location = new System.Drawing.Point(108, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(31, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEqual.Location = new System.Drawing.Point(180, 196);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(31, 23);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBorrar.Location = new System.Drawing.Point(18, 37);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(32, 30);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Cornsilk;
            this.button0.Location = new System.Drawing.Point(34, 211);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(31, 23);
            this.button0.TabIndex = 17;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // buttonComa
            // 
            this.buttonComa.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonComa.Location = new System.Drawing.Point(71, 211);
            this.buttonComa.Name = "buttonComa";
            this.buttonComa.Size = new System.Drawing.Size(31, 23);
            this.buttonComa.TabIndex = 18;
            this.buttonComa.Text = ",";
            this.buttonComa.UseVisualStyleBackColor = false;
            this.buttonComa.Click += new System.EventHandler(this.buttonnumero_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(243, 296);
            this.Controls.Add(this.buttonComa);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operationTxt);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMemoria);
            this.Controls.Add(this.resultadoTxt);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.PantallaTxt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            this.Text = "Calculadorcica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PantallaTxt;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Label resultadoTxt;
        private System.Windows.Forms.Button btnMemoria;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label operationTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonComa;
    }
}

