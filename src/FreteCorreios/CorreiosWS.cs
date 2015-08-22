using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreteCorreios
{
    public class FreteCorreiosWS
    {
        private wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoapClient wsCorreios;

        public FreteCorreiosWS()
        {
            wsCorreios = new wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoapClient("CalcPrecoPrazoWSSoap");
        }

        /// <summary>
        /// Calcula o prazo da postagem.
        /// </summary>
        /// <param name="nCdServico">Código do serviço.</param>
        /// <param name="sCepOrigem">CEP de origm.</param>
        /// <param name="sCepDestino">CEP de destino.</param>
        /// <returns></returns>
        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrazoAsync(string nCdServico, string sCepOrigem, string sCepDestino)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res; //= new wsCalculaPrecoPrazo.cResultado();

            try
            {
                res = await wsCorreios.CalcPrazoAsync(nCdServico, sCepOrigem, sCepDestino);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;

        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrazoDataAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrazoDataAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrazoRestricaoAsync(string nCdServico, string sCepOrigem, string sCepDestino, string sDtCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrazoRestricaoAsync(nCdServico, sCepOrigem, sCepDestino, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrecoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoDataAsync (string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrecoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoFACAsync(string nCdServico, string nVlPeso, string strDataCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(nVlPeso))
                throw new ArgumentNullException(nameof(nVlPeso));
            if (string.IsNullOrWhiteSpace(strDataCalculo))
                throw new ArgumentNullException(nameof(strDataCalculo));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrecoFACAsync(nCdServico, nVlPeso, strDataCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        /// <summary>
        /// Calcula o preço da postagem.
        /// </summary>
        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoPrazoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res = new wsCalculaPrecoPrazo.cResultado();
            try
            {
                res = await wsCorreios.CalcPrecoPrazoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoPrazoDataAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrecoPrazoDataAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }

        public async Task<wsCalculaPrecoPrazo.cResultado> CalcPrecoPrazoRestricaoAsync(string nCdEmpresa, string sDsSenha, string nCdServico, string sCepOrigem, string sCepDestino, string nVlPeso, int nCdFormato, decimal nVlComprimento, decimal nVlAltura, decimal nVlLargura, decimal nVlDiametro, string sCdMaoPropria, decimal nVlValorDeclarado, string sCdAvisoRecebimento, string sDtCalculo)
        {
            if (string.IsNullOrWhiteSpace(nCdServico))
                throw new ArgumentNullException(nameof(nCdServico));
            if (string.IsNullOrWhiteSpace(sCepOrigem))
                throw new ArgumentNullException(nameof(sCepOrigem));
            if (string.IsNullOrWhiteSpace(sCepDestino))
                throw new ArgumentNullException(nameof(sCepDestino));

            wsCalculaPrecoPrazo.cResultado res;
            try
            {
                res = await wsCorreios.CalcPrecoPrazoRestricaoAsync(nCdEmpresa, sDsSenha, nCdServico, sCepOrigem, sCepDestino, nVlPeso, nCdFormato, nVlComprimento, nVlAltura, nVlLargura, nVlDiametro, sCdMaoPropria, nVlValorDeclarado, sCdAvisoRecebimento, sDtCalculo);
            }
            catch (Exception e)
            {
                throw e;
            }
            return res;
        }
    }
}
