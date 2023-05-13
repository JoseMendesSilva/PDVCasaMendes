
using CasaMendes.Classes.Estatica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using oDados = CasaMendes.Classes.ADL.Cl_Dados;

namespace CasaMendes.Classes.Geral
{
    class Cl_PreVenda : Propriedades.Cl_pPreVenda
    {
        public static decimal _Parcela;

        public static void CarregarGradeClente(DataGridView dgvCliente)
        {
            try
            {
                dgvCliente.AutoGenerateColumns = true;
                string sSql = "SELECT Codigo, Nome FROM tClientes";
                dgvCliente.DataSource = oDados.PegarDados(sSql, false);
             }
            catch { }
        }

        public static void CarregarGradeAnotado(DataGridView dgvVendas, string _Filtro)
        {
            try
            {
                if (_Filtro == "0") return;
                string sSql = "";
                if (_Filtro != "")
                {
                    sSql = "SELECT tPreVendas.CodigoDaVenda, tPreVendas.DataDaVenda as Data, tProdutos.Produto as Produtos, tPreVendas.Quantidade as Quant, tProdutos.PrecoDeVenda as Unitário, tPreVendas.Parcela, tProdutos.Desconto, (tPreVendas.Quantidade * tProdutos.PrecoDeVenda) AS SubTotal FROM tPreVendas INNER JOIN tProdutos ON tPreVendas.CodigoDeBarras = tProdutos.CodigoDeBarras WHERE TipoDeVenda =  'ANOTAR' AND CodigoDoCliente = " + _Filtro + " ORDER BY tPreVendas.CodigoDaVenda";
                }
                else
                {
                    sSql = "SELECT tPreVendas.CodigoDaVenda, tPreVendas.DataDaVenda as Data, tProdutos.Produto as Produtos, tPreVendas.Quantidade as Quant, tProdutos.PrecoDeVenda as Unitário, tPreVendas.Parcela, tProdutos.Desconto, (tPreVendas.Quantidade * tProdutos.PrecoDeVenda) AS SubTotal FROM tPreVendas INNER JOIN tProdutos ON tPreVendas.CodigoDeBarras = tProdutos.CodigoDeBarras WHERE TipoDeVenda = 'ANOTAR' ORDER BY tPreVendas.CodigoDaVenda";
                }
                dgvVendas.DataSource = oDados.PegarDados(sSql, false);
                //dgvVendas.Refresh();
                if (dgvVendas.Rows.Count > 0)
                {
                    _Parcela = Convert.ToDecimal(dgvVendas.Rows[0].Cells[5].Value);
                    //SetFormatting(dgvVendas, dgvVendas.Width);
                }

            }
            catch { }
        }

        public static decimal BuscarAnotado(string _Nome)
        {
            try
            {
                //Esta linha busca o nome do  cliente e o total devido pelo mesmo.
                //string sSql = "SELECT SUM(Resultado.Total) as Total,Resultado.Cliente as Cliente FROM (SELECT TP.Produto as TP, CL.Nome AS Cliente, PV.Quantidade * TP.PrecoDeVenda as Total FROM tClientes as CL inner join tPreVendas as PV on CL.Codigo = PV.CodigoDoCliente inner join tProdutos as TP on PV.CodigoDeBarras = TP.CodigoDeBarras WHERE CL.Nome = @Nome AND PV.TipoDeVenda = 'ANOTAR') as Resultado GROUP BY Resultado.Cliente ORDER BY Resultado.Cliente";

                //Esta linha busca só o total devido pelo cliente.
                if (oDados.Params.Count != 0) oDados.Params.Clear();
                oDados.AdicionarParametro("@Nome", _Nome);
                string sSql = "SELECT PV.Parcela FROM tClientes as CL inner join tPreVendas as PV on CL.Codigo = PV.CodigoDoCliente WHERE CL.Nome = @Nome AND PV.TipoDeVenda = 'ANOTAR'";
                _Parcela = Convert.ToDecimal(oDados.LerUmRegistro(sSql));

                if (oDados.Params.Count != 0) oDados.Params.Clear();
                oDados.AdicionarParametro("@Nome", _Nome);
                sSql = "SELECT SUM(Resultado.Total) as Total FROM (SELECT TP.Produto as TP, CL.Nome AS Cliente, PV.Quantidade * TP.PrecoDeVenda as Total FROM tClientes as CL inner join tPreVendas as PV on CL.Codigo = PV.CodigoDoCliente inner join tProdutos as TP on PV.CodigoDeBarras = TP.CodigoDeBarras WHERE CL.Nome = @Nome AND PV.TipoDeVenda = 'ANOTAR') as Resultado GROUP BY Resultado.Cliente ORDER BY Resultado.Cliente";
                decimal d = Convert.ToDecimal(oDados.LerUmRegistro(sSql));
                d *= Convert.ToDecimal("1,1");
                //d -= _Parcela;
                return d;
            }
            catch { return 0; }
        }

