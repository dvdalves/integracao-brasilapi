# API de Integração com BrasilAPI

Essa API permite a integração com a BrasilAPI para buscar informações sobre bancos e endereços por CEP.

## Endpoints

### Buscar Todos os Bancos

Retorna uma lista de todos os bancos disponíveis.

- **Endpoint:** `/api/bancos`
- **Método:** `GET`
- **Retorno:** Lista de objetos representando informações sobre os bancos.

### Buscar Banco por Código

Retorna informações de um banco específico com base no seu código.

- **Endpoint:** `/api/bancos/{codigo}`
- **Método:** `GET`
- **Parâmetros:**
  - `codigo`: O código do banco desejado.
- **Retorno:** Objeto representando informações sobre o banco correspondente ao código fornecido.

### Buscar Endereço por CEP

Retorna informações de endereço com base no CEP fornecido.

- **Endpoint:** `/api/enderecos/busca/{cep}`
- **Método:** `GET`
- **Parâmetros:**
  - `cep`: O CEP para o qual deseja-se obter informações de endereço.
- **Retorno:** Objeto representando informações sobre o endereço correspondente ao CEP fornecido.

## Tecnologias Utilizadas
- .NET 8
- C#
- Automapper
- DTOs
- Interfaces
- Models
- Services
- Swagger
- Injeção de Dependência
- Classe Genérica de Response

## Utilização

Para utilizar essa API, você pode realizar requisições HTTP para os endpoints mencionados acima. Aqui está um exemplo usando cURL:

```bash
# Buscar todos os bancos
curl -X GET https://sua-api.com/api/bancos

# Buscar banco por código
curl -X GET https://sua-api.com/api/bancos/123

# Buscar endereço por CEP
curl -X GET https://sua-api.com/api/enderecos/busca/CEP_DESEJADO


