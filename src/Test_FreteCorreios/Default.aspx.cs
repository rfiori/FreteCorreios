using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_FreteCorreios
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetWS_Click(object sender, EventArgs e)
        {
            var WS = new FreteCorreios.wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoapClient("CalcPrecoPrazoWSSoap");

            var Res = WS.CalcPrecoPrazo(
                tbCodEmpresa1.Text, //--=> Código da empresa para que tem contrato com o Correios.
                tbSenha1.Text,      //--=> Utilizado junco com o contrato.
                ddlServico1.SelectedValue, //--=> Número do serviço.
                tbCepO1.Text, //--=> CEP Origem.
                tbCepD1.Text, //--=> CEP Destino.
                tbPeso1.Text, //--=> Peso da encomenda, incluindo sua embalagem. O peso deve ser informado em quilogramas.
                int.Parse(ddlFormato1.SelectedValue), //--=> Formato.
                decimal.Parse(tbCompr1.Text), //--=> Comprimento da encomenda (incluindo embalagem), em centímetros.
                decimal.Parse(tbAltur1.Text), //--=> Altura da encomenda (incluindo embalagem), em centímetros.
                decimal.Parse(tbLarg1.Text),  //--=> Largura da encomenda (incluindo embalagem), em centímetros.
                decimal.Parse(tbDiam1.Text),  //--=> Diâmetro da encomenda (incluindo embalagem), em centímetros.
                ddlMaoP1.SelectedValue, //--=> Indica se a encomenda será entregue com o serviço adicional mão própria. Valores possíveis: S ou N.
                decimal.Parse(tbValD1.Text), //--=> Indica se a encomenda será entregue com o serviço adicional valor declarado. Neste campo deve ser apresentado o valor declarado desejado, em Reais.
                ddlAvisoR1.SelectedValue    //--=> Indica se a encomenda será entregue com o serviço adicional aviso de recebimento.Valores possíveis: S ou N
                );

            lblRes1.Text = "";

            if (!string.IsNullOrEmpty(Res.Servicos[0].MsgErro))
                lblRes1.Text = Res.Servicos[0].MsgErro;
            else
            {
                foreach (var x1 in Res.Servicos.ToList())
                    foreach (var x2 in x1.GetType().GetProperties())
                    {
                        try
                        {
                            lblRes1.Text += x2.Name + "  =  " + x2.GetValue(x1).ToString() + "<br/>";
                        }
                        catch { };

                    }
            }
        }
    }
}