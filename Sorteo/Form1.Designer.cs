namespace Sorteo
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
            this.nombresListBox = new System.Windows.Forms.ListBox();
            this.anadirNombrestextBox = new System.Windows.Forms.TextBox();
            this.anadirButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.suerteButton = new System.Windows.Forms.Button();
            this.afortunadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombresListBox
            // 
            this.nombresListBox.FormattingEnabled = true;
            this.nombresListBox.Location = new System.Drawing.Point(12, 23);
            this.nombresListBox.Name = "nombresListBox";
            this.nombresListBox.Size = new System.Drawing.Size(233, 95);
            this.nombresListBox.TabIndex = 0;
            // 
            // anadirNombrestextBox
            // 
            this.anadirNombrestextBox.Location = new System.Drawing.Point(24, 136);
            this.anadirNombrestextBox.Name = "anadirNombrestextBox";
            this.anadirNombrestextBox.Size = new System.Drawing.Size(100, 20);
            this.anadirNombrestextBox.TabIndex = 1;
            // 
            // anadirButton
            // 
            this.anadirButton.Location = new System.Drawing.Point(160, 134);
            this.anadirButton.Name = "anadirButton";
            this.anadirButton.Size = new System.Drawing.Size(75, 23);
            this.anadirButton.TabIndex = 2;
            this.anadirButton.Text = "Añadir";
            this.anadirButton.UseVisualStyleBackColor = true;
            this.anadirButton.Click += new System.EventHandler(this.añadirButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(265, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Borrar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // suerteButton
            // 
            this.suerteButton.Location = new System.Drawing.Point(265, 53);
            this.suerteButton.Name = "suerteButton";
            this.suerteButton.Size = new System.Drawing.Size(75, 23);
            this.suerteButton.TabIndex = 4;
            this.suerteButton.Text = "Suette!";
            this.suerteButton.UseVisualStyleBackColor = true;
            this.suerteButton.Click += new System.EventHandler(this.suerteButton_Click);
            // 
            // afortunadoLabel
            // 
            this.afortunadoLabel.AutoSize = true;
            this.afortunadoLabel.Location = new System.Drawing.Point(285, 120);
            this.afortunadoLabel.Name = "afortunadoLabel";
            this.afortunadoLabel.Size = new System.Drawing.Size(102, 13);
            this.afortunadoLabel.TabIndex = 5;
            this.afortunadoLabel.Text = "Y el afortunado es...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 188);
            this.Controls.Add(this.afortunadoLabel);
            this.Controls.Add(this.suerteButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.anadirButton);
            this.Controls.Add(this.anadirNombrestextBox);
            this.Controls.Add(this.nombresListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sorteo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nombresListBox;
        private System.Windows.Forms.TextBox anadirNombrestextBox;
        private System.Windows.Forms.Button anadirButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button suerteButton;
        private System.Windows.Forms.Label afortunadoLabel;
    }
}

