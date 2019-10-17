namespace formulario
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desconto = new System.Windows.Forms.TextBox();
            this.sdesconto = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bonificacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.liquido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario";
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(92, 81);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(195, 20);
            this.salario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desconto";
            // 
            // desconto
            // 
            this.desconto.Location = new System.Drawing.Point(92, 128);
            this.desconto.Name = "desconto";
            this.desconto.Size = new System.Drawing.Size(93, 20);
            this.desconto.TabIndex = 4;
            // 
            // sdesconto
            // 
            this.sdesconto.AutoSize = true;
            this.sdesconto.Location = new System.Drawing.Point(191, 131);
            this.sdesconto.Name = "sdesconto";
            this.sdesconto.Size = new System.Drawing.Size(96, 17);
            this.sdesconto.TabIndex = 6;
            this.sdesconto.Text = "Sem Desconto";
            this.sdesconto.UseVisualStyleBackColor = true;
            this.sdesconto.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bonificação";
            // 
            // bonificacao
            // 
            this.bonificacao.Location = new System.Drawing.Point(99, 164);
            this.bonificacao.Name = "bonificacao";
            this.bonificacao.Size = new System.Drawing.Size(188, 20);
            this.bonificacao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Calculo Liquido";
            // 
            // liquido
            // 
            this.liquido.Location = new System.Drawing.Point(120, 256);
            this.liquido.Name = "liquido";
            this.liquido.Size = new System.Drawing.Size(167, 20);
            this.liquido.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(92, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculo Salário Liquido";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nome
            // 
            this.nome.FormattingEnabled = true;
            this.nome.Items.AddRange(new object[] {
            "Paulo",
            "Rui",
            "Danielle",
            "Maria",
            "Jose",
            "Antonio"});
            this.nome.Location = new System.Drawing.Point(92, 29);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(195, 21);
            this.nome.TabIndex = 13;
            this.nome.Text = "Selecionar Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(323, 297);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.liquido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bonificacao);
            this.Controls.Add(this.sdesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desconto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CALCULO SALARIO FUNCIONÁRIOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desconto;
        private System.Windows.Forms.CheckBox sdesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bonificacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox liquido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox nome;
    }
}

