using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeLanches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            double dinheiro = double.Parse(txtDepositar.Text);

            if (dinheiro < 0)
            {
                return;
            }

            double saldo = double.Parse(lblValorMonetario.Text);
            double soma = dinheiro + saldo;
            lblValorMonetario.Text = $"{soma}";

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnBolinho_Click(object sender, EventArgs e)
        {
            btnAgua.BackColor = Color.Gainsboro;
            btnAgua.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.Gainsboro;
            btnRefrigerante.ForeColor = Color.Black;

            btnSuco.BackColor = Color.Gainsboro;
            btnSuco.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.Gainsboro;
            btnSalgadinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.Gainsboro;
            btnEnergetico.ForeColor = Color.Black;

            btnBolinho.BackColor = Color.LightBlue;
            btnBolinho.ForeColor = Color.DodgerBlue;
        }

        private void btnAgua_Click(object sender, EventArgs e)
        {
            btnBolinho.BackColor = Color.Gainsboro;
            btnBolinho.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.Gainsboro;
            btnRefrigerante.ForeColor = Color.Black;

            btnSuco.BackColor = Color.Gainsboro;
            btnSuco.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.Gainsboro;
            btnSalgadinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.Gainsboro;
            btnEnergetico.ForeColor = Color.Black;

            btnAgua.BackColor = Color.LightBlue;
            btnAgua.ForeColor = Color.DodgerBlue;
        }

        private void btnRefrigerante_Click(object sender, EventArgs e)
        {
            btnAgua.BackColor = Color.Gainsboro;
            btnAgua.ForeColor = Color.Black;

            btnBolinho.BackColor = Color.Gainsboro;
            btnBolinho.ForeColor = Color.Black;

            btnSuco.BackColor = Color.Gainsboro;
            btnSuco.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.Gainsboro;
            btnSalgadinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.Gainsboro;
            btnEnergetico.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.LightBlue;
            btnRefrigerante.ForeColor = Color.DodgerBlue;
        }

        private void btnSuco_Click(object sender, EventArgs e)
        {
            btnAgua.BackColor = Color.Gainsboro;
            btnAgua.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.Gainsboro;
            btnRefrigerante.ForeColor = Color.Black;

            btnBolinho.BackColor = Color.Gainsboro;
            btnBolinho.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.Gainsboro;
            btnSalgadinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.Gainsboro;
            btnEnergetico.ForeColor = Color.Black;

            btnSuco.BackColor = Color.LightBlue;
            btnSuco.ForeColor = Color.DodgerBlue;
        }

        private void btnSalgadinho_Click(object sender, EventArgs e)
        {
            btnAgua.BackColor = Color.Gainsboro;
            btnAgua.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.Gainsboro;
            btnRefrigerante.ForeColor = Color.Black;

            btnSuco.BackColor = Color.Gainsboro;
            btnSuco.ForeColor = Color.Black;

            btnBolinho.BackColor = Color.Gainsboro;
            btnBolinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.Gainsboro;
            btnEnergetico.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.LightBlue;
            btnSalgadinho.ForeColor = Color.DodgerBlue;
        }

        private void btnEnergetico_Click(object sender, EventArgs e)
        {
            btnAgua.BackColor = Color.Gainsboro;
            btnAgua.ForeColor = Color.Black;

            btnRefrigerante.BackColor = Color.Gainsboro;
            btnRefrigerante.ForeColor = Color.Black;

            btnSuco.BackColor = Color.Gainsboro;
            btnSuco.ForeColor = Color.Black;

            btnSalgadinho.BackColor = Color.Gainsboro;
            btnSalgadinho.ForeColor = Color.Black;

            btnBolinho.BackColor = Color.Gainsboro;
            btnBolinho.ForeColor = Color.Black;

            btnEnergetico.BackColor = Color.LightBlue;
            btnEnergetico.ForeColor = Color.DodgerBlue;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //bolinho
            if(btnBolinho.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro == 0 || dinheiro <= 3.4)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double bolinho = 3.5;
                double conta = dinheiro - bolinho;
                MessageBox.Show("Você comprou o bolinho!");
                lblValorMonetario.Text = $"{conta}";

            }

            //agua
            if (btnAgua.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro <= 1.4)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double agua = 1.5;
                double conta = dinheiro - agua;
                MessageBox.Show("Você comprou a agua!");
                lblValorMonetario.Text = $"{conta}";

            }

            //Refri
            if (btnRefrigerante.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro < 3)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double bolinho = 3;
                double conta = dinheiro - bolinho;
                MessageBox.Show("Você comprou o refrigerante!");
                lblValorMonetario.Text = $"{conta}";

            }

            //suco
            if (btnSuco.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro < 2)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double bolinho = 2;
                double conta = dinheiro - bolinho;
                MessageBox.Show("Você comprou o Suco!");
                lblValorMonetario.Text = $"{conta}";

            }

            //salgadinho
            if (btnSalgadinho.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro < 4)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double bolinho = 4;
                double conta = dinheiro - bolinho;
                MessageBox.Show("Você comprou o Salgadinho!");
                lblValorMonetario.Text = $"{conta}";

            }

            //energetico
            if (btnEnergetico.BackColor == Color.LightBlue)
            {
                double dinheiro = double.Parse(lblValorMonetario.Text);

                if (dinheiro < 3)
                {
                    MessageBox.Show("Sem saldo suficiente");
                    return;
                }

                double bolinho = 3;
                double conta = dinheiro - bolinho;
                MessageBox.Show("Você comprou o energetico!");
                lblValorMonetario.Text = $"{conta}";

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
