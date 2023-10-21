namespace BancoDigital
{
    partial class TelaEspecial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEspecial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLRSEspecial = new System.Windows.Forms.Label();
            this.lblValorSaque = new System.Windows.Forms.Label();
            this.txtSaque = new System.Windows.Forms.TextBox();
            this.rbSaldoEspecial = new System.Windows.Forms.RadioButton();
            this.rbSacar = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacar = new System.Windows.Forms.Button();
            this.txtSaldoAtualEspecial = new System.Windows.Forms.TextBox();
            this.lblSaldoAtualEspecial = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomeEspecial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumeroEspecial = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLRSEspecial);
            this.groupBox1.Controls.Add(this.lblValorSaque);
            this.groupBox1.Controls.Add(this.txtSaque);
            this.groupBox1.Controls.Add(this.rbSaldoEspecial);
            this.groupBox1.Controls.Add(this.rbSacar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSacar);
            this.groupBox1.Controls.Add(this.txtSaldoAtualEspecial);
            this.groupBox1.Controls.Add(this.lblSaldoAtualEspecial);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblNomeEspecial);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNumeroEspecial);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbLRSEspecial
            // 
            this.lbLRSEspecial.AutoSize = true;
            this.lbLRSEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLRSEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLRSEspecial.Location = new System.Drawing.Point(412, 430);
            this.lbLRSEspecial.Name = "lbLRSEspecial";
            this.lbLRSEspecial.Size = new System.Drawing.Size(34, 22);
            this.lbLRSEspecial.TabIndex = 8;
            this.lbLRSEspecial.Text = "R$";
            // 
            // lblValorSaque
            // 
            this.lblValorSaque.AutoSize = true;
            this.lblValorSaque.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaque.Location = new System.Drawing.Point(11, 334);
            this.lblValorSaque.Name = "lblValorSaque";
            this.lblValorSaque.Size = new System.Drawing.Size(132, 22);
            this.lblValorSaque.TabIndex = 15;
            this.lblValorSaque.Text = "Valor à Sacar:";
            // 
            // txtSaque
            // 
            this.txtSaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaque.Location = new System.Drawing.Point(11, 359);
            this.txtSaque.Name = "txtSaque";
            this.txtSaque.Size = new System.Drawing.Size(165, 24);
            this.txtSaque.TabIndex = 14;
            // 
            // rbSaldoEspecial
            // 
            this.rbSaldoEspecial.AutoSize = true;
            this.rbSaldoEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSaldoEspecial.Location = new System.Drawing.Point(116, 275);
            this.rbSaldoEspecial.Name = "rbSaldoEspecial";
            this.rbSaldoEspecial.Size = new System.Drawing.Size(143, 24);
            this.rbSaldoEspecial.TabIndex = 13;
            this.rbSaldoEspecial.TabStop = true;
            this.rbSaldoEspecial.Text = "Checar Saldo";
            this.rbSaldoEspecial.UseVisualStyleBackColor = true;
            this.rbSaldoEspecial.CheckedChanged += new System.EventHandler(this.rbSaldoEspecial_CheckedChanged);
            // 
            // rbSacar
            // 
            this.rbSacar.AutoSize = true;
            this.rbSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSacar.Location = new System.Drawing.Point(11, 275);
            this.rbSacar.Name = "rbSacar";
            this.rbSacar.Size = new System.Drawing.Size(79, 24);
            this.rbSacar.TabIndex = 12;
            this.rbSacar.TabStop = true;
            this.rbSacar.Text = "Sacar";
            this.rbSacar.UseVisualStyleBackColor = true;
            this.rbSacar.CheckedChanged += new System.EventHandler(this.rbSacar_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Que operação prentede realizar:";
            // 
            // btnSacar
            // 
            this.btnSacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacar.Location = new System.Drawing.Point(29, 389);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(113, 38);
            this.btnSacar.TabIndex = 10;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // txtSaldoAtualEspecial
            // 
            this.txtSaldoAtualEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaldoAtualEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoAtualEspecial.Location = new System.Drawing.Point(464, 430);
            this.txtSaldoAtualEspecial.Name = "txtSaldoAtualEspecial";
            this.txtSaldoAtualEspecial.Size = new System.Drawing.Size(132, 22);
            this.txtSaldoAtualEspecial.TabIndex = 9;
            // 
            // lblSaldoAtualEspecial
            // 
            this.lblSaldoAtualEspecial.AutoSize = true;
            this.lblSaldoAtualEspecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSaldoAtualEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoAtualEspecial.Location = new System.Drawing.Point(293, 430);
            this.lblSaldoAtualEspecial.Name = "lblSaldoAtualEspecial";
            this.lblSaldoAtualEspecial.Size = new System.Drawing.Size(113, 22);
            this.lblSaldoAtualEspecial.TabIndex = 7;
            this.lblSaldoAtualEspecial.Text = "Saldo Atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(433, 87);
            this.label5.TabIndex = 6;
            this.label5.Text = "Só no Bagga Bank você pode sacar\r\naté R$1.000,00 a mais do seu saldo \r\nsem pagar " +
    "nada a mais por isso.";
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
            // lblNomeEspecial
            // 
            this.lblNomeEspecial.AutoSize = true;
            this.lblNomeEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEspecial.Location = new System.Drawing.Point(216, 72);
            this.lblNomeEspecial.Name = "lblNomeEspecial";
            this.lblNomeEspecial.Size = new System.Drawing.Size(0, 20);
            this.lblNomeEspecial.TabIndex = 4;
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
            // lblNumeroEspecial
            // 
            this.lblNumeroEspecial.AutoSize = true;
            this.lblNumeroEspecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEspecial.Location = new System.Drawing.Point(289, 35);
            this.lblNumeroEspecial.Name = "lblNumeroEspecial";
            this.lblNumeroEspecial.Size = new System.Drawing.Size(0, 20);
            this.lblNumeroEspecial.TabIndex = 0;
            // 
            // TelaEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 489);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaEspecial";
            this.Text = "Conta Especial";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbLRSEspecial;
        private System.Windows.Forms.Label lblValorSaque;
        private System.Windows.Forms.TextBox txtSaque;
        private System.Windows.Forms.RadioButton rbSaldoEspecial;
        private System.Windows.Forms.RadioButton rbSacar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox txtSaldoAtualEspecial;
        private System.Windows.Forms.Label lblSaldoAtualEspecial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomeEspecial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumeroEspecial;
    }
}