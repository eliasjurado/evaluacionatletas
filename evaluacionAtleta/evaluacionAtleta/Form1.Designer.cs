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
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.dtpEdad = new System.Windows.Forms.DateTimePicker();
            this.btnEva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEst)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edad";
            // 
            // nudPes
            // 
            this.nudPes.Location = new System.Drawing.Point(128, 117);
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
            this.nudEst.Location = new System.Drawing.Point(128, 87);
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
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexo";
            // 
            // cboSex
            // 
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cboSex.Location = new System.Drawing.Point(127, 19);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(121, 21);
            this.cboSex.TabIndex = 3;
            // 
            // dtpEdad
            // 
            this.dtpEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEdad.Location = new System.Drawing.Point(128, 52);
            this.dtpEdad.Name = "dtpEdad";
            this.dtpEdad.Size = new System.Drawing.Size(120, 20);
            this.dtpEdad.TabIndex = 4;
            // 
            // btnEva
            // 
            this.btnEva.Location = new System.Drawing.Point(95, 166);
            this.btnEva.Name = "btnEva";
            this.btnEva.Size = new System.Drawing.Size(103, 23);
            this.btnEva.TabIndex = 5;
            this.btnEva.Text = "Evaluar Atleta";
            this.btnEva.UseVisualStyleBackColor = true;
            this.btnEva.Click += new System.EventHandler(this.btnEva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 223);
            this.Controls.Add(this.btnEva);
            this.Controls.Add(this.dtpEdad);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.nudEst);
            this.Controls.Add(this.nudPes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Evaluación de atleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEst)).EndInit();
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
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DateTimePicker dtpEdad;
        private System.Windows.Forms.Button btnEva;
    }
}

