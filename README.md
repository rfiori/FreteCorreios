# FreteCorreios
A finalidade deste projeto é consumir o Webservice do Correios ou fazer requisição por URL para buscar preços dos serviço de encomenda e prazo da entrega. O cálculo é feito utilizando o CEP de origem e o CEP de desino. É possível fazer o cálculo para dos serviços para cliente que tenham contrato com o Correios ou para quem não tem contrato, os preços doas serviços são diferenciados.<br/>
[en] It consumes the webservice the Brazilian Post Office or make URL request with prices and delivery time of orders and delivery services.

# Atualização de Preços [en]Price Update
Todos os preços de serviços retornados são calculados pelo Webservice do Correios, por este motivo sempre estarão atualizados.<br/>
[en]All returned prices of services are calculated from the Brazilian Post Office Webservices, that's ever updated.

#Serviços Disponíveis [en]Services Available
Os serviços abaixo estão disponíveis para a consulta.<br/>
41106 - PAC sem contrato <br/>
41068 - PAC com contrato <br/>
81019 - e-SEDEX com contrato <br/>
40010 - SEDEX sem contrato <br/>
40096 - SEDEX com contrato <br/>
40436 - SEDEX com contrato <br/>
40444 - SEDEX com contrato <br/>
40568 - SEDEX com contrato <br/>
40606 - SEDEX com contrato <br/>
40045 - SEDEX a Cobrar sem contrato <br/>
40126 - SEDEX a Cobrar com contrato <br/>
40290 - SEDEX Hoje sem contrato <br/>
40215 - SEDEX 10 sem contrato <br/>
81868 - (Grupo 1) e-SEDEX com contrato <br/>
81833 - (Grupo 2) e-SEDEX com contrato <br/>
81850 - (Grupo 3) e-SEDEX com contrato <br/>

# Função [en]Function
Calcular o preço e prazo dos serviços de encomenda dos Correios (Brasil)
<br/>[en] Calculates the price and time of order services of Correios (Brazilian post office)

# Colaboração [en]Colaboration
Toda e qualquer colaboração será bem vinda, esteja a vontade para faze-la.
<br/>[en] Any collaboration is welcome, please feel free to do it.

#Web.config or App.config
Para utilizar o Webservice é necessário adicionar no Web.config ou App.config de seu projeto as linhas abaixo.
```xml
<configuration>
...
  <system.serviceModel>
    <bindings>
      <basicHttpBinding>
        <binding name="CalcPrecoPrazoWSSoap" />
      </basicHttpBinding>
      <customBinding>
        <binding name="CalcPrecoPrazoWSSoap12">
          <textMessageEncoding messageVersion="Soap12" />
          <httpTransport />
        </binding>
      </customBinding>
    </bindings>
    <client>
      <endpoint address="http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx"
          binding="basicHttpBinding" bindingConfiguration="CalcPrecoPrazoWSSoap"
          contract="wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoap" name="CalcPrecoPrazoWSSoap" />
      <endpoint address="http://ws.correios.com.br/calculador/CalcPrecoPrazo.asmx"
          binding="customBinding" bindingConfiguration="CalcPrecoPrazoWSSoap12"
          contract="wsCalculaPrecoPrazo.CalcPrecoPrazoWSSoap" name="CalcPrecoPrazoWSSoap12" />
    </client>
  </system.serviceModel>
    ...
</configuration>
```

#Screen WebExemplo
![Exemplo](http://s1.postimg.org/6nknhcmcf/Frete_Correios.png)
