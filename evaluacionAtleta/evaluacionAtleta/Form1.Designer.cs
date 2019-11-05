namespace evaluacionAtleta
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudPes = new System.Windows.Forms.NumericUpDown();
            this.nudEst = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.btnEva = new System.Windows.Forms.Button();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edad";
            // 
            // nudPes
            // 
            this.nudPes.Location = new System.Drawing.Point(139, 219);
            this.nudPes.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudPes.Name = "nudPes";
            this.nudPes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudPes.Size = new System.Drawing.Size(120, 20);
            this.nudPes.TabIndex = 2;
            // 
            // nudEst
            // 
            this.nudEst.Location = new System.Drawing.Point(139, 189);
            this.nudEst.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudEst.Name = "nudEst";
            this.nudEst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nudEst.Size = new System.Drawing.Size(120, 20);
            this.nudEst.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexo";
            // 
            // dtpEdad
            // 
            this.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEdad.Location = new System.Drawing.Point(139, 154);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(120, 20);
            this.dtpEdad.TabIndex = 4;
            this.dtpEdad.ValueChanged += new System.EventHandler(this.dtpEdad_ValueChanged);
            // 
            // btnEva
            // 
            this.btnEva.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEva.Location = new System.Drawing.Point(26, 268);
            this.btnEva.Name = "btnEva";
            this.btnEva.Size = new System.Drawing.Size(233, 23);
            this.btnEva.TabIndex = 5;
            this.btnEva.Text = "Evaluar Atleta";
            this.btnEva.UseVisualStyleBackColor = false;
            this.btnEva.Click += new System.EventHandler(this.btnEva_Click);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(139, 124);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 6;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(190, 124);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(31, 17);
            this.rbF.TabIndex = 6;
            this.rbF.Text = "F";
            this.rbF.UseVisualStyleBackColor = true;
            this.rbF.CheckedChanged += new System.EventHandler(this.rbF_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::evaluacionAtleta.Properties.Resources.builder_26_icon_icons_com_60364;
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(292, 309);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbF);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.btnEva);
            this.Controls.Add(this.dtpEdad);
            this.Controls.Add(this.nudEst);
            this.Controls.Add(this.nudPes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "IPD - Atletas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPes;
        private System.Windows.Forms.NumericUpDown nudEst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEdad;
        private System.Windows.Forms.Button btnEva;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

