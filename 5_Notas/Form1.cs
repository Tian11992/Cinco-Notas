using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4, nota5,promedio;
            

            nota1 = Convert.ToDouble(txtnota1.Text);

            nota2 = Convert.ToDouble(txtnota2.Text);

            nota3 = Convert.ToDouble(txtnota3.Text);

            nota4 = Convert.ToDouble(txtnota4.Text);

            nota5 = Convert.ToDouble(txtnota5.Text);

            promedio = ((nota1 + nota2 + nota3 + nota4 + nota5)/5);

            lblresultado.Text = "Su promedio es: "+promedio;

            if(promedio >= 3.5)
            {
                MessageBox.Show("Aprobado");
            }
            else
            {
                MessageBox.Show("Reprobado");
            }

        }
        
}
}
