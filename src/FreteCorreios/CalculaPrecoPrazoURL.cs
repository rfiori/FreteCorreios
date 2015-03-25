using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreteCorreios
{
    /// <summary>
    /// Consulta com resultado no formato XML, na página do cliente e na página dos Correios:
    /// </summary>
    public class CalculaPrecoPrazoURL
    {
        internal string Servico;
        internal string CodEmpresa;
        internal string Senha;
        internal string CepOrigem;
        internal string CepDestino;
        internal int Peso;
        internal int Formato;
        internal int Comprimento;
        internal int Altura;
        internal int Largura;
        internal int Diametro;
        internal string MaoPropria;
        internal int ValorDeclarado;
        internal string AvisoRecebimento;
        
        /// <summary>
        /// Busca o XML gerado pelo Correios com os valores do frete.
        /// </summary>
        /// <param name="sSevico">Serviço a ser consultado o valor separados por vírgula - SEDEX com contrato(40096), PAC com contrato(41068).</param>
        /// <param name="nCdEmpresa">Seu código administrativo junto à ECT. O código está disponível no corpo do contrato firmado com os Correios. O parâmetro tem que ser passado mesmo vazio.</param>
        /// <param name="sDsSenha">Senha para acesso ao serviço, associada ao seu código administrativo. A senha inicial corresponde aos 8 primeiros dígitos do CNPJ. O parâmetro tem que ser passado mesmo vazio.</param>
        /// <param name="sCepOrigem">CEP de Origem sem hífen. Exemplo: 05311900.</param>
        /// <param name="sCepDestino">CEP de Destino Sem hífem.</param>
        /// <param name="nVlPeso">Peso da encomenda, incluindo sua embalagem. O peso deve ser informado em quilogramas.</param>
        /// <param name="nCdFormato">Formato da encomenda (incluindo embalagem). (1 – Formato caixa/pacote e 2 – Formato rolo/prisma).</param>
        /// <param name="nVlComprimento">Comprimento da encomenda (incluindo embalagem), em centímetros.</param>
        /// <param name="nVlAltura">Altura da encomenda (incluindo embalagem), em centímetros.</param>
        /// <param name="nVlLargura">Largura da encomenda (incluindo embalagem), em centímetros.</param>
        /// <param name="nVlDiametro">Diâmetro da encomenda (incluindo embalagem), em centímetros.</param>
        /// <param name="sCdMaoPropria">Indica se a encomenda será entregue com o serviço adicional mão própria.(S – Sim, N – Não).</param>
        /// <param name="nVlValorDeclarado">Indica se a encomenda será entregue com o serviço adicional valor declarado. Se não optar pelo serviço informar zero.</param>
        /// <param name="sCdAvisoRecebimento">Indica se a encomenda será entregue com o serviço adicional aviso de recebimento. (S – Sim, N – Não).</param>
        // <param name="sRetorno">Indica a forma de retorno da consulta. (XML - Resultado em XML),(Popup - Resultado em uma janela popup) e (URL - Resultado via post em uma página do requisitante).</param>
        public CalculaPrecoPrazoURL(string nCdEmpresa, string sDsSenha, string sSevico, string sCepOrigem, string sCepDestino, int nVlPeso,
            int nCdFormato, int nVlComprimento, int nVlAltura, int nVlLargura, int nVlDiametro, string sCdMaoPropria, int nVlValorDeclarado,
            string sCdAvisoRecebimento)
        {
            Servico     = sSevico;
            CodEmpresa  = nCdEmpresa;
            Senha       = sDsSenha;
            CepOrigem   = sCepOrigem;
            CepDestino  = sCepDestino;
            Peso        = nVlPeso;
            Formato     = nCdFormato;
            Comprimento = nVlComprimento;
            Altura      = nVlAltura;
            Largura     = nVlLargura;
            Diametro    = nVlDiametro;
            MaoPropria  = sCdMaoPropria;
            ValorDeclarado   = nVlValorDeclarado;
            AvisoRecebimento = sCdAvisoRecebimento;
        }

        public System.IO.StringReader BuscaValorFrete()
        {
            string texto = "";
            System.Net.WebClient WC = new System.Net.WebClient();
            string url = "http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?" +
                "nCdEmpresa=" + CodEmpresa +
                "&sDsSenha=" + Senha +
                "&nCdServico=" + Servico +
                "&sCepOrigem=" + CepOrigem +
                "&sCepDestino=" + CepDestino +
                "&nVlPeso=" + Peso +
                "&nCdFormato=" + Formato +
                "&nVlComprimento=" + Comprimento +
                "&nVlAltura=" + Altura +
                "&nVlLargura=" + Largura +
                "&sCdMaoPropria=" + MaoPropria +
                "&nVlValorDeclarado=" + ValorDeclarado +
                "&sCdAvisoRecebimento=" + AvisoRecebimento +
                "&nVlDiametro=" + Diametro +
                "&StrRetorno=XML";
            texto = WC.DownloadString(url);
            WC.Dispose();

            System.Xml.XmlDocument X = new System.Xml.XmlDocument();
            System.IO.StringReader SR = new System.IO.StringReader(texto);
            return SR;
        }
    }
}
