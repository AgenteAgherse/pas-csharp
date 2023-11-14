using System.Drawing;
namespace PAS.Views
{
    partial class Informacion_empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informacion_empleado));
            identificacion = new TextBox();
            nombre = new TextBox();
            direccion = new TextBox();
            apellido = new TextBox();
            telefono = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label10 = new Label();
            Genero = new ComboBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            huella = new Button();
            label7 = new Label();
            label8 = new Label();
            inicio_contrato = new DateTimePicker();
            final = new DateTimePicker();
            label9 = new Label();
            acciones = new ComboBox();
            definir_accion = new Button();
            label11 = new Label();
            correo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // identificacion
            // 
            identificacion.Location = new System.Drawing.Point(244, 228);
            identificacion.Margin = new Padding(4);
            identificacion.Name = "identificacion";
            identificacion.Size = new System.Drawing.Size(155, 31);
            identificacion.TabIndex = 3;
            // 
            // nombre
            // 
            nombre.Location = new System.Drawing.Point(244, 275);
            nombre.Margin = new Padding(4);
            nombre.Name = "nombre";
            nombre.Size = new System.Drawing.Size(155, 31);
            nombre.TabIndex = 4;
            // 
            // direccion
            // 
            direccion.Location = new System.Drawing.Point(244, 357);
            direccion.Margin = new Padding(4);
            direccion.Name = "direccion";
            direccion.Size = new System.Drawing.Size(155, 31);
            direccion.TabIndex = 6;
            // 
            // apellido
            // 
            apellido.Location = new System.Drawing.Point(244, 316);
            apellido.Margin = new Padding(4);
            apellido.Name = "apellido";
            apellido.Size = new System.Drawing.Size(155, 31);
            apellido.TabIndex = 7;
            // 
            // telefono
            // 
            telefono.Location = new System.Drawing.Point(644, 228);
            telefono.Margin = new Padding(4);
            telefono.Name = "telefono";
            telefono.Size = new System.Drawing.Size(155, 31);
            telefono.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(88, 228);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 25);
            label1.TabIndex = 13;
            label1.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(88, 275);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 25);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(88, 316);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 25);
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(88, 357);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 25);
            label4.TabIndex = 16;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(549, 228);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 25);
            label5.TabIndex = 17;
            label5.Text = "Telefono";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(44, 485);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 36);
            button1.TabIndex = 23;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new System.Drawing.Point(559, 281);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(69, 25);
            label10.TabIndex = 28;
            label10.Text = "Género";
            // 
            // Genero
            // 
            Genero.FormattingEnabled = true;
            Genero.Location = new System.Drawing.Point(644, 278);
            Genero.Name = "Genero";
            Genero.Size = new System.Drawing.Size(158, 33);
            Genero.TabIndex = 29;
            Genero.Text = "Seleccione";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(-252, -331);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(1569, 533);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new System.Drawing.Point(567, 333);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 25);
            label6.TabIndex = 30;
            label6.Text = "Huella";
            // 
            // huella
            // 
            huella.Location = new System.Drawing.Point(668, 327);
            huella.Margin = new Padding(4);
            huella.Name = "huella";
            huella.Size = new System.Drawing.Size(118, 36);
            huella.TabIndex = 31;
            huella.Text = "Capturar";
            huella.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(499, 383);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(129, 25);
            label7.TabIndex = 32;
            label7.Text = "Inicio Contrato";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new System.Drawing.Point(518, 431);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(110, 25);
            label8.TabIndex = 33;
            label8.Text = "Fin Contrato";
            // 
            // inicio_contrato
            // 
            inicio_contrato.Location = new System.Drawing.Point(644, 383);
            inicio_contrato.Name = "inicio_contrato";
            inicio_contrato.Size = new System.Drawing.Size(300, 31);
            inicio_contrato.TabIndex = 34;
            // 
            // final
            // 
            final.Location = new System.Drawing.Point(644, 426);
            final.Name = "final";
            final.Size = new System.Drawing.Size(300, 31);
            final.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new System.Drawing.Point(445, 499);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(105, 25);
            label9.TabIndex = 36;
            label9.Text = "Tipo Acción";
            // 
            // acciones
            // 
            acciones.FormattingEnabled = true;
            acciones.Items.AddRange(new object[] { "Agregar", "Buscar", "Editar", "Eliminar" });
            acciones.Location = new System.Drawing.Point(568, 496);
            acciones.Name = "acciones";
            acciones.Size = new System.Drawing.Size(182, 33);
            acciones.TabIndex = 37;
            acciones.Text = "Seleccione...";
            acciones.SelectedIndexChanged += acciones_SelectedIndexChanged;
            // 
            // definir_accion
            // 
            definir_accion.Location = new System.Drawing.Point(787, 493);
            definir_accion.Margin = new Padding(4);
            definir_accion.Name = "definir_accion";
            definir_accion.Size = new System.Drawing.Size(118, 36);
            definir_accion.TabIndex = 38;
            definir_accion.Text = "Aceptar";
            definir_accion.UseVisualStyleBackColor = true;
            definir_accion.Click += definir_accion_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new System.Drawing.Point(100, 405);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(66, 25);
            label11.TabIndex = 39;
            label11.Text = "Correo";
            // 
            // correo
            // 
            correo.Location = new System.Drawing.Point(244, 405);
            correo.Margin = new Padding(4);
            correo.Name = "correo";
            correo.Size = new System.Drawing.Size(155, 31);
            correo.TabIndex = 40;
            // 
            // Informacion_empleado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 64);
            ClientSize = new System.Drawing.Size(1000, 562);
            Controls.Add(correo);
            Controls.Add(label11);
            Controls.Add(definir_accion);
            Controls.Add(acciones);
            Controls.Add(label9);
            Controls.Add(final);
            Controls.Add(inicio_contrato);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(huella);
            Controls.Add(label6);
            Controls.Add(Genero);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(telefono);
            Controls.Add(apellido);
            Controls.Add(direccion);
            Controls.Add(nombre);
            Controls.Add(identificacion);
            Controls.Add(pictureBox2);
            Margin = new Padding(4);
            Name = "Informacion_empleado";
            Text = "Informacion_empleado";
            FormClosing += Informacion_empleado_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private TextBox identificacion;
        private TextBox nombre;
        private TextBox direccion;
        private TextBox apellido;
        private TextBox telefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label10;
        private ComboBox Genero;
        private Label label6;
        private Button huella;
        private Label label7;
        private Label label8;
        private DateTimePicker inicio_contrato;
        private DateTimePicker final;
        private Label label9;
        private ComboBox acciones;
        private Button definir_accion;
        private Label label11;
        private TextBox correo;
    }
}