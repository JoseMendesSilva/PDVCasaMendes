using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//=======================================================================================================
namespace CasaMendes
{
    //====================================================================================================
    public class clsGlobal //Início da classe clsGlobal.
    {

        //====================================================================================================
        private static OpenFileDialog fDialogo;

        //====================================================================================================
        //private static int LinhasPromocao = 0;

        //====================================================================================================
        public static int CodigoVenda { get; set; }

        //====================================================================================================
        public static string TagForm { get; set; }

        //====================================================================================================
        public static decimal DeStringParadecimal(string sValor)
        {
            if (sValor != string.Empty) return Convert.ToDecimal(sValor);
            else return 0;
        }

        //===================================================================================================
        public static void CarregarEstados(ComboBox cb)
        {
            string SiglasDeEstados = "ACALAPBACEDFESGOMAMTMSMGPAPBPRPEPIRJRNRSRORRSCSPSETO";
            cb.Items.Clear();
            int tamanho = (SiglasDeEstados.Length - 1);
            cb.BeginUpdate();
            for (int i = 0; i < tamanho; i += 2)
            {
                cb.Items.Add(SiglasDeEstados.Substring(i, 2));
            }
            cb.EndUpdate();
        }

        //====================================================================================================
        public static string Abririmagens()
        {
            var dir = string.Empty;
            fDialogo = new OpenFileDialog();
            fDialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // Set the file dialog to filter for graphics files.
            fDialogo.Filter = "imagens (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF| All files (*.*)|*.*";
            // Allow the user to select multiple imagens.
            fDialogo.Multiselect = true;
            fDialogo.Title = Application.ProductName;
            DialogResult dialogResult = fDialogo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
               dir = fDialogo.FileName;
            }
            else
            {
                dir = string.Empty;
                //PicFoto.Image = Image.FromFile(clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, @"\CasaMendes.jpg"));
                //PicFoto.Image = Properties.Resources.CasaMendes1Jpg; //Image.FromFile(clsGlobal.ValidarDiretorio();
            }

            fDialogo.Dispose(); 
            return dir;

        }

        //====================================================================================================
        public static void Abririmagens(PictureBox PicFoto)
        {
            fDialogo = new OpenFileDialog();
            fDialogo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // Set the file dialog to filter for graphics files.
            fDialogo.Filter = "imagens (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF| All files (*.*)|*.*";
            // Allow the user to select multiple imagens.
            fDialogo.Multiselect = true;
            fDialogo.Title = Application.ProductName;
            DialogResult dialogResult = fDialogo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                PicFoto.Image = Image.FromFile(fDialogo.FileName);
            }
            else
            {
                //PicFoto.Image = Image.FromFile(clsGlobal.ValidarDiretorio(clsGlobal.sCaminho, @"\CasaMendes.jpg"));
                PicFoto.Image = Properties.Resources.CasaMendes1Jpg; //Image.FromFile(clsGlobal.ValidarDiretorio();
            }

