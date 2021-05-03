# Locação de Imóveis
Serviço Api core rest desenvolvido para o o cadastro, listagem e locação de imóveis, este serviço foi desenvolvido utilizando tecnologia .Net core 5.0.
Para documentação foi utilizado Swagger.
# Como configurar o serviço de locação de imóveis
* Execute o script no repositorio
* Pronto
# Como utilizar o serviço de locação de imoveis
Para o funcionamento do serviço deve ser executado o script que se encontra neste reposiório (script_locacao_imoveis.sql)
Antes de começar a utilizar os serviços abaixo é necessário ter um token de acesso, para isso basta efetuar o cadastro como anunciante e terá um login e senha para acessar estes serviços.
Para efetuar o cadastro como anunciante basta entrar no endpoint "/api/advertiser" e preencher os dados conforme objeto em exemplo:
{
  "Name": "Anunciante 1",
  "Password": "123456",
  "PassowrdConfirm": "123456",
  "ContactInfo": {
    "Mail": "anunciante@gmail.com"
  }
}
Após o cadastro, o sistema responderá com status 200, basta efetuar o login e será retornado um token de acesso Bearer, basta utiliza-lo nas funcionalidades correspondentes.
* Cadastrar anuncio
* Cadastrar imóvel
* Editar anúncio
* Vender anúncio 

Para utilizar os serviços listados abaixo não é necessário realizar o cadastro como anunciante.
* Listar anúncios
* Solicitar contato
* Efetuar busca por endereço

Foi utilizado swagger para fazer a documentação deste serviço, ela se encontra no link: https://localhost:44366/index.html

# Requerimento Sistema
* .NET Core 5.0
* Sql Server 2019
