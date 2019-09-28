using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projetoConexãoReceber.Properties;

namespace projetoConexãoReceber
{
    public partial class Form1 : Form
    {

        TcpListener servidor = new TcpListener(80);
        Socket[] conexao = new Socket[4];
        NetworkStream[] socketStream = new NetworkStream[4];
        BinaryWriter[] binaryWriter = new BinaryWriter[4];
        BinaryReader binaryReader;
        double Tempo = 0;
        int numCliente = 0;
        int tempoTresPontinhos = 0;
        int conexaoReferencia = 0;
        int controlLaco = 1;
        bool[] pc = new bool[4];

        public Form1()
        {
            InitializeComponent();
        }

        void vitoria()// metodo criado para verificar vitoria
        {

            if(pc[0] && pc[1])//verifica se o pc1 e o pc2 terminou o desafio(equipe 1)
            {

                MessageBox.Show("Time 1 GANHOU !!!");

            }else if (pc[2] && pc[3])//verifica se o pc3 e o pc4 terminou o desafio(equipe 2)
            {

                MessageBox.Show("Time 2 GANHOU !!!");

            }

            btnReiniciar.Visible = true;//Deixa visivel o botão reiniciar
            tempoResposta.Stop();//Encera os testes para verificar quem terminou

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if(controlLaco == 4)//zera o controle do laço antes do laço
                {

                    controlLaco = 0;

                }

                do
                {
                    if (conexao[controlLaco - 1].Connected)// verifica se aquela conexão existe
                    {

                        binaryReader = new BinaryReader(socketStream[controlLaco - 1]);//ler o que esta sendo passado na conexão

                        if (binaryReader.ReadBoolean())// verifica se esta recebendo boolean
                        {

                            Image img = Resources.certo;//imagem para diferenciar quem terminou
                            
                            if(controlLaco == 1)//verifica qual pc terminou
                            {

                                pctPc1.Image = img;//troca a imagem
                                pc[0] = true;//guarda qual pc terminou para futuros teste

                            }else if(controlLaco == 2)
                            {

                                pctPc2.Image = img;
                                pc[1] = true;

                            }else if(controlLaco == 3)
                            {
                                pctPc3.Image = img;
                                pc[2] = true;

                            }else if(controlLaco == 4)
                            {

                                pctPc4.Image = img;
                                pc[3] = true;

                            }

                            vitoria();//verifica se uma equipe terminou

                        }
                    }

                    controlLaco++;

                } while (controlLaco <= 4);//Existem 4 pcs conectados
            }
            catch
            {


            }

        }

        private void BtnIniciarServidor_Click(object sender, EventArgs e)
        {

            lblEstadoServidor.Text = "Servidor rodando ...";
            movimentoDosTresPontinhos.Start();

            servidor.Start();//inicia o servidor

            receberCliente.Start();//inicia a verificação de novos clientes

        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            int controlLaco = 0;
            do
            {

                try
                {

                    if (conexao[controlLaco].Connected)//verifica conexao do cliente
                    {

                        binaryWriter[controlLaco].Write(true);//enviar um tipo boleano
            
                    }

                }
                catch
                {

                }

                controlLaco++;
            } while (controlLaco < 3);

            tempoResposta.Start();//inicia a verificação de respostas

        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexao[conexaoReferencia].Connected)//Verifica se o usuario esta conectado
                {

                    MessageBox.Show("Usuario conectado");

                    Image img = Resources.traco;//Define uma imagem

                    if (conexaoReferencia == 0)//verifica qual o cliente
                    {

                        pctPc1.Image = img;//troca a imagem da picture box

                    }
                    else if (conexaoReferencia == 1)
                    {

                        pctPc2.Image = img;

                    }
                    else if (conexaoReferencia == 2)
                    {

                        pctPc3.Image = img;

                    }
                    else if (conexaoReferencia == 3)
                    {

                        pctPc4.Image = img;

                    }

                }
                else
                {

                    MessageBox.Show("Usuario desconectado");

                }

            }
            catch (Exception E)
            {

                MessageBox.Show("Usuario desconectado");
                //MessageBox.Show("Falha na conexão " + E);

            }
        }

        private void ReceberCliente_Tick(object sender, EventArgs e)
        {

            try
            {
                if (servidor.Pending())//verifica se há conexões pendentes
                {

                    conexao[numCliente] = servidor.AcceptSocket();//Agrega o pedido de conexão a um socket

                    socketStream[numCliente] = new NetworkStream(conexao[numCliente]);//Agrega o socket a network stream

                    binaryWriter[numCliente] = new BinaryWriter(socketStream[numCliente]);//Agrega uma network stream a um binarry writer

                    numCliente++;

                    Image img = Resources.traco;//Define uma imagem

                    if (numCliente == 0)//verifica qual o cliente
                    {

                        pctPc1.Image = img;//troca a imagem da picture box

                    }
                    else if (numCliente == 1)
                    {

                        pctPc2.Image = img;

                    }
                    else if (numCliente == 2)
                    {

                        pctPc3.Image = img;

                    }
                    else if (numCliente == 3)
                    {

                        pctPc4.Image = img;

                    }

                }
            }
            catch
            {

                if (numCliente == 3)//verifica se há o numero maximo de cliente
                {

                    receberCliente.Stop();//Para a verificação de clientes

                }

            }

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 1;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 0;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 2;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 3;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 4;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 5;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 6;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            conexaoReferencia = 7;
        }

        private void MovimentoDosTresPontinhos_Tick(object sender, EventArgs e)
        {

            if(tempoTresPontinhos == 0)
            {

                lblEstadoServidor.Text = "Servidor rodando .";
                tempoTresPontinhos++;

            }else if(tempoTresPontinhos == 1)
            {

                lblEstadoServidor.Text = "Servidor rodando ..";
                tempoTresPontinhos++;

            }else if(tempoTresPontinhos == 2){

                lblEstadoServidor.Text = "Servidor rodando ...";
                tempoTresPontinhos = 0;

            }

        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {

            Application.Restart();//Reinicia a aplicação

        }
    }
}