            fDialogo.Dispose();
        }

        /*
         * ====================================================================================================
         * Lista de países do mundo
         * Abaixo há uma lista de países que podem ser copiados e colados em uma questão, como um menu suspenso.
         */
        public static void CarregarPaises(ComboBox cb)
        {
            cb.Items.Clear();
            string[] Paises =
            {"AD - Andorra"
            ,"AE - Emirados Árabes Unidos"
            ,"AF - Afeganistão"
            ,"AG - Antígua e Barbuda"
            ,"AI - Anguilla"
            ,"AL - Albânia"
            ,"AM - Armênia"
            ,"AO - Angola"
            ,"AQ - Antártica"
            ,"AR - Argentina"
            ,"AS - Samoa Americana"
            ,"AT - Áustria"
            ,"AU - Austrália"
            ,"AW - Aruba"
            ,"AZ - Azerbaijão"
            ,"BA - Bósnia e Herzegovina"
            ,"BB - Barbados"
            ,"BD - Bangladesh"
            ,"BE - Bélgica"
            ,"BF - Burkina Faso"
            ,"BG - Bulgária"
            ,"BH - Barém"
            ,"BI - Burundi"
            ,"BJ - Benin"
            ,"BL - São Bartolomeu"
            ,"BM - Bermuda"
            ,"BN - Brunei"
            ,"BO - Bolívia"
            ,"BR - Brasil"
            ,"BS - Bahamas"
            ,"BT - Butão"
            ,"BV - Ilha Bouvet"
            ,"BW - Botswana"
            ,"BY - Belarus"
            ,"BZ - Belize"
            ,"CA - Canadá"
            ,"CC - Ilhas Cocos(Keeling)"
            ,"CD - Congo, República Democrática"
            ,"CF - República Centro-Africana"
            ,"CG - Congo, República do"
            ,"CH - Suíça"
            ,"CI - Costa do Marfim"
            ,"CK - Ilhas Cook"
            ,"CL - Chile"
            ,"CM - Camarões"
            ,"CN - China"
            ,"CO - Colômbia"
            ,"CR - Costa Rica"
            ,"CU - Cuba"
            ,"CV - Cabo Verde"
            ,"CW - Curaçao"
            ,"CX - Ilha Christmas"
            ,"CY - Chipre"
            ,"CZ - República Tcheca"
            ,"DE - Alemanha"
            ,"DJ - Djibuti"
            ,"DK - Dinamarca"
            ,"DM - Dominica"
            ,"DO - República Dominicana"
            ,"DZ - Argélia"
            ,"EC - Equador"
            ,"EE - Estônia"
            ,"EG - Egito"
            ,"EH - Saara Ocidental"
            ,"ER - Eritréia"
            ,"ES - Espanha"
            ,"ET - Etiópia"
            ,"FI - Finlândia"
            ,"FJ - Fiji"
            ,"FK - Ilhas Falkland(Malvinas)"
            ,"FM - Micronésia, Estados Federados da"
            ,"FO - Ilhas Feroe"
            ,"FR - França"
            ,"FX - França Metropolitana"
            ,"GA - Gabão"
            ,"GB - Reino Unido"
            ,"GD - Grenada"
            ,"GE - Geórgia"
            ,"GF - Guiana Francesa"
            ,"GG - Guernsey"
            ,"GH - Gana"
            ,"GI - Gibraltar"
            ,"GL - Greenland"
            ,"GM - Gâmbia"
            ,"GN - Guiné"
            ,"GP - Guadelupe"
            ,"GQ - Guiné Equatorial"
            ,"GR - Grécia"
            ,"GS - Geórgia do Sul e Ilhas"
            ,"GT - Guatemala"
            ,"GU - Guam"
            ,"GW - Guiné-Bissau"
            ,"GY - Guiana"
            ,"HK - Hong Kong"
            ,"HM - Ilhas Heard and McDonald"
            ,"HN - Honduras"
            ,"HR - Croácia"
            ,"HT - Haiti"
            ,"HU - Hungria"
            ,"ID - Indonésia"
            ,"IE - Irlanda"
            ,"IL - Israel"
            ,"IM - Ilha de Man"
            ,"IN - Índia"
            ,"IO - Território Britânico do Oceano Índico"
            ,"IQ - Iraque"
            ,"IR - Irã"
            ,"IS - Islândia"
            ,"IT - Itália"
            ,"JE - Jersey"
            ,"JM - Jamaica"
            ,"JO - Jordânia"
            ,"JP - Japão"
            ,"KE - Quênia"
            ,"KG - Quirguistão"
            ,"KH - Camboja"
            ,"KI - Kiribati"
            ,"KM - Cômoros"
            ,"KN - São Cristóvão e Nevis"
            ,"KP - Coreia do Norte"
            ,"KR - Coreia do Sul"
            ,"KW - Kuwait"
            ,"KY - Ilhas Caiman"
            ,"KZ - Cazaquistão"
            ,"LA - Laos"
            ,"LB - Líbano"
            ,"LC - Santa Lúcia"
            ,"LI - Liechtenstein"
            ,"LK - Sri Lanka"
            ,"LR - Libéria"
            ,"LS - Lesoto"
            ,"LT - Lituânia"
            ,"LU - Luxemburgo"
            ,"LV - Letônia"
            ,"LY - Líbia"
            ,"MA - Marrocos"
            ,"MC - Mônaco"
            ,"MD - Moldova"
            ,"ME - Montenegro"
            ,"MF - Saint Martin"
            ,"MG - Madagascar"
            ,"MH - Ilhas Marshall"
            ,"MK - Macedônia"
            ,"ML - Mali"
            ,"MM - Birmânia"
            ,"MN - Mongólia"
            ,"MO - Macao"
            ,"MP - Ilhas Marianas do Norte"
            ,"MQ - Martinica"
            ,"MR - Mauritânia"
            ,"MS - Montserrat"
            ,"MT - Malta"
            ,"mu – Ilhas Maurício"
            ,"MV - Maldivas"
            ,"MW - Malawi"
            ,"MX - México"
            ,"MY - Malásia"
            ,"MZ - Moçambique"
            ,"NA - Namíbia"
            ,"NC - Nova Caledônia"
            ,"NE - Níger"
            ,"NF - Ilha Norfolk"
            ,"NG - Nigéria"
            ,"NI - Nicarágua"
            ,"NL - Holanda"
            ,"NO - Noruega"
            ,"NP - Nepal"
            ,"NR - Nauru"
            ,"NU - Niue"
            ,"NZ - Nova Zelândia"
            ,"OM - Omã"
            ,"PA - Panamá"
            ,"PE - Peru"
            ,"PF - Polinésia Francesa"
            ,"PG - Papua Nova Guiné"
            ,"PH - Filipinas"
            ,"PK - Paquistão"
            ,"PL - Polônia"
            ,"PM - Saint Pierre e Miquelon"
            ,"PN - Ilhas Pitcairn"
            ,"PR - Porto Rico"
            ,"PS - Faixa de Gaza"
            ,"PS - Cisjordânia"
            ,"PT - Portugal"
            ,"PW - Palau"
            ,"PY - Paraguai"
            ,"QA - Qatar"
            ,"RE - Reunião"
            ,"RO - Romênia"
            ,"RS - Sérvia"
            ,"RU - Rússia"
            ,"RW - Ruanda"
            ,"SA - Arábia Saudita"
            ,"SB - Ilhas Salomão"
            ,"SC - Seicheles"
            ,"SD - Sudão"
            ,"SE - Suécia"
            ,"SG - Cingapura"
            ,"SH - Santa Helena, Ascensão e Tristão da Cunha"
            ,"SI - Eslovênia"
            ,"SJ - Svalbard"
            ,"SK - Eslováquia"
            ,"SL - Serra Leoa"
            ,"SM - San Marino"
            ,"SN - Senegal"
            ,"SO - Somália"
            ,"SR - Suriname"
            ,"SS - Sudão do Sul"
            ,"ST - São Tomé e Príncipe"
            ,"SV - El Salvador"
            ,"SX - São Martinho"
            ,"SY - Síria"
            ,"SZ - Suazilândia"
            ,"TC - Ilhas Turks e Caicos"
            ,"TD - Chad"
            ,"TF - Sul da França e Antártica"
            ,"TG - Togo"
            ,"TH - Tailândia"
            ,"TJ - Tadjiquistão"
            ,"TK - Toquelau"
            ,"TL - Timor-Leste"
            ,"TM - Turcomenistão"
            ,"TN - Tunísia"
            ,"TO - Tonga"
            ,"TR - Turquia"
            ,"TT - Trinidad e Tobago"
            ,"TV - Tuvalu"
            ,"TW - Taiwan"
            ,"TZ - Tanzânia"
            ,"UA - Ucrânia"
            ,"UG - Uganda"
            ,"UM - Ilhas Menores Distantes dos Estados Unidos"
            ,"US - Estados Unidos"
            ,"UY - Uruguai"
            ,"UZ - Uzbequistão"
            ,"VA - Santa Sé(Cidade do Vaticano)"
            ,"VC - São Vicente e Granadinas"
            ,"VE - Venezuela"
            ,"VG - Ilhas Virgens Britânicas"
            ,"VI - Ilhas Virgens Americanas"
            ,"VN - Vietnã"
            ,"VU - Vanuatu"
            ,"WF - Ilhas Wallis e Futuna"
            ,"WS - Samoa"
            ,"XK - Kosovo"
            ,"YE - Iêmen"
            ,"YT - Maiote"
            ,"ZA - África do Sul"
            ,"ZM - Zâmbia"
            ,"ZW - Zimbábue"};

            cb.BeginUpdate();
            cb.Items.AddRange(Paises);
            cb.EndUpdate();
        }

        //===============================================================================================
        public static string sCaminho = Application.StartupPath;

        public static string ValidarDiretorio(string pDiretorio = "", string pArquivo = "")
        {
            if (pDiretorio == null) { return (null); }
            string sDir = pDiretorio.Substring(pDiretorio.Length - 1, 1);
            if (sDir == @"\")
            { sDir = string.Concat(pDiretorio, pArquivo); }
            else
            { sDir = string.Concat(pDiretorio, @"\", pArquivo); }
            return sDir.ToString();
        }

        //===============================================================================================
        public static void LimparControles(Control.ControlCollection c)
        {
            try
            {
                foreach (Control control in c)
                {
                    if (control.HasChildren)
                    {
                        //LimparControles(control.Controls);
                    }
                    else
                    {
                        if (control is TextBox)
                        {
                            TextBox txt = (TextBox)control;
                            txt.Clear();
                        }
                        if (control is ComboBox)
                        {
                            ComboBox cmb = (ComboBox)control;
                            if (cmb.Items.Count > 0)
                                cmb.Items.Clear();
                            cmb.Text = null;
                        }

                        if (control is CheckBox)
                        {
                            CheckBox chk = (CheckBox)control;
                            chk.Checked = false;
                        }

                        if (control is RadioButton)
                        {
                            RadioButton rdo = (RadioButton)control;
                            rdo.Checked = false;
                        }

                        if (control is ListBox)
                        {
                            ListBox listBox = (ListBox)control;
                            listBox.ClearSelected();
                        }

                        if (control is MaskedTextBox)
                        {
                            MaskedTextBox MtB = (MaskedTextBox)control;
                            MtB.Text = null;
                        }

                        if (control is DateTimePicker)
                        {
                            DateTimePicker DtP = (DateTimePicker)control;
                            DtP.Text = "#11/07/2019#";
                        }

                        if (control is PictureBox)
                        {
                            PictureBox pic = (PictureBox)control;
                            pic.Image = null;
                        }

                    }
                }

            }
            catch { }
        }

        //===============================================================================================
        public static void AbilitarControles(Control.ControlCollection c, bool status)
        {
            foreach (Control control in c)
            {
                if (control.HasChildren)
                {
                    AbilitarControles(control.Controls, status);
                }
                else
                {
                    if (control is TextBox)
                    {
                        TextBox txt = (TextBox)control;
                        txt.Enabled = status;
                    }
                    if (control is ComboBox)
                    {
                        ComboBox cmb = (ComboBox)control;
                        if (cmb.Items.Count > 0)
                            cmb.Enabled = status;
                    }

                    if (control is CheckBox)
                    {
                        CheckBox chk = (CheckBox)control;
                        chk.Enabled = status;
                    }

                    if (control is RadioButton)
                    {
                        RadioButton rdo = (RadioButton)control;
                        rdo.Enabled = status;
                    }

                    if (control is ListBox)
                    {
                        ListBox listBox = (ListBox)control;
                        listBox.Enabled = status;
                    }

                    if (control is MaskedTextBox)
                    {
                        MaskedTextBox MtB = (MaskedTextBox)control;
                        MtB.Enabled = status;
                    }

                    if (control is DateTimePicker)
                    {
                        DateTimePicker DtP = (DateTimePicker)control;
                        DtP.Enabled = status;
                    }

                    if (control is PictureBox)
                    {
                        //PictureBox pic = (PictureBox)control;
                        //pic.Enabled = status;
                    }

                }
            }
        }

        //===============================================================================================
        public static void CorDaPenaDosControles(Control.ControlCollection c)
        {
            Color CorDaPena = Color.Red;
            Color CorDeFundoFora = Color.GreenYellow;
            decimal dCodigo;
            decimal dValor;
            foreach (Control control in c)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.ForeColor = CorDaPena;
                    txt.BackColor = CorDeFundoFora;

                    if (txt.Text == "") break;

                    if (txt.Name == "txtCodigoDeBarras")
                    {
                        dCodigo = Convert.ToDecimal(txt.Text);
                        txt.Text = dCodigo.ToString("0000000000000");
                    }


                    if (txt.Name == "txtValorCompra")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtQuantidade")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("00000000");
                    }

                    if (txt.Name == "txtPrecoUnitario")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtEstoque")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("00000000");
                    }

                    if (txt.Name == "txtDesconto")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("0");
                    }

                    if (txt.Name == "txtPrecoDeVendaVista")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtPrecoDeVendaAnotar")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }

                    if (txt.Name == "txtCartao")
                    {
                        dValor = Convert.ToDecimal(txt.Text);
                        txt.Text = dValor.ToString("C2");
                    }
                }


                if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.ForeColor = CorDaPena;
                    cmb.BackColor = CorDeFundoFora;
                }

                if (control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    chk.ForeColor = CorDaPena;
                    chk.BackColor = CorDeFundoFora;
                }

                if (control is RadioButton)
                {
                    RadioButton rdo = (RadioButton)control;
                    rdo.ForeColor = CorDaPena;
                    rdo.BackColor = CorDeFundoFora;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ForeColor = CorDaPena;
                    listBox.BackColor = CorDeFundoFora;
                }

                if (control is MaskedTextBox)
                {
                    MaskedTextBox MtB = (MaskedTextBox)control;
                    MtB.ForeColor = CorDaPena;
                    MtB.BackColor = CorDeFundoFora;
                }

                if (control is DateTimePicker)
                {
                    DateTimePicker DtP = (DateTimePicker)control;
                    DtP.ForeColor = CorDaPena;
                    DtP.BackColor = CorDeFundoFora;
                }

                if (control is PictureBox)
                {
                    PictureBox pic = (PictureBox)control;
                    //pic.Image = null;
                    pic.BackColor = CorDeFundoFora;
                }
            }
        }

        //===============================================================================================
        public static void RegistrarLogDeErros(int numeroDoErro, string MenssagemDeErro)
        {
            try
            {
                string path = ValidarDiretorio(sCaminho, @"\CasaMendes.Log");

                //// Create the file if it not exists.
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                //Create the file.
                using (StreamWriter sw = new StreamWriter(path, true))
                //using (FileStream fs = File.OpenWrite(path),)
                {
                    //AddText(fs,numeroDoErro.ToString() + ": " + MenssagemDeErro);
                    sw.WriteLine(numeroDoErro.ToString() + ": " + MenssagemDeErro);
                    sw.Flush();
                    sw.Dispose();
                }

            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //===============================================================================================
        public static void SetUpDataGridView(DataGridView dgv)
        {
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Gold;
            style.ForeColor = Color.Red;
            dgv.AllowUserToAddRows = false;
            dgv.AutoGenerateColumns = true;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = SystemColors.ActiveBorder;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.BackgroundColor = Color.Green;
            dgv.ReadOnly = true;
        }

        /// <summary>
        /// Alinhar os elementos na grade
        /// </summary>
        /// <param name="dgv">Datagridview</param>
        /// <param name="posicao">Direita: right, Esquerda: left, Centro: center</param>
        public static void AlinharElementosNoGridView(DataGridView dgv, int index, string posicao = "left")
        {
            switch (posicao)
            {
                case "left":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    break;
                case "center":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    break;
                case "right":
                    dgv.Columns[index].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
                    break;
            }
        }

        //===============================================================================================
        public static string MontarTitulo(string pTitulo = "", string pTitulo2 = "")
        {
            string tmp;
            if ((pTitulo == "") && (pTitulo2 != "")) { tmp = "PDV - " + pTitulo2 + "."; }
            else if ((pTitulo2 == "") && (pTitulo != "")) { tmp = "PDV - " + pTitulo + "."; }
            else if ((pTitulo != "") && (pTitulo2 != "")) { tmp = "PDV - " + pTitulo + " - " + pTitulo2 + "."; }
            else { tmp = Application.ProductName; }

            return tmp;
        }

        //===============================================================================================
        public static int DimencionarColuna(int tColuna, int tGrid)
        {
            int Tamanho = tGrid - 16;
            Tamanho = (tColuna * Tamanho) / 100;
            return Tamanho;
        }

        //===============================================================================================
        public static void RedimencionarGrade(Form frm, DataGridView dgv)
        {
            try
            {
                SetUpDataGridView(dgv);
                //          //=============================================================================================
                int Espaco = frm.Width - 16;
                dgv.Left = 12;
                dgv.Width = Espaco - (dgv.Left * 2);
                dgv.Height = frm.Height - 130;
                //frm.Refresh();
                //          //=============================================================================================
            }
            catch
            {

            }

        }

        //===============================================================================================
        public static decimal Calcular(DataGridView dgv, int _iCelula)
        {
            decimal soma = 0;
            decimal celula;
            Int32 conte = dgv.Rows.Count - 1;

            for (Int32 i = 0; i <= conte; i++)
            {
                if (dgv.Rows[i].Cells[_iCelula].Value != null)
                {
                    celula = Convert.ToDecimal(dgv.Rows[i].Cells[_iCelula].Value.ToString().Replace("R$ ", ""));
                    soma += celula;
                }
            }
            return soma;
        }

        //===============================================================================================
        public static bool SomenteNumeros(KeyPressEventArgs e)
        {
            int mascara = e.KeyChar;
            if (mascara >= 48 && mascara <= 57 || e.KeyChar == 8 || e.KeyChar == 42 || e.KeyChar == 120)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public decimal De_String_Para_decimal(string sValor)
        {
            decimal valor_decimal = Convert.ToDecimal(sValor);
            return valor_decimal;
        }

    }

} //Fim da classe clsGlobal.
