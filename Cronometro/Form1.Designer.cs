namespace Cronometro
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
            components = new System.ComponentModel.Container();
            labCronometro = new Label();
            tmrCronometro = new System.Windows.Forms.Timer(components);
            butIniciar = new Button();
            butReiniciar = new Button();
            butPausar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labCronometro
            // 
            labCronometro.AutoSize = true;
            labCronometro.BackColor = SystemColors.Control;
            labCronometro.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labCronometro.Location = new Point(4, 15);
            labCronometro.Name = "labCronometro";
            labCronometro.Size = new Size(147, 36);
            labCronometro.TabIndex = 0;
            labCronometro.Text = "00:00:00";
            labCronometro.Click += labCronometro_Click;
            // 
            // tmrCronometro
            // 
            tmrCronometro.Interval = 1000;
            tmrCronometro.Tick += tmrCronometro_Tick;
            // 
            // butIniciar
            // 
            butIniciar.Image = Properties.Resources.inicio;
            butIniciar.Location = new Point(83, 304);
            butIniciar.Name = "butIniciar";
            butIniciar.Size = new Size(42, 42);
            butIniciar.TabIndex = 1;
            butIniciar.UseVisualStyleBackColor = true;
            butIniciar.Click += butIniciar_Click;
            // 
            // butReiniciar
            // 
            butReiniciar.Image = Properties.Resources.Reiniciar;
            butReiniciar.Location = new Point(231, 304);
            butReiniciar.Name = "butReiniciar";
            butReiniciar.Size = new Size(42, 42);
            butReiniciar.TabIndex = 2;
            butReiniciar.Text = "Reiniciar";
            butReiniciar.UseVisualStyleBackColor = true;
            butReiniciar.Click += butReiniciar_Click;
            // 
            // butPausar
            // 
            butPausar.Image = Properties.Resources.Detener;
            butPausar.Location = new Point(157, 304);
            butPausar.Name = "butPausar";
            butPausar.Size = new Size(42, 42);
            butPausar.TabIndex = 3;
            butPausar.UseVisualStyleBackColor = true;
            butPausar.Click += butPausar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(labCronometro);
            panel1.Location = new Point(100, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 65);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.crono;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 356);
            Controls.Add(panel1);
            Controls.Add(butPausar);
            Controls.Add(butReiniciar);
            Controls.Add(butIniciar);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labCronometro;
        private System.Windows.Forms.Timer tmrCronometro;
        private Button butIniciar;
        private Button butReiniciar;
        private Button butPausar;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