        public static void GravarParcela(string _Parcela, string Filtro)
        {
            if (oDados.Params.Count != 0) oDados.Params.Clear();
            oDados.AdicionarParametro("@Parcela", _Parcela);
            oDados.AdicionarParametro("@CodigoDoCliente", Filtro);
            string sSql = "UPDATE tPreVendas SET Parcela = (Parcela + @Parcela) WHERE CodigoDoCliente = @CodigoDoCliente";
            oDados.ExecutarQueryVendas(sSql, true);
        }

        public static void Receber(string _CodigoDoCliente, string _CodigoDaVenda, decimal Dinheiro, decimal Troco)
        {
            if (oDados.Params.Count != 0) oDados.Params.Clear();

            oDados.AdicionarParametro("@CodigoDaVenda", _CodigoDaVenda);
            oDados.AdicionarParametro("@CodigoDoCliente", _CodigoDoCliente);
            oDados.AdicionarParametro("@Dinheiro", Dinheiro);
            oDados.AdicionarParametro("@Troco", Troco);
            oDados.AdicionarParametro("@DataDaVenda", DateTime.Now.ToString("yyy-MM-dd"));

            string sSql = "UPDATE tPreVendas SET DataDaVenda = @DataDaVenda, TipoDeVenda = 'A VISTA', Dinheiro = @Dinheiro, Troco = @Troco WHERE CodigoDoCliente = @CodigoDoCliente AND TipoDeVenda = 'ANOTAR' AND CodigoDaVenda = @CodigoDaVenda";
            oDados.ExecutarQueryVendas(sSql, true);
        }

        public static void Extorno(string _CodigoDoCliente, string _CodigoDaVenda)
        {
            if (oDados.Params.Count != 0) oDados.Params.Clear();
            oDados.AdicionarParametro("@CodigoDoCliente", _CodigoDoCliente);
            oDados.AdicionarParametro("@CodigoDaVenda", _CodigoDaVenda);
            string sSql = "DELETE FROM tPreVendas WHERE CodigoDaVenda = @CodigoDaVenda AND CodigoDoCliente = @CodigoDoCliente AND TipoDeVenda = 'ANOTAR'";
            oDados.ExecutarQueryVendas(sSql, true);
        }

        public static void ExcluirVendaRessumo(string _CodigoDaVenda)
        {
            if (oDados.Params.Count != 0) oDados.Params.Clear();
            oDados.AdicionarParametro("@CodigoDaVenda", _CodigoDaVenda);
            string sSql = "DELETE FROM tPreVendas WHERE CodigoDaVenda = @CodigoDaVenda";
            oDados.ExecutarQueryVendas(sSql, true);
        }

        public static void CarregarResumoDeVendasAtual(DataGridView dgv, string inicio, string intervalo)
        {
            try
            {
                inicio = DateTime.Parse(inicio).ToString("yyyy-MM-dd");
                intervalo = DateTime.Parse(intervalo).ToString("yyyy-MM-dd");

                string sSql = "SELECT (tPreVendas.CodigoDaVenda) AS [Cod. Venda], tProdutos.Produto, tPreVendas.DataDaVenda as [Data venda], (tPreVendas.Quantidade) as Qtde, (((tPreVendas.Quantidade * tProdutos.PrecoDeVenda)) - (tPreVendas.DescontoAplicado)) as [Vendas] FROM [tPreVendas] inner join [tProdutos] on [tPreVendas].[CodigoDeBarras] = [tProdutos].[CodigoDeBarras] WHERE TipoDeVenda =  'A VISTA' ORDER BY tPreVendas.CodigoDaVenda";

                if (!inicio.Equals("") || !intervalo.Equals(""))
                {
                    sSql = "SELECT (tPreVendas.CodigoDaVenda) AS [Cod. Venda], tProdutos.Produto, tPreVendas.DataDaVenda as [Data venda], (tPreVendas.Quantidade) as Qtde, (((tPreVendas.Quantidade * tProdutos.PrecoDeVenda)) - (tPreVendas.DescontoAplicado)) as [Vendas], tPreVendas.Parcela FROM [tPreVendas] inner join [tProdutos] on [tPreVendas].[CodigoDeBarras] = [tProdutos].[CodigoDeBarras]  where (DataDaVenda >= '" + inicio + "') AND ( DataDaVenda <= '" + intervalo + "') AND ( TipoDeVenda =  'A VISTA') ORDER BY tPreVendas.CodigoDaVenda";
                }

                dgv.DataSource = oDados.PegarDados(sSql);

                if (dgv.Rows.Count > 0)
                {
                    decimal parcela = Convert.ToDecimal(dgv.Rows[0].Cells["Parcela"].Value);
                    decimal parcelaBase = parcela;
                    int linhas = dgv.RowCount;

                    dgv.Sort(dgv.Columns[6], ListSortDirection.Ascending);

                    if (parcela > 0)
                    {
                        decimal parcelaNova = 0;

                        for(int i = 0; i < linhas - 1; i++)
                        {
                            parcelaNova = Convert.ToDecimal(dgv.Rows[i].Cells["Parcela"].Value);
                            if (parcelaNova.Equals(parcelaBase) || parcelaNova.Equals(0))
                            {
                                continue;
                            }
                            else
                            {
                                parcela += parcelaNova;
                                parcelaBase = parcelaNova;
                            }
                        }
                    }
                }

            }
            catch { }
        }

