using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridStudentNoteCalculatorFormApp
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            hesaplama();
        }

        public void hesaplama()
        {
            decimal not1, not2, not3;
            if (decimal.TryParse(textBox1.Text, out not1)&& decimal.TryParse(textBox2.Text, out not2) && decimal.TryParse(textBox3.Text, out not3))
                {
                MessageBox.Show("olumlu");
                decimal ortalama = (not1 + not2 + not3) / 3;
                listeForm frm = new listeForm(not1,not2,not3,ortalama);
                frm.Show();
            }
            else
            {
                MessageBox.Show("olumsuz");
            }

           

         
        }
    }
}
