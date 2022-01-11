using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ruleta
{
    public partial class Ruletaprg : Form
    {
        public Ruletaprg()
        {
            InitializeComponent();
        }
        double pocatecnikapital;
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (pocatecnikapital >= 100)
            {
                label15.Text = "";
                textBox2.Clear();
                label13.Text = "";
                string barva;
                Random rnd = new Random();
                int cislo = rnd.Next(0, 37);
                if (cislo == 0)
                {
                    barva = "Zelená";
                }
                else
                {
                    if (cislo % 2 == 0 && cislo != 0) barva = "Červená";
                    else barva = "Černá";
                }
                if (radioButton1.Checked == true && barva == "Černá")
                {
                    pocatecnikapital += 200;
                    label13.Text = "200Kč";
                }
                if (radioButton2.Checked == true && barva == "Červená")
                {
                    pocatecnikapital += 200;
                    label13.Text = "200Kč";
                }
                if (radioButton3.Checked == true && barva == "Zelená")
                {
                    pocatecnikapital += 500;
                    label13.Text = "500Kč";
                }
                if (textBox1.Text != "")
                {
                    try
                    {
                        if (cislo == Convert.ToInt32(textBox1.Text))
                        {
                            pocatecnikapital += 3500;
                            label15.Text = "3500Kč";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Zadal jsi něco co jsi zřejmě neměl", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                label6.Text = Convert.ToString(cislo);
                label7.Text = barva;
                pocatecnikapital -= 100;
            }
            else
            {
                label6.Text = "Už nemůžeš sázet dál nemáš dostatek peněz";
                label7.Text = "Už nemůžeš sázet dál nemáš dostatek peněz";
                label13.Text = "Už nemůžeš sázet dál nemáš dostatek peněz";
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            pocatecnikapital = Convert.ToInt32(textBox2.Text);
            label12.Text = pocatecnikapital + "Kč";
        }
        private void label6_TextChanged(object sender, EventArgs e)
        {
            label12.Text = pocatecnikapital + "Kč";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ruleta obsahuje 36 náhoně generovaných čísel, když trefíte barvu černou nebo červenou dostane za sázku 100Kč krásných 200Kč, pokud trefíte barvu zelenou vyhráváte 500Kč, poté zde můžete hádat i samotné číslo, které když trefíte dostane 3500Kč, ovšem je zde i možnost že úplně příjdete o své peníze. Takže doufám, že si ruletu užijete a vyhrajete co nejvíce peněz.😎", "Informace o Ruletě", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
