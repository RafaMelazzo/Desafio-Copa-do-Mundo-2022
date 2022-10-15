# Desafio Copa do Mundo 2022
## Grupo 2
### Equipe

| [![Augusto (Gusto) Moreira](https://lh3.googleusercontent.com/drive-viewer/AJc5JmTc36SmFKWPvubhYf0s2o1KJzTg16p8UHV2D3-a2WI7py9-vaasOTpd6f3ChwVaLhINsKjbYes=w1920-h937 "Augusto (Gusto) Moreira")](https://www.linkedin.com/in/carlos-a-moreira/ "Augusto (Gusto) Moreira")  | [![Christian das Neves Moreira](https://lh3.googleusercontent.com/drive-viewer/AJc5JmQZnLIb3tbNKFtBq56_CzTdxPRCnw7AdoLQq3psIC51u3AHc8aDJCh0SH8Dzs6HEXd6zNvdWvw=w1920-h880 "Christian das Neves Moreira")](https://www.linkedin.com/in/christian-das-neves-moreira-1a7bab154/ "Christian das Neves Moreira")  | [![João Carlos Rebouças](https://lh3.googleusercontent.com/drive-viewer/AJc5JmTnB66im3YiFHvd6o0Gb2AnFzcL0TjVcZUisMlsw6qiqczcAX6UHWObbLDp7jdoXHu2ZT8I1P8=w1920-h880 "João Carlos Rebouças")](https://www.linkedin.com/in/jo%C3%A3o-carlos-rebou%C3%A7as-321ab1225/ "João Carlos Rebouças")  | [![Rafael Seiffer Melazzo](https://lh3.googleusercontent.com/drive-viewer/AJc5JmSX4a33ZSyeX14Z7O4POmsnyLhgnX0RMpsgvw2Fku3QzE06Jr36PHZz3KOTWB3a-jrATYJ3sqw=w1920-h880 "Rafael Seiffer Melazzo")](https://www.linkedin.com/in/rafael-melazzo/ "Rafael Seiffer Melazzo")  |   |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| Augusto (Gusto) Moreira  | Christian das Neves Moreira  |  João Carlos Rebouças | Rafael Seiffer Melazzo  | Ricardo Bono da Silva  |

------------

### Como Instalar
#### Configurando o Banco de Dados
1. Configure a strig de conexão no arquivo ***appsettings.json***, na linha 11. Exemplo:

  `Server=localhost;Database=copa_do_mundo_2022;Uid=<USUÁRIO>;Password=<SENHA>;`

2. Execute os seguintes comandos no projeto:
```
1. dotnet ef migrations add InitialCreate
2. dotnet ef database update
```
