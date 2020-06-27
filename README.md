# Web API CalcTest
![.NET Core](https://github.com/RodrigoPrandi/CalcTest/workflows/.NET%20Core/badge.svg?branch=master)

# Sistema criado para atender as seguintes necessidades:

Criar uma API com dois endpoints:

###  1) Calcula Juros
A primeira reponde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo:
Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro
Juros é 1% ou 0,01 (fixo no código)
Tempo é um inteiro, que representa meses, também recebido como parâmetro
^ representa a operação de potência
Resultado final deve ser truncado (sem arredondamento) em duas casas decimais

Exemplo: /calculajuros?valorinicial=100&meses=5
Resultado esperado: 105,10

### 2) Show me the code
Este responde pelo path relativo /showmethecode
Deverá retornar a url de onde encontra-se o fonte no github


# Conceitos Utilizados

* AspNet Core 2.1 (WebApi)
* Swagger
* Docker
* Azure Web App
* AppVeyor
* DDD (Domain-Driven-Design)
* SOLID
* TDD (Test-Driven-Developmen)
* Testes unitários
* Testes de integração
* Injeção de dependências

## Servidor Web Api

https://rodrigoprandicalctest.azurewebsites.net/
