
namespace dataGridStudentNoteCalculatorFormApp
{
    partial class listeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.not3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortalama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.not1,
            this.not2,
            this.not3,
            this.ortalama,
            this.durum});
            this.dataGridView1.Location = new System.Drawing.Point(32, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // not1
            // 
            this.not1.HeaderText = "not1";
            this.not1.Name = "not1";
            // 
            // not2
            // 
            this.not2.HeaderText = "not2";
            this.not2.Name = "not2";
            // 
            // not3
            // 
            this.not3.HeaderText = "not3";
            this.not3.Name = "not3";
            // 
            // ortalama
            // 
            this.ortalama.HeaderText = "ortalama";
            this.ortalama.Name = "ortalama";
            // 
            // durum
            // 
            this.durum.HeaderText = "durum";
            this.durum.Name = "durum";
            // 
            // listeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "listeForm";
            this.Text = "listeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn not1;
        private System.Windows.Forms.DataGridViewTextBoxColumn not2;
        private System.Windows.Forms.DataGridViewTextBoxColumn not3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalama;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
    }
}