namespace Ejemplo01
{
    partial class Form1
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.solicitarButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(67, 35);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 1;
            // 
            // solicitarButton
            // 
            this.solicitarButton.Location = new System.Drawing.Point(247, 33);
            this.solicitarButton.Name = "solicitarButton";
            this.solicitarButton.Size = new System.Drawing.Size(95, 23);
            this.solicitarButton.TabIndex = 2;
            this.solicitarButton.Text = "Solicitar";
            this.solicitarButton.UseVisualStyleBackColor = true;
            this.solicitarButton.Click += new System.EventHandler(this.solicitarButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(64, 78);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(98, 13);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "A ver si lo adivinas!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 110);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.solicitarButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Adivínalo, co";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button solicitarButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

