namespace PAS.Views
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            bienvenida = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-415, -280);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1551, 502);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new System.Drawing.Point(110, 348);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(252, 134);
            button1.TabIndex = 2;
            button1.Text = "Información empleados";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new System.Drawing.Point(403, 348);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(224, 134);
            button2.TabIndex = 3;
            button2.Text = "Descargar Información Empleado";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new System.Drawing.Point(678, 348);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(224, 134);
            button3.TabIndex = 4;
            button3.Text = "Habilitar Entrada o Salida";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // bienvenida
            // 
            bienvenida.AutoSize = true;
            bienvenida.BackColor = System.Drawing.Color.Transparent;
            bienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            bienvenida.ForeColor = System.Drawing.Color.White;
            bienvenida.Location = new System.Drawing.Point(393, 239);
            bienvenida.Name = "bienvenida";
            bienvenida.Size = new System.Drawing.Size(234, 54);
            bienvenida.TabIndex = 5;
            bienvenida.Text = "Bienvenido";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 65);
            ClientSize = new System.Drawing.Size(1000, 562);
            Controls.Add(bienvenida);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Inicio";
            Text = "Inicio";
            FormClosing += Inicio_FormClosing;
            FormClosed += Inicio_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label bienvenida;
    }
}