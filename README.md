# Web API CalcTest
![.NET Core](https://github.com/RodrigoPrandi/CalcTest/workflows/.NET%20Core/badge.svg?branch=master)
![Docker](https://github.com/RodrigoPrandi/CalculaJurosApi/workflows/Docker/badge.svg?branch=master)

# Api 2

Criar uma API com dois endpoints:

###  1) Calcula Juros
A primeira reponde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo:

Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro

Valor do Juros deve ser consultado na API 1.

Tempo é um inteiro, que representa meses, também recebido como parâmetro

^ representa a operação de potência

Resultado final deve ser truncado (sem arredondamento) em duas casas decimais

Exemplo: /calculajuros?valorinicial=100&meses=5

Resultado esperado: 105,10

### 2) Show me the code
Este responde pelo path relativo /showmethecode

Deverá retornar a url de onde encontra-se o fonte no github


# Conceitos Utilizados

* AspNet Core 3.1 (WebApi)
* Swagger
* Docker
* Azure Web App
* GitHub Actions
* DDD (Domain-Driven-Design)
* SOLID
* TDD (Test-Driven-Developmen)
* Testes unitários
* Testes de integração
* Injeção de dependências


# Build e execução

Buildar imagem docker:

```bash
docker build --tag calculajurosapi:local .
```

Executar imagem gerada local:

```bash
docker run --publish 44343:80 --detach --name calculajurosapi calculajurosapi:local
```

Após a execução poderá ser acessado os seguintes endpoint:

http://localhost:44343

http://localhost:44343/showmethecode

http://localhost:44343/calculajuros?valorinicial=100&meses=5

