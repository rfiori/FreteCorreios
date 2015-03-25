using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreteCorreios
{
    public class FreteCorreiosWS
    {
        private wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoapClient wsCorreios;

        public FreteCorreiosWS()
        {
            wsCorreios = new wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoapClient("CalcPrecoPrazoWSSoap");
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrazo(string nCdServico, string sCepOrigem, string sCepDestino)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrazo(nCdServico, sCepOrigem, sCepDestino);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrazoData(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrazoData(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrazoRestricao(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrazoRestricao(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPreco(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPreco(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrecoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrecoData(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrecoFAC(string nCdServico, string nVlPeso, string strDataCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrecoFAC(nCdServico, nVlPeso, strDataCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrecoPrazo(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrecoPrazo(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrecoPrazoData(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrecoPrazoData(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public FreteCorreios.wsCalculaPrecoPrazo.cResultado CalcPrecoPrazoRestricao(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            var res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = wsCorreios.CalcPrecoPrazoRestricao(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }
    }
}
