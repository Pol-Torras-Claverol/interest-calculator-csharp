using System;
using System.Windows.Forms;

namespace CalculadoraInteresCompost
{
    public partial class Calculadora : Form
    {
        int temps = 0;
        double quantitat = 0;
        double interes = 0;


        FintechInvestment.Core.Investment cls = new FintechInvestment.Core.Investment();

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Quantitat_valors(object sender, EventArgs e)
        {
            if (!double.TryParse(txtQuantitat.Text, out quantitat))
            {
                txtQuantitat.Text = "";
                
            }
            else
            {
                txtQuantitat.Text = quantitat.ToString();
                
            }
        }

        private void Temps_Inversio(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTemps.Text, out temps))
            {
                txtTemps.Text = "";
                
            }
            else
            {
                txtTemps.Text = temps.ToString();

            }
        }

        private void InteresAnual(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInteres.Text, out interes))
            {
                txtInteres.Text = "";
                
            }
            else
            {
                txtInteres.Text = interes.ToString();
            }
        }

        private void Calcular(object sender, EventArgs e)
        {

            if(txtInteres.Text.Equals("") || txtQuantitat.Text.Equals("") || txtTemps.Text.Equals(""))
            {
                MessageBox.Show("Please enter all values");
            }
            else
            {
                double total = cls.total(interes, quantitat, temps);

                double earnings = cls.guany(total, quantitat);

                lblVal1.Text = total.ToString() + " €";
                lblVal2.Text = earnings.ToString() + " €";

            }
        }
    }
}
