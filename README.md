# Desafio Copa do Mundo 2022
## Grupo 2
### Equipe

| [![Augusto (Gusto) Moreira](https://lh3.googleusercontent.com/drive-viewer/AJc5JmRPtFX7XgdiuPNBrXFu97_Kf-EVfA5TvnFLN_LDrXJaMjXgF1IAnxp9vLHPj4HOrdQx-XYrzv0=w1920-h880 "Augusto (Gusto) Moreira")](https://www.linkedin.com/in/carlos-a-moreira/ "Augusto (Gusto) Moreira")  | [![Christian das Neves Moreira](https://lh3.googleusercontent.com/drive-viewer/AJc5JmSPz_Y85DkFSAsLIaIoEhabUl6pLHPGnPyuxpjXlNJ7S96UTIhm1krse28ckbO535bhEr88rfA=w1920-h880 "Christian das Neves Moreira")](https://www.linkedin.com/in/christian-das-neves-moreira-1a7bab154/ "Christian das Neves Moreira")  | [![João Carlos Rebouças](https://lh3.googleusercontent.com/drive-viewer/AJc5JmSWBLt8TDRzRCuUftaLciXhMjpgVp5apzbwAnDw4VFCgsfJw-3LqW_6ItThgUoXWHc08sQuPq4=w1920-h880 "João Carlos Rebouças")](https://www.linkedin.com/in/jo%C3%A3o-carlos-rebou%C3%A7as-321ab1225/ "João Carlos Rebouças")  | [![Rafael Seiffer Melazzo](https://lh3.googleusercontent.com/drive-viewer/AJc5JmRRRBMx96C8TJuqUI6MHNgr2cIZtYsx86RjAUyL3GgAvnmG6DjuPTwXpyYU29mLfKuX87KAt3E=w1920-h880 "Rafael Seiffer Melazzo")](https://www.linkedin.com/in/rafael-melazzo/ "Rafael Seiffer Melazzo")  | [![Ricardo Bono da Silva](https://lh3.googleusercontent.com/drive-viewer/AJc5JmTjVTdyqjem3dk6ZmEmT7FmiFL0R_dgkO-IMMUPM4EBWelT--4Gu4GBxevKKbKOWnr30veE4JY=w1920-h880 "Ricardo Bono da Silva")](https://www.linkedin.com/in/ricardobono/ "Ricardo Bono da Silva")  |
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
