using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Média_alunos
{
    public partial class Form1 : Form
    {
        public struct aluno
        {
            public string nome;
            public int nota1;
            public int nota2;
            public int nota3;
            public double media;
            public string situacao;
        }


        public static aluno?[] turma = new aluno?[100];


        public void preencherLista()
        {
            // Para limpar a lista box para por outro aluno
            list_Alunos.Items.Clear();
            for (int i = 0; i < turma.Length; i++)
            {  
                if (turma[i] != null)
                {
                    string nome_Aluno = turma[i]?.nome;
                    int nota_1 = turma[i]?.nota1 ?? 0;
                    int nota_2 = turma[i]?.nota2 ?? 0;
                    int nota_3 = turma[i]?.nota3 ?? 0;
                    double media = turma[i]?.media ?? 0;
                    string situacao_ = turma[i]?.situacao;
                    if (media >= 10)
                    {
                        situacao_ = "Aprovado";
                    }
                    else
                    {
                        situacao_ = "Reprovado";
                    }
                    // Aqui abaixo é para mostrar na lista BOX
                    string aux = $"Aluno:{nome_Aluno} | nota:{nota_1} | nota:{nota_2} | nota :{nota_3} | Média:{media:F2} | {situacao_}";
                    list_Alunos.Items.Add(aux);
                    
                }
            }

          
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            aluno NovoAluno = new aluno();
            for(int i = 0; i < turma.Length; i++)
            {
                if (turma[i] == null)
                {
                    NovoAluno.nome = textBox_Aluno.Text;
                    NovoAluno.nota1 = Convert.ToInt32(textBox_nota1.Text);
                    NovoAluno.nota2 = Convert.ToInt32(textBox_nota2.Text);
                    NovoAluno.nota3 = Convert.ToInt32(textBox_nota3.Text);
                    // verifica se a nota está entre 0 e 20, somente é guardado os valores quando estiver entre os extremos
                    if (NovoAluno.nota1 < 0 || NovoAluno.nota1 > 20 ||
                        NovoAluno.nota2 < 0 || NovoAluno.nota2 > 20 ||
                        NovoAluno.nota3 < 0 || NovoAluno.nota3 > 20)
                    {
                        MessageBox.Show("As notas devem ser entre 0 e 20!");
                        return; // para a execução e não guarda o aluno
                    }
                    NovoAluno.media = (NovoAluno.nota1 + NovoAluno.nota2 + NovoAluno.nota3) / 3.0;
                    turma[i] = NovoAluno;
                    MessageBox.Show("Aluno guardado na posição " + i);
                    preencherLista();
                    break;
                }
            }
            // para limpar a textbox
            textBox_Aluno.Clear();
            textBox_nota1.Clear();
            textBox_nota2.Clear();
            textBox_nota3.Clear();
            // criar um aluno novo e as variaveis não guarda o valor que antes tinha e zera tudo
            // novamente, fica com nenhum valor atribuido até o utilizador introduzir novamentex'   
            NovoAluno = new aluno();

        }

        private void button_Remover_aluno_Click(object sender, EventArgs e)
        {
            // Para clicar no aluno que você quer remover
            int index = list_Alunos.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Seleciona um aluno primeiro!");
                return;
            }
            turma[index] = null;
            list_Alunos.Items.RemoveAt(index);
            MessageBox.Show("Aluno removido da posição:"+index.ToString());
        }

        private void button_estatistica_Click(object sender, EventArgs e)
        {
            double melhor_media = 0.0;
            double pior_media = 20.0;
            int totaldeAlunos = 0;
            int aprovado = 0;
            int reprovado = 0;
            for(int i = 0; i < turma.Length; i++)
            {
                if (turma[i] != null)
                {
                    totaldeAlunos++;
                    if (turma[i].Value.media > melhor_media)
                    {
                        melhor_media = turma[i].Value.media;
                    }
                    if (turma[i].Value.media < pior_media)
                    {
                        pior_media = turma[i].Value.media;
                    }
                    if (turma[i].Value.media >= 10)
                    {
                        aprovado++;
                    }
                    else
                    {
                        reprovado++;
                    }
                }
            }
            if(totaldeAlunos == 0)
            {
                MessageBox.Show("Não há alunos registrados");
                return;
            }
            MessageBox.Show($"Melhor média: {melhor_media:F2}\nPior média: {pior_media:F2}\nAprovados: {aprovado}\nReprovados: {reprovado}");
        }
    }
}
