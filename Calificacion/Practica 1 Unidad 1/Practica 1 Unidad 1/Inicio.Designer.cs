namespace Practica_1_Unidad_1
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.primer = new System.Windows.Forms.TextBox();
            this.segundo = new System.Windows.Forms.TextBox();
            this.tercero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.examen = new System.Windows.Forms.TextBox();
            this.trabajo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Resetear = new System.Windows.Forms.Button();
            this.Adios = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.TextBox();
            this.beca = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calcular.Location = new System.Drawing.Point(393, 188);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(106, 41);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa Primer Parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresa Segundo Parcial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresa Tercero Parcial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(431, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Examen Final:";
            // 
            // primer
            // 
            this.primer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.primer.Location = new System.Drawing.Point(267, 64);
            this.primer.Name = "primer";
            this.primer.Size = new System.Drawing.Size(98, 36);
            this.primer.TabIndex = 4;
            this.primer.TextChanged += new System.EventHandler(this.primer_TextChanged);
            this.primer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primer_KeyPress);
            // 
            // segundo
            // 
            this.segundo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.segundo.Location = new System.Drawing.Point(267, 127);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(98, 36);
            this.segundo.TabIndex = 5;
            this.segundo.TextChanged += new System.EventHandler(this.segundo_TextChanged);
            this.segundo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.segundo_KeyPress);
            // 
            // tercero
            // 
            this.tercero.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tercero.Location = new System.Drawing.Point(267, 187);
            this.tercero.Name = "tercero";
            this.tercero.Size = new System.Drawing.Size(98, 36);
            this.tercero.TabIndex = 6;
            this.tercero.TextChanged += new System.EventHandler(this.tercero_TextChanged);
            this.tercero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tercero_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(431, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Trabajo Final:";
            // 
            // examen
            // 
            this.examen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examen.Location = new System.Drawing.Point(580, 64);
            this.examen.Name = "examen";
            this.examen.Size = new System.Drawing.Size(98, 36);
            this.examen.TabIndex = 9;
            this.examen.TextChanged += new System.EventHandler(this.examen_TextChanged);
            this.examen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.examen_KeyPress);
            // 
            // trabajo
            // 
            this.trabajo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trabajo.Location = new System.Drawing.Point(580, 127);
            this.trabajo.Name = "trabajo";
            this.trabajo.Size = new System.Drawing.Size(98, 36);
            this.trabajo.TabIndex = 10;
            this.trabajo.TextChanged += new System.EventHandler(this.trabajo_TextChanged);
            this.trabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trabajo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Location = new System.Drawing.Point(234, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = ":Ingrese Calificacion:";
            // 
            // Resetear
            // 
            this.Resetear.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Resetear.Location = new System.Drawing.Point(505, 188);
            this.Resetear.Name = "Resetear";
            this.Resetear.Size = new System.Drawing.Size(117, 41);
            this.Resetear.TabIndex = 12;
            this.Resetear.Text = "Resetear";
            this.Resetear.UseVisualStyleBackColor = true;
            this.Resetear.Click += new System.EventHandler(this.Resetear_Click);
            // 
            // Adios
            // 
            this.Adios.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adios.Location = new System.Drawing.Point(628, 188);
            this.Adios.Name = "Adios";
            this.Adios.Size = new System.Drawing.Size(67, 41);
            this.Adios.TabIndex = 13;
            this.Adios.Text = "Salir";
            this.Adios.UseVisualStyleBackColor = true;
            this.Adios.Click += new System.EventHandler(this.Adios_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 30);
            this.label7.TabIndex = 14;
            this.label7.Text = "La Calificacion FInal Es:";
            // 
            // final
            // 
            this.final.Enabled = false;
            this.final.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.final.Location = new System.Drawing.Point(253, 275);
            this.final.Name = "final";
            this.final.ReadOnly = true;
            this.final.Size = new System.Drawing.Size(98, 36);
            this.final.TabIndex = 15;
            this.final.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // beca
            // 
            this.beca.AutoSize = true;
            this.beca.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.beca.Location = new System.Drawing.Point(406, 278);
            this.beca.Name = "beca";
            this.beca.Size = new System.Drawing.Size(31, 30);
            this.beca.TabIndex = 16;
            this.beca.Text = "   ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 339);
            this.Controls.Add(this.beca);
            this.Controls.Add(this.final);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Adios);
            this.Controls.Add(this.Resetear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trabajo);
            this.Controls.Add(this.examen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tercero);
            this.Controls.Add(this.segundo);
            this.Controls.Add(this.primer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Name = "Inicio";
            this.Text = "Validacion de Beca";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Calcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox primer;
        private TextBox segundo;
        private TextBox tercero;
        private Label label5;
        private TextBox examen;
        private TextBox trabajo;
        private Label label6;
        private Button Resetear;
        private Button Adios;
        private Label label7;
        private TextBox final;
        private Label beca;
        private ErrorProvider errorProvider1;
    }
}