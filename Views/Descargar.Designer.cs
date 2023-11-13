namespace PAS.Views
{
    partial class Descargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descargar));
            pictureBox1 = new PictureBox();
            identificacion = new TextBox();
            label1 = new Label();
            Buscar = new Button();
            button2 = new Button();
            button3 = new Button();
            results = new DataGridView();
            label2 = new Label();
            nombres = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)results).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(-264, -292);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1834, 528);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // identificacion
            // 
            identificacion.Location = new System.Drawing.Point(332, 292);
            identificacion.Margin = new Padding(4);
            identificacion.Name = "identificacion";
            identificacion.Size = new System.Drawing.Size(396, 31);
            identificacion.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(13, 295);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingresa la identificacion del empleado";
            // 
            // Buscar
            // 
            Buscar.BackColor = SystemColors.ActiveCaption;
            Buscar.FlatStyle = FlatStyle.Popup;
            Buscar.ForeColor = SystemColors.ButtonHighlight;
            Buscar.Location = new System.Drawing.Point(748, 320);
            Buscar.Margin = new Padding(4);
            Buscar.Name = "Buscar";
            Buscar.Size = new System.Drawing.Size(118, 36);
            Buscar.TabIndex = 4;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new System.Drawing.Point(725, 645);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(118, 36);
            button2.TabIndex = 5;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.Green;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = System.Drawing.Color.White;
            button3.Location = new System.Drawing.Point(699, 503);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(167, 36);
            button3.TabIndex = 6;
            button3.Text = "Exportar y Enviar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // results
            // 
            results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            results.Location = new System.Drawing.Point(122, 407);
            results.Name = "results";
            results.RowHeadersWidth = 62;
            results.RowTemplate.Height = 33;
            results.Size = new System.Drawing.Size(520, 257);
            results.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(122, 351);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(202, 25);
            label2.TabIndex = 8;
            label2.Text = "Por Nombre y Apellidos";
            // 
            // nombres
            // 
            nombres.Location = new System.Drawing.Point(332, 348);
            nombres.Margin = new Padding(4);
            nombres.Name = "nombres";
            nombres.Size = new System.Drawing.Size(396, 31);
            nombres.TabIndex = 9;
            // 
            // Descargar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            ClientSize = new System.Drawing.Size(928, 694);
            Controls.Add(nombres);
            Controls.Add(label2);
            Controls.Add(results);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Buscar);
            Controls.Add(label1);
            Controls.Add(identificacion);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            Name = "Descargar";
            Text = "Descargar";
            FormClosing += Descargar_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)results).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox identificacion;
        private Label label1;
        private Button Buscar;
        private Button button2;
        private Button button3;
        private DataGridView results;
        private Label label2;
        private TextBox nombres;
    }
}