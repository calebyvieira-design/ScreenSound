# ScreenSound

Aplicação de console em C# para cadastrar bandas e álbuns, registrar avaliações e consultar detalhes musicais. O projeto usa .NET 6.

## Como executar

```bash
dotnet run --project ScreenSound/ScreenSound.csproj
```

## Como o código funciona

- `Program.cs` mantém as bandas em um `Dictionary` e associa cada opção numérica a um menu.
- `Modelos/Banda.cs`, `Album.cs`, `Musica.cs` e `Avaliacao.cs` representam o domínio musical.
- `Modelos/IAvaliavel.cs` define o contrato para entidades que recebem avaliações.
- `Menus/` contém as ações de registrar bandas e álbuns, avaliar, listar e exibir detalhes.
- `Menu.cs` é a abstração compartilhada pelos menus da aplicação.

O fluxo é interativo: o usuário escolhe uma operação, o menu executa sobre o dicionário de bandas e, enquanto a opção não for sair, o menu principal é exibido novamente.
