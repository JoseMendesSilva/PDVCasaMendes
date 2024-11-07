using JoseMendes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class FrmCasaMendes : Form
    {
        private int Id = 0;
        //public Funcionario oFuncionario { get; set; } = new Funcionario();
        FrmCadFuncionario func = null;

        //private AbrirCaixa repositorioAbrirCaixa; 

        //private List<string> Lista = new List<string>();
        //CriarTabelasDoSistema.CriarTabelas();

        public FrmCasaMendes()
        {

            //repositorioAbrirCaixa = OCaixa.EstaAberto();
            InitializeComponent();

            this.btnlogoInicio.Click += new System.EventHandler(this.btnlogoInicio_Click);
            this.btnprod.Click += new System.EventHandler(this.btnprod_Click);
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnVendasDia.Click += new System.EventHandler(this.btnVendas_Click);
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);

            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            this.iconmaximizar.Click += new System.EventHandler(this.iconmaximizar_Click);
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);

            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
        }

        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private bool CaixaEstaAberto()
        {
            // verificar se caixa está aberto
            var aberto = new OCaixa().EstaAberto();
            // se sim, mostrar, no formulario o valor e exibir a mensagem,
            if (aberto != null && aberto.AbrirCaixaId > 0)
            {
                this.Id = Convert.ToInt32(aberto.FuncionarioId); 
               return true;
            }
           return false;
        }

        private void CarregarFuncionario()
        {
            if (CaixaEstaAberto())
            {
                // Definir a cláusula WHERE e os parâmetros
                string whereClause = "FuncionarioId = @FuncionarioId";
                var parameters = new Dictionary<string, object> {
                {"FuncionarioId", this.Id }
                };
                var result = new Dados().SelectWithWhere<Funcionario>("Funcionarios", whereClause, parameters);

                this.oFuncionario = result.First();
                this.btnPdv.Enabled = true;
                this.BtnReceberPendura.Enabled = true;
                this.BtnAbrirCaixa.Enabled = false;
            }
            else
            {
                this.btnPdv.Enabled = false;
                this.BtnReceberPendura.Enabled = false;
                this.BtnAbrirCaixa.Enabled = true;
                func = new FrmCadFuncionario();
                func.ShowDialog();
                this.oFuncionario = func.oFuncionario;
                //func.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Mensagem.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        #endregion Mensagens.

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProdutos());
        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioResumen());
        }

        #region Caarga do Formulário.

        private void FrmCasaMendes_Load(object sender, EventArgs e)
        {
            //btnlogoInicio_Click(null, e);
            //this.Refresh();
        }
        
        private void FrmCasaMendes_Shown(object sender, EventArgs e)
        {
            try
            {
                if (this.oFuncionario is null || this.oFuncionario.FuncionarioId < 1)
                {
                     CarregarFuncionario();

                    if (oFuncionario.FuncionarioId > 0)
                    {
                        //btnlogoInicio_Click(null, e);
                        this.Refresh();
                        return;
                    }
                    MessageBox.Show($"É necessário a presença de um funcionário no caixa. Selecione um funcionário!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.oFuncionario = null;
                    this.Close();
                    //this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Join("Erro na abertura do formulário CasaMendes: ", ex.Message));
            }
        }

        #endregion fim carga do formulário.

        private async void btnPdv_Click(object sender, EventArgs e)
        {
            var frenteDeCaixa = new FrmFrenteDeCaixa();
            frenteDeCaixa.oFuncionario = this.oFuncionario;
            //frenteDeCaixa.
            // Set the Parent Form of the Child window.
            frenteDeCaixa.Text = "FrenteDeCaixa ";
            btnPdv.Enabled = false;
            // Display the new form.
            frenteDeCaixa.ShowDialog();
            GC.Collect();

            if (CaixaEstaAberto())
            {
                this.btnPdv.Enabled = true;
                this.BtnReceberPendura.Enabled = true;
                this.BtnAbrirCaixa.Enabled = false;
            }
            else
            {
                this.btnPdv.Enabled = false;
                this.BtnReceberPendura.Enabled = false;
                this.BtnAbrirCaixa.Enabled = true;
            }
        }
  
        private void btnVendas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCarregarVendas());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmProdutos());
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmFornecedores());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmClientes());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmEstoque());
        }

        private void PicConfiguracoes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmConfiguracoes());
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmCadCategoria());
        }

        private void BtnReceberPendura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmInventario());
        }

        private void BtnProcessarDados_Click(object sender, EventArgs e)
        {
            var ProcessarEstoque = new ProcessarEstoque();
            ProcessarEstoque.ShowDialog();
            ProcessarEstoque.Dispose();
        }

        private void BtnTabelaDeMargens_Click(object sender, EventArgs e)
        {
            FrmTabelaDeMargen frmTabelaDeMargen = new FrmTabelaDeMargen();
            frmTabelaDeMargen.ShowDialog();
        }

        private void BtnPlateleiraEstoque_Click(object sender, EventArgs e)
        {
            FrmAtualizarQuantValorEstoque AtualizarQuantValorEstoque = new FrmAtualizarQuantValorEstoque();
            AtualizarQuantValorEstoque.ShowDialog();
        }

        private void BtnAbrirCaixa_Click(object sender, EventArgs e)
        {
            if(this.oFuncionario.FuncionarioId < 1) {
                MessageBox.Show("Você não esta logado! Faça Login para dar proceguimento!", "Acesso não permitido.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // carregar o formuláro abrir caixa
            var frm = new FrmAbrirCaixa();
            frm.oFuncionario = this.oFuncionario;
            frm.ShowDialog();
            if (!frm.CaixaAberto)
            {
                MessageBox.Show("O caixa esta fechado, por favor abra o caixa!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnPdv.Enabled = false;
                this.BtnReceberPendura.Enabled = false;
                this.BtnAbrirCaixa.Enabled = true;
                return;
            }
            this.btnPdv.Enabled = true;
            this.BtnReceberPendura.Enabled = true;
            this.BtnAbrirCaixa.Enabled = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //new SqlQueryGeneratorContext().MainQuery();
            // var testeCategoria = new TesteCategoria
            // {
            //     CategoriaId = 0,
            //     Nome = "TesteCategoria",
            //     DataHora = DateTime.Now,
            //     Descricao = "TesteCategoria"
            // };
            //await new Dados().Insert(testeCategoria);
           
            //string input = "AlinharTextoExemplo";
            //int totalWidth = 40; // Largura total da linha

            //// Dividir a string ao meio
            //int midIndex = input.Length / 2;
            //string leftPart = input.Substring(0, midIndex);
            //string rightPart = input.Substring(midIndex);

            //// Formatar para alinhar a esquerda e a direita
            //string formattedOutput = leftPart.PadRight(totalWidth / 2) + rightPart.PadLeft(totalWidth / 2);

            //// Exibir o resultado
            //Console.WriteLine(formattedOutput);


            // escrever no logs.
            // gerar o arquivo de log.
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("---------- Fechar Caixa ----------");
            //sb.AppendLine("Data: " + DateTime.Now.ToString());
            //sb.AppendLine("Total Caixa");
            //sb.AppendLine("Total AbertoCom");
            //sb.AppendLine("Total Suprimento");
            //sb.AppendLine("Total Sangria");
            //sb.AppendLine("Total Desconto");
            //sb.AppendLine("Total Liquido");
            //sb.AppendLine("------------------------------------------------------------");

            //clsGlobal.RegistrarLogs(sb);

        }

    
    }
}
