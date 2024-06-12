namespace PAS.Views
{
    partial class RegistroEntradas
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
            mensajes = new TextBox();
            title = new Label();
            SuspendLayout();
            // 
            // mensajes
            // 
            mensajes.Location = new System.Drawing.Point(46, 101);
            mensajes.Multiline = true;
            mensajes.Name = "mensajes";
            mensajes.ReadOnly = true;
            mensajes.ScrollBars = ScrollBars.Vertical;
            mensajes.Size = new System.Drawing.Size(498, 326);
            mensajes.TabIndex = 0;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = System.Drawing.Color.White;
            title.Location = new System.Drawing.Point(81, 19);
            title.Name = "title";
            title.Size = new System.Drawing.Size(413, 65);
            title.TabIndex = 1;
            title.Text = "Mensaje Arduino";
            // 
            // RegistroEntradas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 65);
            ClientSize = new System.Drawing.Size(608, 450);
            Controls.Add(title);
            Controls.Add(mensajes);
            Name = "RegistroEntradas";
            Text = "EstadoHuella";
            FormClosing += EstadoHuella_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mensajes;
        private Label title;
    }
}