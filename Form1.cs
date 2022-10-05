using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSUWF2
{
    public partial class Form1 : Form
    {
        ABC[] ABCs;

        public Form1()
        {
            InitializeComponent();
            ABCs = new ABC[19];

            ABCs[0] = new ABC(2.681, -1.278, 0.454);
            ABCs[1] = new ABC(98.939, -85.038, 30.492);
            ABCs[2] = new ABC(0.930, 0.690, 0.000);
            ABCs[3] = new ABC(3.180, 0.886, -1.429);
            ABCs[4] = new ABC(30.975, -21.460, 7.701);
            ABCs[5] = new ABC(28.200, -48.857, 25.000);
            ABCs[6] = new ABC(48.200, -68.857, 32.143);
            ABCs[7] = new ABC(34.350, -53.179, 25.893);
            ABCs[8] = new ABC(3.228, -1.216, 0.439);
            ABCs[9] = new ABC(0.760, 0.440, 0.000);
            ABCs[10] = new ABC(4.700, -1.700, 0.000);
            ABCs[11] = new ABC(4.060, -1.700, 0.000);
            ABCs[12] = new ABC(0.440, 0.465, 0.000);
            ABCs[13] = new ABC(29.000, -27.500, 12.500);
            ABCs[14] = new ABC(1.050, 0.310, 0.000);
            ABCs[15] = new ABC(2.352, 5.916, -0.338);
            ABCs[16] = new ABC(2.800, -0.870, 0.000);
            ABCs[17] = new ABC(4.543, -4.399, 1.935);
            ABCs[18] = new ABC(0.840, 0.580, 0.000);

        }

        Layer first, second, third, forth, fifth;

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ATB3.Text = ABCs[comboBox3.SelectedIndex].A.ToString();
            BTB3.Text = ABCs[comboBox3.SelectedIndex].B.ToString();
            CTB3.Text = ABCs[comboBox3.SelectedIndex].C.ToString();
        }




        private void ClearBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void LayerGB3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработали студенты\nСПбГТИ(ТУ) факультета ИТиУ 475группы:\nОвчинников Роман Сергеевич\nАндрианова Карина Ивановна", "Информация о разработчике");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ATB2.Text = ABCs[comboBox2.SelectedIndex].A.ToString();
            BTB2.Text = ABCs[comboBox2.SelectedIndex].B.ToString();
            CTB2.Text = ABCs[comboBox2.SelectedIndex].C.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ATB1.Text = ABCs[comboBox1.SelectedIndex].A.ToString();
            BTB1.Text = ABCs[comboBox1.SelectedIndex].B.ToString();
            CTB1.Text = ABCs[comboBox1.SelectedIndex].C.ToString();
        }

        private void LayersGB_Enter(object sender, EventArgs e)
        {

        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();

            int count = 0;
            if (ExistenceCB1.Checked)
                count++;
            if(ExistenceCB2.Checked)
                count++;
            if (ExistenceCB3.Checked)
                count++;
           

            Layer[] layers = new Layer[count];
            count = 0;

            //Здесь забираются данные с текстбоксов
            try
            {
                if (ExistenceCB1.Checked)
                {
                    layers[count] = new Layer(Convert.ToDouble(WidthTB1.Text), Convert.ToDouble(ATB1.Text), Convert.ToDouble(BTB1.Text), Convert.ToDouble(CTB1.Text), 0, 0);
                    count++;
                }
                if (ExistenceCB2.Checked)
                {
                    layers[count] = new Layer(Convert.ToDouble(WidthTB2.Text), Convert.ToDouble(ATB2.Text), Convert.ToDouble(BTB2.Text), Convert.ToDouble(CTB2.Text), 0, 0);
                    count++;
                }
                if (ExistenceCB3.Checked)
                {
                    layers[count] = new Layer(Convert.ToDouble(WidthTB3.Text), Convert.ToDouble(ATB3.Text), Convert.ToDouble(BTB3.Text), Convert.ToDouble(CTB3.Text), 0, 0);
                    count++;
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("Неверный формат введенных данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double[] tempres = new double[count+1];
            double[] temptempres = new double[count+1];
            double[] lambdas = new double[count];
            double[] ques = new double[count];
            double tMax = Convert.ToDouble(TempetureEthernTB.Text);
            double tMin = Convert.ToDouble(TempetureExternTB.Text);

            double length = 0;
            for(int i = 0; i < count; i++)
                length += layers[i].width;

            int iter = Convert.ToInt32(IterationsTB.Text);
            if(iter > 1)
            {
                iter = 2;
            }

            for (int j = 0; j < iter; j++)
            {
                
                double cellT = 0;
                if (j == 0)
                    cellT = (tMax - tMin) / length + (tMax - tMin) % length;
                else
                    cellT = (tempres[0] - tempres[count]) / length + (tempres[0] - tempres[count]) % length;
                double x = 0;
                double fullSum = 0;
                label19.Text = "";

               if (j == 0)
                {
                    tempres[0] = tMax;
                    temptempres[count] = tMin;
                }

                for (int i = 0; i < count; i++)
                {
                    x += layers[i].width;
                    tempres[i + 1] = tMax - (cellT * x);
                }
                for (int i = 1; i < count + 1; i++)
                {


                    lambdas[i - 1] = layers[i - 1].paramA + (layers[i - 1].paramB * Math.Pow(10, -3) * tempres[i]) + (layers[i - 1].paramC * Math.Pow(10, -6) * tempres[i] * tempres[i]);
                    fullSum += layers[i - 1].width / lambdas[i - 1];
                    x += layers[i - 1].width;
                }
                x = 0;
                double q = 0;
                if (j==0)
                    q = (tMax - tMin) / fullSum;
                else
                   
                    q = (tempres[0] - tempres[1]) / fullSum;
                for (int i = 0; i < count; i++)
                {
                    if (i == 0)
                        temptempres[i] = tempres[0];
                    //temptempres[i] = 1400;
                    else
                        temptempres[i] = tempres[i - 1] - (q * layers[i - 1].width / lambdas[i - 1] + q * layers[i - 1].width % lambdas[i - 1]);
                }
                x = 0;
                for (int i = 0; i < count + 1; i++)
                {
                    if (j == 0)
                    {
                        chart1.Series[1].Points.AddXY(x, temptempres[i]);
                        chart1.Series[0].Points.AddXY(x, tempres[i]);
                    }
                    else
                    {

                        chart1.Series[2].Points.AddXY(x, temptempres[i]);
                    }
                    if (i < count)
                    {
                        x += layers[i].width;
                    }
                    tempres[i] = temptempres[i];
                }
                ;
                label19.Text += Convert.ToInt32(q).ToString();
            }
        }
    }
}
