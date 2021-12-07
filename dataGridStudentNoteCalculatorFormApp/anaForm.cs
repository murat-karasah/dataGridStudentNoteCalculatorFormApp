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
        public listeForm frm = new listeForm();


        public static int sayaca = 0;


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
                
                int idsss = frm.dataGridView1.Rows.Add();
                frm.dataGridView1.Rows[idsss].Cells[0].Value = idsss.ToString();
                frm.dataGridView1.Rows[idsss].Cells[1].Value = not1.ToString();
                frm.dataGridView1.Rows[idsss].Cells[2].Value = not2.ToString();
                frm.dataGridView1.Rows[idsss].Cells[3].Value = not3.ToString();
                frm.dataGridView1.Rows[idsss].Cells[4].Value = ortalama.ToString();
                if (ortalama > 45)
                {
                    frm.dataGridView1.Rows[idsss].Cells[5].Value = "Geçti";

                }
                else
                {
                    frm.dataGridView1.Rows[idsss].Cells[5].Value = "Kaldı";

                }
                if (sayaca==1)
                {

                }
                else
                {
                    sayaca++;
                    frm.Show();

                }


            }
            else
            {
                MessageBox.Show("olumsuz");
            }

           

         
        }
    }
}
