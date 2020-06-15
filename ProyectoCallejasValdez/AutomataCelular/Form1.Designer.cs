namespace AutomataCelular
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ramdom = new System.Windows.Forms.Button();
            this.Pausar = new System.Windows.Forms.Button();
            this.Iniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Generacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Save1 = new System.Windows.Forms.Button();
            this.Save2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Ramdom
            // 
            this.Ramdom.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ramdom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ramdom.Location = new System.Drawing.Point(598, 333);
            this.Ramdom.Margin = new System.Windows.Forms.Padding(4);
            this.Ramdom.Name = "Ramdom";
            this.Ramdom.Size = new System.Drawing.Size(168, 40);
            this.Ramdom.TabIndex = 0;
            this.Ramdom.Text = "Random";
            this.Ramdom.UseVisualStyleBackColor = true;
            this.Ramdom.Click += new System.EventHandler(this.button3_Click);
            // 
            // Pausar
            // 
            this.Pausar.Enabled = false;
            this.Pausar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pausar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pausar.Location = new System.Drawing.Point(598, 370);
            this.Pausar.Margin = new System.Windows.Forms.Padding(4);
            this.Pausar.Name = "Pausar";
            this.Pausar.Size = new System.Drawing.Size(168, 40);
            this.Pausar.TabIndex = 1;
            this.Pausar.Text = "Pausar";
            this.Pausar.UseVisualStyleBackColor = true;
            this.Pausar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Iniciar
            // 
            this.Iniciar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Iniciar.Location = new System.Drawing.Point(598, 406);
            this.Iniciar.Margin = new System.Windows.Forms.Padding(4);
            this.Iniciar.Name = "Iniciar";
            this.Iniciar.Size = new System.Drawing.Size(168, 40);
            this.Iniciar.TabIndex = 2;
            this.Iniciar.Text = "Iniciar";
            this.Iniciar.UseVisualStyleBackColor = true;
            this.Iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Generación:";
            // 
            // Generacion
            // 
            this.Generacion.AutoSize = true;
            this.Generacion.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generacion.Location = new System.Drawing.Point(131, 14);
            this.Generacion.Name = "Generacion";
            this.Generacion.Size = new System.Drawing.Size(25, 30);
            this.Generacion.TabIndex = 8;
            this.Generacion.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Célula: ";
            // 
            // Limpiar
            // 
            this.Limpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Limpiar.Location = new System.Drawing.Point(432, 431);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Save1
            // 
            this.Save1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save1.Location = new System.Drawing.Point(9, 460);
            this.Save1.Name = "Save1";
            this.Save1.Size = new System.Drawing.Size(80, 23);
            this.Save1.TabIndex = 4;
            this.Save1.Text = "Partida 1";
            this.Save1.UseVisualStyleBackColor = true;
            this.Save1.Click += new System.EventHandler(this.Save1_Click);
            // 
            // Save2
            // 
            this.Save2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Save2.Location = new System.Drawing.Point(95, 460);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(80, 23);
            this.Save2.TabIndex = 5;
            this.Save2.Text = "Partida 2";
            this.Save2.UseVisualStyleBackColor = true;
            this.Save2.Click += new System.EventHandler(this.Save2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(10, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(414, 414);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(779, 488);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.Save1);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ramdom);
            this.Controls.Add(this.Pausar);
            this.Controls.Add(this.Iniciar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of life";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ramdom;
        private System.Windows.Forms.Button Pausar;
        private System.Windows.Forms.Button Iniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Generacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Save1;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

