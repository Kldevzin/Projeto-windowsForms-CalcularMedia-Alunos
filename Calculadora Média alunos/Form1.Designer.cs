namespace Calculadora_Média_alunos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Adicionar = new System.Windows.Forms.Button();
            this.textBox_nota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_Alunos = new System.Windows.Forms.ListBox();
            this.textBox_Aluno = new System.Windows.Forms.TextBox();
            this.nota_1 = new System.Windows.Forms.Label();
            this.textBox_nota3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nota2 = new System.Windows.Forms.TextBox();
            this.button_Remover_aluno = new System.Windows.Forms.Button();
            this.button_estatistica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Adicionar
            // 
            this.button_Adicionar.Location = new System.Drawing.Point(555, 224);
            this.button_Adicionar.Name = "button_Adicionar";
            this.button_Adicionar.Size = new System.Drawing.Size(126, 125);
            this.button_Adicionar.TabIndex = 0;
            this.button_Adicionar.Text = "Adicionar Aluno";
            this.button_Adicionar.UseVisualStyleBackColor = true;
            this.button_Adicionar.Click += new System.EventHandler(this.button_Adicionar_Click);
            // 
            // textBox_nota1
            // 
            this.textBox_nota1.Location = new System.Drawing.Point(872, 85);
            this.textBox_nota1.Multiline = true;
            this.textBox_nota1.Name = "textBox_nota1";
            this.textBox_nota1.Size = new System.Drawing.Size(172, 53);
            this.textBox_nota1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do aluno";
            // 
            // list_Alunos
            // 
            this.list_Alunos.FormattingEnabled = true;
            this.list_Alunos.IntegralHeight = false;
            this.list_Alunos.ItemHeight = 16;
            this.list_Alunos.Location = new System.Drawing.Point(12, 44);
            this.list_Alunos.Name = "list_Alunos";
            this.list_Alunos.Size = new System.Drawing.Size(537, 436);
            this.list_Alunos.TabIndex = 4;
            // 
            // textBox_Aluno
            // 
            this.textBox_Aluno.Location = new System.Drawing.Point(555, 85);
            this.textBox_Aluno.Multiline = true;
            this.textBox_Aluno.Name = "textBox_Aluno";
            this.textBox_Aluno.Size = new System.Drawing.Size(231, 47);
            this.textBox_Aluno.TabIndex = 5;
            // 
            // nota_1
            // 
            this.nota_1.AutoSize = true;
            this.nota_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota_1.Location = new System.Drawing.Point(920, 44);
            this.nota_1.Name = "nota_1";
            this.nota_1.Size = new System.Drawing.Size(69, 25);
            this.nota_1.TabIndex = 6;
            this.nota_1.Text = "Nota 1";
            // 
            // textBox_nota3
            // 
            this.textBox_nota3.Location = new System.Drawing.Point(1314, 85);
            this.textBox_nota3.Multiline = true;
            this.textBox_nota3.Name = "textBox_nota3";
            this.textBox_nota3.Size = new System.Drawing.Size(137, 47);
            this.textBox_nota3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1145, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nota 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1333, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nota 3";
            // 
            // textBox_nota2
            // 
            this.textBox_nota2.Location = new System.Drawing.Point(1109, 85);
            this.textBox_nota2.Multiline = true;
            this.textBox_nota2.Name = "textBox_nota2";
            this.textBox_nota2.Size = new System.Drawing.Size(154, 47);
            this.textBox_nota2.TabIndex = 10;
            // 
            // button_Remover_aluno
            // 
            this.button_Remover_aluno.Location = new System.Drawing.Point(716, 224);
            this.button_Remover_aluno.Name = "button_Remover_aluno";
            this.button_Remover_aluno.Size = new System.Drawing.Size(126, 125);
            this.button_Remover_aluno.TabIndex = 11;
            this.button_Remover_aluno.Text = "Remover Aluno";
            this.button_Remover_aluno.UseVisualStyleBackColor = true;
            this.button_Remover_aluno.Click += new System.EventHandler(this.button_Remover_aluno_Click);
            // 
            // button_estatistica
            // 
            this.button_estatistica.Location = new System.Drawing.Point(886, 224);
            this.button_estatistica.Name = "button_estatistica";
            this.button_estatistica.Size = new System.Drawing.Size(126, 125);
            this.button_estatistica.TabIndex = 12;
            this.button_estatistica.Text = "Estatísticas";
            this.button_estatistica.UseVisualStyleBackColor = true;
            this.button_estatistica.Click += new System.EventHandler(this.button_estatistica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 505);
            this.Controls.Add(this.button_estatistica);
            this.Controls.Add(this.button_Remover_aluno);
            this.Controls.Add(this.textBox_nota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nota3);
            this.Controls.Add(this.nota_1);
            this.Controls.Add(this.textBox_Aluno);
            this.Controls.Add(this.list_Alunos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nota1);
            this.Controls.Add(this.button_Adicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Adicionar;
        private System.Windows.Forms.TextBox textBox_nota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_Alunos;
        private System.Windows.Forms.TextBox textBox_Aluno;
        private System.Windows.Forms.Label nota_1;
        private System.Windows.Forms.TextBox textBox_nota3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nota2;
        private System.Windows.Forms.Button button_Remover_aluno;
        private System.Windows.Forms.Button button_estatistica;
    }
}

