using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio9
{
    public partial class Ejercicio9 : Form
    {
        public Random random = new Random();
        private int[] array = new int[6];
        private List<int> caja_1 = new List<int>();
        
        public Ejercicio9()
        {
            InitializeComponent();
            
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void conteo (List<int> lista)
        {
            int[] repeticiones = new int[6];
            for( int i = 1; i < repeticiones.Length+1; i++)
            {
                repeticiones[i-1] = lista.Count(n => n == i);
            }

            float[] porcentaje = new float[6];

            for (int i = 0; i < 6; i++)
            {
                porcentaje[i] = (repeticiones[i] * 100.0f) / lista.Count+1;
            }
            
            LBR_1.Text = $"Nº 1 = {repeticiones[0]} = %{repeticiones[0]:0.00}";
            LBR_2.Text = $"Nº 2 = {repeticiones[1]} = %{repeticiones[1]:0.00}";
            LBR_3.Text = $"Nº 3 = {repeticiones[2]} = %{repeticiones[2]:0.00}";
            LBR_4.Text = $"Nº 4 = {repeticiones[3]} = %{repeticiones[3]:0.00}";
            LBR_5.Text = $"Nº 5 = {repeticiones[4]} = %{repeticiones[4]:0.00}";
            LBR_6.Text = $"Nº 6 = {repeticiones[5]} = %{repeticiones[5]:0.00}";

        }

        private void BTN_Tirar_Click(object sender, EventArgs e)
        {
            int num = random.Next(1,7);
            
            switch(num)
            {
                case 1:
                    TX_DADO_1.Text = "*";
                    
                    break;
                case 2:
                    TX_DADO_1.Text = "**";
                    
                    break;
                case 3:
                    TX_DADO_1.Text = "***";
                    break;
                case 4:
                    TX_DADO_1.Text = "****";
                    break;
                case 5:
                    TX_DADO_1.Text = "*****";
                    break;
                case 6:
                    TX_DADO_1.Text = "******";
                    break;
            }
            caja_1.Add(num);
            num = random.Next(1, 7);

            switch (num)
            {
                case 1:
                    TX_DADO_2.Text = "*";
                    break;
                case 2:
                    TX_DADO_2.Text = "**";
                    break;
                case 3:
                    TX_DADO_2.Text = "***";
                    break;
                case 4:
                    TX_DADO_2.Text = "****";
                    break;
                case 5:
                    TX_DADO_2.Text = "*****";
                    break;
                case 6:
                    TX_DADO_2.Text = "******";
                    break;
            }
            caja_1.Add(num);
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Resultado_Click(object sender, EventArgs e)
        {
            conteo(caja_1);
        }
    }
}
