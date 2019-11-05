using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacionAtleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void btnEva_Click(object sender, EventArgs e)
        {
            decimal estatura = nudEst.Value;
            decimal peso = nudPes.Value;

            DateTime oldDate = dtpEdad.Value;
            DateTime newDate = DateTime.Now;
            TimeSpan ts = newDate - oldDate;
            int differenceInDays = ts.Days;
            double edad = differenceInDays / 365;

            if (rbM.Checked==false && rbF.Checked==false)
            {  
                MessageBox.Show("Debe seleccionar un sexo");
            }
            else if (rbM.Checked==true) //si es hombre, sea mayor de edad, mida mas de 1.70 y pese menos de 70 kg. 
            {
                if (edad < 18)
                {
                    MessageBox.Show("El atleta debe ser mayor de edad");
                }
                else if (estatura<= Decimal.Parse("1.70"))
                {
                    MessageBox.Show("El atleta debe medir mas de 1.70");
                }
                else if (peso >= Decimal.Parse("70.00"))
                {
                    MessageBox.Show("El atleta debe pesar menos de 70 kg");
                }
                else
                {
                    MessageBox.Show("El atleta ha sido aceptado");
                }


            }
            else if (rbF.Checked == true) //Si es mujer que tenga más de 16 años, mida como mínimo 1.70 y pese como máximo 60 kg.
            {
                if (edad < 16)
                {
                    MessageBox.Show("La atleta debe ser mayor de 16 años");
                }
                else if (estatura < Decimal.Parse("1.70"))
                {
                    MessageBox.Show("La atleta debe medir mas de 1.70");
                }
                else if (peso <= Decimal.Parse("60.00"))
                {
                    MessageBox.Show("La atleta debe pesar máximo 60 kg");
                }
                else
                {
                    MessageBox.Show("La atleta ha sido aceptada");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudEst.DecimalPlaces = 2;
            nudPes.DecimalPlaces = 2;
            nudEst.Increment = 0.10M;
            nudPes.Increment = 0.10M;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbM.Checked) rbF.Checked=false;
        }

        private void rbF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbF.Checked) rbM.Checked = false;
        }

        private void dtpEdad_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEdad.Value > DateTime.Now)
            {
                dtpEdad.Value = DateTime.Now;
            }
        }
    }
}