        public static void FazerResumoDeVendas(string inicio, string intervalo)
        {
            try
            {
                inicio = DateTime.Parse(inicio).ToString("yyyy-MM-dd");
                intervalo = DateTime.Parse(intervalo).ToString("yyyy-MM-dd");

                string sSqlExisteVenda = "SELECT Valor FROM [tVendas] where (Data >= '" + inicio + "') AND ( Data <= '" + intervalo + "')";
                string       sSqlVenda = "SELECT sum(((tPreVendas.Quantidade * tProdutos.PrecoDeVenda)) - (tPreVendas.DescontoAplicado)) as Vendas FROM [tPreVendas] inner join [tProdutos] on [tPreVendas].[CodigoDeBarras] = [tProdutos].[CodigoDeBarras] where (tPreVendas.DataDaVenda >= '" + string.Format(inicio, "yyyy-mm-dd") + "') AND ( tPreVendas.DataDaVenda <= '" + string.Format(intervalo, "yyyy-mm-dd") + "') AND ( tPreVendas.TipoDeVenda =  'A VISTA')";
                string       sSqlCusto = "SELECT sum(tPreVendas.Quantidade * tProdutos.PrecoUnitario) as [Custo] FROM [tPreVendas] inner join [tProdutos] on [tPreVendas].[CodigoDeBarras] = [tProdutos].[CodigoDeBarras] where (tPreVendas.DataDaVenda >= '" + inicio + "') AND ( tPreVendas.DataDaVenda <= '" + intervalo + "')";
                string sSql            = "";

                decimal ValorVenda = 0, ValorCusto = 0, ValorExiste = 0;

                ValorVenda = clsGlobal.DeStringParadecimal(oDados.LerUmRegistro(sSqlVenda));

                if (!ValorVenda.Equals(0))
                {
                    ValorCusto = clsGlobal.DeStringParadecimal(oDados.LerUmRegistro(sSqlCusto));
                    ValorExiste = clsGlobal.DeStringParadecimal(oDados.LerUmRegistro(sSqlExisteVenda));

                    if (ValorExiste != 0)
                    {
                        if (ValorExiste.Equals(ValorVenda)) return;
                            sSql = "UPDATE tVendas SET Data = @Data, Valor = @Valor, Custo = @Custo, Status = @Status WHERE Data = @Data";
                    }
                    else
                    {
                        sSql = "INSERT INTO tVendas (Data, Valor, Custo, Status) VALUES (@Data, @Valor, @Custo, @Status)";
                    }

                    if (oDados.Params.Count != 0) oDados.Params.Clear();

                    oDados.AdicionarParametro("@Data", DateTime.Now.ToString("yyy-MM-dd"));
                    oDados.AdicionarParametro("@Valor", ValorVenda);
                    oDados.AdicionarParametro("@Custo", ValorCusto);
                    oDados.AdicionarParametro("@Status", "FECHADO");

                    oDados.ExecutarQuery(sSql);
                    sSql = null;
                    sSqlCusto = null;
                    sSqlExisteVenda = null;
                    sSqlVenda = null;
                }

            }
            catch { }
        }

    }
}

//SELECT (tPreVendas.CodigoDaVenda) AS [Cod. Venda], tProdutos.Produto, tPreVendas.DataDaVenda as [Data venda], (tPreVendas.Quantidade) as Qtde, (((tPreVendas.Quantidade * tProdutos.PrecoDeVenda)) - (tPreVendas.DescontoAplicado)) as [Vendas], tPreVendas.Parcela FROM [tPreVendas] inner join [tProdutos] on [tPreVendas].[CodigoDeBarras] = [tProdutos].[CodigoDeBarras]  where (DataDaVenda >= '2021-11-06') AND ( DataDaVenda <= '2021-11-07') AND ( TipoDeVenda =  'A VISTA') ORDER BY tPreVendas.CodigoDaVenda