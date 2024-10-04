namespace VisualizadorDeImagem
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
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnCarregar = new Button();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1057, 688);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.Location = new Point(12, 40);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(112, 34);
            btnCarregar.TabIndex = 1;
            btnCarregar.Text = "Carregar";
            btnCarregar.UseVisualStyleBackColor = true;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(957, 40);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 2;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 837);
            Controls.Add(btnLimpar);
            Controls.Add(btnCarregar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "VisualizadorDeImagem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnCarregar;
        private Button btnLimpar;
    }
}
