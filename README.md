# portal-carros-api

Esse repositório diz respeito a um desafio em .Net Core proposto pelo IA.
Em resumo, é uma API que permite a consulta dos carros cadastrados e algumas operações nos carros disponíveis.

## Solução

Foi criado utilizando .Net 6 uma API que realiza a consulta de todos os carros cadastrados,
a autonomia de cada carro, o carro mais veloz e com a maior autonomia. Também é possível reabastecer, 
ativar modo econômico, ativar modo turbo.

## Como testar

Para que seja possível testar o projeto, garanta que tenha instalado em seu PC o dotnet 6.

Para testar a API inicie o projeto Portal_Carros_API e acesse o endereço https://localhost:7169/swagger/index.html,
todos os endpoints criados na API estarão disponíveis para teste neste endereço.

## Testes Unitários

Foi criado teste unitário para cada método de PUT, onde foi verificado os resultados retornados pelos métodos
criados para o funcionamento da API
