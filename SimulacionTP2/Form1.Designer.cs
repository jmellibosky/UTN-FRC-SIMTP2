namespace SimulacionTP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb4 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.pb8 = new System.Windows.Forms.ProgressBar();
            this.pb7 = new System.Windows.Forms.ProgressBar();
            this.pb6 = new System.Windows.Forms.ProgressBar();
            this.pb5 = new System.Windows.Forms.ProgressBar();
            this.pb10 = new System.Windows.Forms.ProgressBar();
            this.pb9 = new System.Windows.Forms.ProgressBar();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnUniforme = new System.Windows.Forms.Button();
            this.btnPoisson = new System.Windows.Forms.Button();
            this.btnExponencial = new System.Windows.Forms.Button();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.txtua = new System.Windows.Forms.TextBox();
            this.txtub = new System.Windows.Forms.TextBox();
            this.txtpl = new System.Windows.Forms.TextBox();
            this.txtel = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtnn = new System.Windows.Forms.TextBox();
            this.txtpn = new System.Windows.Forms.TextBox();
            this.txten = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(387, 23);
            this.pb1.TabIndex = 0;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(12, 41);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(387, 23);
            this.pb2.TabIndex = 1;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(12, 99);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(387, 23);
            this.pb4.TabIndex = 3;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(12, 70);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(387, 23);
            this.pb3.TabIndex = 2;
            // 
            // pb8
            // 
            this.pb8.Location = new System.Drawing.Point(12, 215);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(387, 23);
            this.pb8.TabIndex = 7;
            // 
            // pb7
            // 
            this.pb7.Location = new System.Drawing.Point(12, 186);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(387, 23);
            this.pb7.TabIndex = 6;
            // 
            // pb6
            // 
            this.pb6.Location = new System.Drawing.Point(12, 157);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(387, 23);
            this.pb6.TabIndex = 5;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(12, 128);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(387, 23);
            this.pb5.TabIndex = 4;
            // 
            // pb10
            // 
            this.pb10.Location = new System.Drawing.Point(12, 273);
            this.pb10.Name = "pb10";
            this.pb10.Size = new System.Drawing.Size(387, 23);
            this.pb10.TabIndex = 9;
            // 
            // pb9
            // 
            this.pb9.Location = new System.Drawing.Point(12, 244);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(387, 23);
            this.pb9.TabIndex = 8;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(713, 12);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 10;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnUniforme
            // 
            this.btnUniforme.Location = new System.Drawing.Point(713, 41);
            this.btnUniforme.Name = "btnUniforme";
            this.btnUniforme.Size = new System.Drawing.Size(75, 23);
            this.btnUniforme.TabIndex = 11;
            this.btnUniforme.Text = "Uniforme";
            this.btnUniforme.UseVisualStyleBackColor = true;
            this.btnUniforme.Click += new System.EventHandler(this.btnUniforme_Click);
            // 
            // btnPoisson
            // 
            this.btnPoisson.Location = new System.Drawing.Point(713, 99);
            this.btnPoisson.Name = "btnPoisson";
            this.btnPoisson.Size = new System.Drawing.Size(75, 23);
            this.btnPoisson.TabIndex = 13;
            this.btnPoisson.Text = "Poisson";
            this.btnPoisson.UseVisualStyleBackColor = true;
            this.btnPoisson.Click += new System.EventHandler(this.btnPoisson_Click);
            // 
            // btnExponencial
            // 
            this.btnExponencial.Location = new System.Drawing.Point(713, 70);
            this.btnExponencial.Name = "btnExponencial";
            this.btnExponencial.Size = new System.Drawing.Size(75, 23);
            this.btnExponencial.TabIndex = 12;
            this.btnExponencial.Text = "Exponencial";
            this.btnExponencial.UseVisualStyleBackColor = true;
            this.btnExponencial.Click += new System.EventHandler(this.btnExponencial_Click);
            // 
            // txtns
            // 
            this.txtns.Location = new System.Drawing.Point(684, 14);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(23, 20);
            this.txtns.TabIndex = 14;
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(655, 14);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(23, 20);
            this.txtnm.TabIndex = 15;
            // 
            // txtua
            // 
            this.txtua.Location = new System.Drawing.Point(655, 43);
            this.txtua.Name = "txtua";
            this.txtua.Size = new System.Drawing.Size(23, 20);
            this.txtua.TabIndex = 17;
            // 
            // txtub
            // 
            this.txtub.Location = new System.Drawing.Point(684, 43);
            this.txtub.Name = "txtub";
            this.txtub.Size = new System.Drawing.Size(23, 20);
            this.txtub.TabIndex = 16;
            // 
            // txtpl
            // 
            this.txtpl.Location = new System.Drawing.Point(684, 101);
            this.txtpl.Name = "txtpl";
            this.txtpl.Size = new System.Drawing.Size(23, 20);
            this.txtpl.TabIndex = 19;
            // 
            // txtel
            // 
            this.txtel.Location = new System.Drawing.Point(684, 72);
            this.txtel.Name = "txtel";
            this.txtel.Size = new System.Drawing.Size(23, 20);
            this.txtel.TabIndex = 18;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(406, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "label1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(406, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "label2";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(406, 104);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 23;
            this.lbl4.Text = "label3";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(406, 75);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 22;
            this.lbl3.Text = "label4";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(405, 162);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(35, 13);
            this.lbl6.TabIndex = 25;
            this.lbl6.Text = "label5";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(406, 133);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(35, 13);
            this.lbl5.TabIndex = 24;
            this.lbl5.Text = "label6";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(405, 278);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(35, 13);
            this.lbl10.TabIndex = 29;
            this.lbl10.Text = "label7";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(406, 249);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(35, 13);
            this.lbl9.TabIndex = 28;
            this.lbl9.Text = "label8";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(406, 220);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(35, 13);
            this.lbl8.TabIndex = 27;
            this.lbl8.Text = "label9";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(406, 191);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(41, 13);
            this.lbl7.TabIndex = 26;
            this.lbl7.Text = "label10";
            // 
            // txtun
            // 
            this.txtun.Location = new System.Drawing.Point(626, 43);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(23, 20);
            this.txtun.TabIndex = 31;
            // 
            // txtnn
            // 
            this.txtnn.Location = new System.Drawing.Point(626, 14);
            this.txtnn.Name = "txtnn";
            this.txtnn.Size = new System.Drawing.Size(23, 20);
            this.txtnn.TabIndex = 30;
            // 
            // txtpn
            // 
            this.txtpn.Location = new System.Drawing.Point(655, 101);
            this.txtpn.Name = "txtpn";
            this.txtpn.Size = new System.Drawing.Size(23, 20);
            this.txtpn.TabIndex = 33;
            // 
            // txten
            // 
            this.txten.Location = new System.Drawing.Point(655, 72);
            this.txten.Name = "txten";
            this.txten.Size = new System.Drawing.Size(23, 20);
            this.txten.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(448, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(172, 284);
            this.dataGridView1.TabIndex = 34;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(632, 273);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(156, 23);
            this.btnRestart.TabIndex = 35;
            this.btnRestart.Text = "Restablecer";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpn);
            this.Controls.Add(this.txten);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.txtnn);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtpl);
            this.Controls.Add(this.txtel);
            this.Controls.Add(this.txtua);
            this.Controls.Add(this.txtub);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.btnPoisson);
            this.Controls.Add(this.btnExponencial);
            this.Controls.Add(this.btnUniforme);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.pb10);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb1;
        private System.Windows.Forms.ProgressBar pb2;
        private System.Windows.Forms.ProgressBar pb4;
        private System.Windows.Forms.ProgressBar pb3;
        private System.Windows.Forms.ProgressBar pb8;
        private System.Windows.Forms.ProgressBar pb7;
        private System.Windows.Forms.ProgressBar pb6;
        private System.Windows.Forms.ProgressBar pb5;
        private System.Windows.Forms.ProgressBar pb10;
        private System.Windows.Forms.ProgressBar pb9;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnUniforme;
        private System.Windows.Forms.Button btnPoisson;
        private System.Windows.Forms.Button btnExponencial;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtua;
        private System.Windows.Forms.TextBox txtub;
        private System.Windows.Forms.TextBox txtpl;
        private System.Windows.Forms.TextBox txtel;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtnn;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.TextBox txten;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnRestart;
    }
}

