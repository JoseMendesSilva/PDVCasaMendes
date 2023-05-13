using System.Windows.Forms;

namespace CasaMendes.Classes.Estatica
{
    public class clsMensagens
    {
        //Constantes
        private const string M00001 = "O cadastro foi realizado com sucesso.";//M0002-->Os dados forão atualizados com sucesso.
        private const string M00002 = "Os dados forão atualizados com sucesso.";//M0002-->Os dados forão atualizados com sucesso.
        public const string M00003 = "Você tem certesa? Quer mesmo exclir este registro? O mesmo não poderá mais ser restaurado.";//M0003-->Você tem certesa? Quer mesmo exclir este registro? O mesmo não poderá mais ser restaurado.
        private const string M00004 = "Este registro será alterados, deseja continuar?";//M0004-->Este registro será alteradom, deseja continuar?
        private const string M00005 = "Excluir registro";//M0005-->Excluir registro
        public const string M00006 = "Atualizar registro";//M0006-->Atualizar registro
        private const string M00007 = "Erro N:";//M0007-->Erro N:
        private const string M00008 = "Ocorreu ao";//M0008-->Ocorreu ao
        private const string M00009 = "Gravar os dados";//M0009-->Gravar os dados
        private const string M00010 = "O nome";//M00010-->O nome
        private const string M00011 = "já está cadastrado";//M00011-->Ja (está cadastrado) existe
        private const string M00012 = "Carregando formulário";//M00012-->Carregando formulário
        private const string M00013 = "Aguarde";//M00013-->Aguarde
        private const string M00014 = "Processando";//M00014-->Processando
        private const string M00015 = "Você confirma o fechamento do formulário?";//M00015-->Você confirma o fechamento do formulário?
        private const string M00016 = "Processo em andamento";//M00016-->Processo em andamento
        private const string M00017 = "Você não tem permição para";//M00017-->Você não tem permição para
        private const string M00018 = "Este";//M00018-->Este
        public const string M00019 = "Atualizar";//M00019-->Atualizar
        public const string M00020 = "Excluir";//M00020-->Excluir
        private const string M00021 = "Cadastrar";//M00021-->Cadastrar
        private const string M00022 = "Registro";//M00022-->Registro
        private const string M00023 = "Fechar";//M00023-->Fechar
        private const string M00024 = "Fechando";//M00024-->Fechando
        private const string M00025 = "Fechado";//M00025-->Fechado
        public const string M00026 = "Novo";//M00026-->Novo
        public const string M00027 = "Cadastro";//M00027-->Cadastro
        public const string M00028 = "Gravar";//M0009-->Gravar os dados
        public const string M00029 = "Erro ";//M0007-->Erro N:
        public const string M00030 = "imagens salva com sucesso";//M0007-->Erro N:
        public const string M00031 = "Linha";//M0007-->Erro N:
        private const string M00032 = "O cadastro não foi realizado com sucesso";//M0007-->Erro N:
        public const string M00033 = "Erro ao realizado cadastro";//M0007-->Erro N:
        private const string M00034 = "O registro foi atualizar com sucesso.";//M0007-->Erro N:
        private const string M00035 = "Sucesso ao excluir o registro.";//M0007-->Erro N:
        public const string M00036 = "Erro ao excluir o registro";//M0007-->Erro N:
        public const string M00037 = "Deseja continuar assim mesmo?";//M0007-->Erro N:
        private const string M00038 = "Ele não poderá mais ser resturado!";//M0007-->Erro N:
        public const string M00039 = "Novo";//M0007-->Erro N:
        public const string M00040 = "Erro ao atualizar o registro";//M0007-->Erro N:
        public const string M00041 = "Cadastro de funcionarios";//M0007-->Erro N:
        public const string M00042 = "produto";//M000
        public const string M00043 = "Dezeja cadastrar um novo";//M000

        /// <summary>
        /// Este metodo reune todas as mensagens a serem mostradas no sistema.
        /// o metodo é static e o seu uso é simples, é importar o namespace para a classe e fazer a chamada ao metodo como se segue.
        /// Exemplo: clsMensagem.MostrarMensagem(M-->x)
        /// </summary>
        /// <param name="M">Numero da mebsage á ser exibida.</param>
        public static void MostrarMensagem(byte M)
        {
            switch (M)
            {
                case 1:
                    MessageBox.Show(clsMensagens.M00001.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(clsMensagens.M00002.ToUpper(), clsMensagens.M00019.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    MessageBox.Show(clsMensagens.M00003.ToUpper(), clsMensagens.M00020.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
                case 4:
                    MessageBox.Show(clsMensagens.M00004.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 5:
                    MessageBox.Show(clsMensagens.M00005.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 6:
                    MessageBox.Show(clsMensagens.M00006.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 7:
                    MessageBox.Show(clsMensagens.M00007.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 8:
                    MessageBox.Show(clsMensagens.M00008.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 9:
                    MessageBox.Show(clsMensagens.M00009.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 10:
                    MessageBox.Show(clsMensagens.M00010.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 11:
                    MessageBox.Show(clsMensagens.M00011.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 12:
                    MessageBox.Show(clsMensagens.M00012.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 13:
                    MessageBox.Show(clsMensagens.M00013.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 14:
                    MessageBox.Show(clsMensagens.M00014.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 15:
                    MessageBox.Show(clsMensagens.M00015.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 16:
                    MessageBox.Show(clsMensagens.M00016.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 17:
                    MessageBox.Show(clsMensagens.M00017.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 18:
                    MessageBox.Show(clsMensagens.M00018.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 19:
                    MessageBox.Show(clsMensagens.M00019.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 20:
                    MessageBox.Show(clsMensagens.M00020.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 21:
                    MessageBox.Show(clsMensagens.M00021.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 22:
                    MessageBox.Show(clsMensagens.M00022.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 23:
                    MessageBox.Show(clsMensagens.M00023.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 24:
                    MessageBox.Show(clsMensagens.M00024.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 25:
                    MessageBox.Show(clsMensagens.M00025.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 26:
                    MessageBox.Show(clsMensagens.M00026.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 27:
                    MessageBox.Show(clsMensagens.M00027.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 28:
                    MessageBox.Show(clsMensagens.M00028.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 29:
                    MessageBox.Show(clsMensagens.M00029.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 30:
                    MessageBox.Show(clsMensagens.M00030.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 31:
                    MessageBox.Show(clsMensagens.M00031.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 32:
                    MessageBox.Show(clsMensagens.M00032.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 33:
                    MessageBox.Show(clsMensagens.M00033.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 34:
                    MessageBox.Show(clsMensagens.M00034.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 35:
                    MessageBox.Show(clsMensagens.M00035.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 36:
                    MessageBox.Show(clsMensagens.M00036.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 37:
                    MessageBox.Show(clsMensagens.M00037.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 38:
                    MessageBox.Show(clsMensagens.M00038.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                //case 39:
                //    MessageBox.Show(clsMensagens.M00039.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    break;
                case 40:
                    MessageBox.Show(clsMensagens.M00040.ToUpper(), clsMensagens.M00027.ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }
        }

    }
}
