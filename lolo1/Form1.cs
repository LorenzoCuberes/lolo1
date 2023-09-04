using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolo1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restar_Click(object sender, EventArgs e)
        {
            
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                resultado.Text = "" + (num1 - num2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa numeros papaaa");
            }
            this.Text = "Restaste";
        }

        private void Sumar_Click(object sender, EventArgs e)
        { 
            
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                resultado.Text = "" + (num1 + num2);
            }
            catch (Exception ex){
                MessageBox.Show("Ingresa numeros papaaa");
            }
            this.Text = "Sumaste";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Tocaste un boton escondido";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
            MessageBox.Show("Paraaaaaaa!");
        }
        public int Cont = 0;
        public int contador(int conta) {
            return conta = conta+1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            conta.Text = ""+contador(Cont);
            Cont += 1;
            if (Cont>5)
            {
                button2.Text = "Basta!!!";
            }
            else if (Cont > 4)
            {
                button2.Text = "Sos una muela";
            }
            else if (Cont > 3)
            {
                button2.Text = "Cortalaa";
            }
            else if (Cont > 2)
            {
                button2.Text = "Para un poco nene";
            }
            
        }
    }
}
