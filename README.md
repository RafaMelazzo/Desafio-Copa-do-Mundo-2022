# Desafio Copa do Mundo 2022
## Grupo 2
### Equipe

------------

### Como Instalar
#### Configurando o Banco de Dados
1. Configure a strig de conexão no arquivo ***appsettings.json***, na linha 11. Exemplo:

  `Server=localhost;Database=copa_do_mundo_2022;Uid=<USUÁRIO>;Password=<SENHA>;`

2. Execute os seguintes comandos no projeto:

  `dotnet ef migrations add InitialCreate`

  `dotnet ef database update`
