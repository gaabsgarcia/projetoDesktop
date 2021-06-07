using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl200462_atividadeAvaliativa_DAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n1 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn_adicao_Click(object sender, EventArgs e)
        {
            listBox_exer1.Items.Add(textBox1.Text);
            n1 += double.Parse(textBox1.Text);
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            if(listBox_exer1.Items.Count == 3)
            {
                txt_result.Text = n1.ToString();
                n1 = 0;
            }
            else
            {
                txt_result.Text = txt_result.Text + "Para somar os números da lista é necessário ter mais de 3 itens";
            }
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            if(listBox_exer1.Items.Count > 0)
            {
                listBox_exer1.Items.RemoveAt(listBox_exer1.SelectedIndex);
            }
          
        }

        private void btn_tranferir_Click(object sender, EventArgs e)
        {
            if (tania.Checked == true)
            {
                if(!listBox_transferidos.Items.Contains(tania.Text))
                    listBox_transferidos.Items.Add(tania.Text); 
            }
            if (barreto.Checked == true)
            {
                if (!listBox_transferidos.Items.Contains(barreto.Text))
                    listBox_transferidos.Items.Add(barreto.Text);
            }
            if (rosana.Checked == true)
            {
                if (!listBox_transferidos.Items.Contains(rosana.Text))
                    listBox_transferidos.Items.Add(rosana.Text);
            }
            if (simone.Checked == true)
            {
                if (!listBox_transferidos.Items.Contains(simone.Text))
                    listBox_transferidos.Items.Add(simone.Text);
                
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //Arquivo se encontra na package bin
            
            if (listBox_transferidos.Items.Contains(tania.Text))
            {
                File.WriteAllText("WriteText.txt", tania.Text);
            }
            if (listBox_transferidos.Items.Contains(barreto.Text))
            {
                File.WriteAllText("WriteText.txt", barreto.Text);
            }
            if (listBox_transferidos.Items.Contains(rosana.Text))
            {
                File.WriteAllText("WriteText.txt", rosana.Text);
            }
            if (listBox_transferidos.Items.Contains(simone.Text))
            {
                File.WriteAllText("WriteText.txt", simone.Text);

            }

            listBox_transferidos.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = comboBox1.Items.ToString();
            groupBox1.Visible = true;

        }
    }
}
