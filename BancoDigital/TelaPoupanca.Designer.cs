namespace BancoDigital
{
    partial class TelaPoupanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPoupanca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLRS = new System.Windows.Forms.Label();
            this.lblValorDeposito = new System.Windows.Forms.Label();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.rbSaldo = new System.Windows.Forms.RadioButton();
            this.rbDepositar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.txtSaldoAtual = new System.Windows.Forms.TextBox();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomePoupanca = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroPoupanca = new System.Windows.Forms.Label();
            this.lblrsRendimento = new System.Windows.Forms.Label();
            this.txtRendimento = new System.Windows.Forms.TextBox();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblrsRendimento);
            this.groupBox1.Controls.Add(this.txtRendimento);
            this.groupBox1.Controls.Add(this.lblRendimento);
            this.groupBox1.Controls.Add(this.lbLRS);
            this.groupBox1.Controls.Add(this.lblValorDeposito);
            this.groupBox1.Controls.Add(this.txtDeposito);
            this.groupBox1.Controls.Add(this.rbSaldo);
            this.groupBox1.Controls.Add(this.rbDepositar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDeposito);
            this.groupBox1.Controls.Add(this.txtSaldoAtual);
            this.groupBox1.Controls.Add(this.lblSaldoAtual);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblNomePoupanca);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumeroPoupanca);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbLRS
            // 
            this.lbLRS.AutoSize = true;
            this.lbLRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRS.Location = new System.Drawing.Point(406, 338);
            this.lbLRS.Name = "lbLRS";
            this.lbLRS.Size = new System.Drawing.Size(32, 20);
            this.lbLRS.TabIndex = 8;
            this.lbLRS.Text = "R$";
            // 
            // lblValorDeposito
            // 
            this.lblValorDeposito.AutoSize = true;
            this.lblValorDeposito.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDeposito.Location = new System.Drawing.Point(11, 334);
            this.lblValorDeposito.Name = "lblValorDeposito";
            this.lblValorDeposito.Size = new System.Drawing.Size(165, 22);
            this.lblValorDeposito.TabIndex = 15;
            this.lblValorDeposito.Text = "Valor à Depositar:";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.Location = new System.Drawing.Point(11, 359);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(165, 24);
            this.txtDeposito.TabIndex = 14;
            this.txtDeposito.TextChanged += new System.EventHandler(this.txtDeposito_TextChanged);
            // 
            // rbSaldo
            // 
            this.rbSaldo.AutoSize = true;
            this.rbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaldo.Location = new System.Drawing.Point(136, 275);
            this.rbSaldo.Name = "rbSaldo";
            this.rbSaldo.Size = new System.Drawing.Size(143, 24);
            this.rbSaldo.TabIndex = 13;
            this.rbSaldo.TabStop = true;
            this.rbSaldo.Text = "Checar Saldo";
            this.rbSaldo.UseVisualStyleBackColor = true;
            this.rbSaldo.CheckedChanged += new System.EventHandler(this.rbSaldo_CheckedChanged);
            // 
            // rbDepositar
            // 
            this.rbDepositar.AutoSize = true;
            this.rbDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepositar.Location = new System.Drawing.Point(11, 275);
            this.rbDepositar.Name = "rbDepositar";
            this.rbDepositar.Size = new System.Drawing.Size(112, 24);
            this.rbDepositar.TabIndex = 12;
            this.rbDepositar.TabStop = true;
            this.rbDepositar.Text = "Depositar";
            this.rbDepositar.UseVisualStyleBackColor = true;
            this.rbDepositar.CheckedChanged += new System.EventHandler(this.rbDepositar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Que operação prentede realizar:";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposito.Location = new System.Drawing.Point(29, 389);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(113, 38);
            this.btnDeposito.TabIndex = 10;
            this.btnDeposito.Text = "Depositar";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // txtSaldoAtual
            // 
            this.txtSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoAtual.Location = new System.Drawing.Point(460, 334);
            this.txtSaldoAtual.Name = "txtSaldoAtual";
            this.txtSaldoAtual.Size = new System.Drawing.Size(132, 24);
            this.txtSaldoAtual.TabIndex = 9;
            this.txtSaldoAtual.TextChanged += new System.EventHandler(this.txtSaldoAtual_TextChanged);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtual.Location = new System.Drawing.Point(280, 336);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(111, 20);
            this.lblSaldoAtual.TabIndex = 7;
            this.lblSaldoAtual.Text = "Saldo Atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(477, 58);
            this.label5.TabIndex = 6;
            this.label5.Text = "Aqui no banca Bagga Bank seu dinheiro\r\nrende todo dia 5!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(589, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomePoupanca
            // 
            this.lblNomePoupanca.AutoSize = true;
            this.lblNomePoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePoupanca.Location = new System.Drawing.Point(216, 72);
            this.lblNomePoupanca.Name = "lblNomePoupanca";
            this.lblNomePoupanca.Size = new System.Drawing.Size(0, 20);
            this.lblNomePoupanca.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero Conta:";
            // 
            // lblNumeroPoupanca
            // 
            this.lblNumeroPoupanca.AutoSize = true;
            this.lblNumeroPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPoupanca.Location = new System.Drawing.Point(289, 35);
            this.lblNumeroPoupanca.Name = "lblNumeroPoupanca";
            this.lblNumeroPoupanca.Size = new System.Drawing.Size(0, 20);
            this.lblNumeroPoupanca.TabIndex = 0;
            this.lblNumeroPoupanca.Click += new System.EventHandler(this.label1_Visible);
            // 
            // lblrsRendimento
            // 
            this.lblrsRendimento.AutoSize = true;
            this.lblrsRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrsRendimento.Location = new System.Drawing.Point(406, 426);
            this.lblrsRendimento.Name = "lblrsRendimento";
            this.lblrsRendimento.Size = new System.Drawing.Size(32, 20);
            this.lblrsRendimento.TabIndex = 17;
            this.lblrsRendimento.Text = "R$";
            // 
            // txtRendimento
            // 
            this.txtRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendimento.Location = new System.Drawing.Point(460, 422);
            this.txtRendimento.Name = "txtRendimento";
            this.txtRendimento.Size = new System.Drawing.Size(132, 24);
            this.txtRendimento.TabIndex = 18;
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimento.Location = new System.Drawing.Point(277, 426);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(114, 20);
            this.lblRendimento.TabIndex = 16;
            this.lblRendimento.Text = "Rendimento:";
            // 
            // TelaPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(627, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaPoupanca";
            this.Text = "Conta Poupaça";
            this.Load += new System.EventHandler(this.TelaPoupanca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomePoupanca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSaldoAtual;
        private System.Windows.Forms.Label lbLRS;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label lblNumeroPoupanca;
        private System.Windows.Forms.RadioButton rbSaldo;
        private System.Windows.Forms.RadioButton rbDepositar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorDeposito;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblrsRendimento;
        private System.Windows.Forms.TextBox txtRendimento;
        private System.Windows.Forms.Label lblRendimento;
    }
}