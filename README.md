# Visão Geral Projeto - Sistema de Gestão de Estoque

Um Sistema de Gestão de Estoque (SGE) é uma solução de software projetada para rastrear, gerenciar e otimizar os níveis de estoque de uma organização, além de supervisionar a operação de pedidos, armazenamento e entrega de produtos. Esses sistemas são essenciais para empresas que lidam com grandes volumes de produtos e necessitam de controle rigoroso para minimizar custos e maximizar a eficiência operacional.

## Contribute

[Alisson da Silva Pinto](https://github.com/DevAlissonPinto)
[Diego Ivan Mendes de Oliveira](https://github.com/diegoivanmendes)
[Vinicius Roberto de Oliveira Santos](https://github.com/vroliveira)


## Repositories
* Script SQL Data Base [link](https://github.com/DevAlissonPinto/AppAlmoxarifado/blob/master/AppAlmoxarifadoFiap.Infra.Repository/Sql/script_banco.txt)
* ASP.NET CORE BLAZOR  [link](https://github.com/DevAlissonPinto/AppAlmoxarifado)
* Teste de Integração com API Externa CEP 

## Development 

Para executar esse projeto você precisa seguir as etapas abaixo:

* Abrir a solution AppAlmoxarifado.sln com o visual studio 2022
* Configurar o projeto AppAlmoxarifado.Web para serem executado como startup projects
* Abri Package Manager Console e deixar como Defult project: 'Infra\AppAlmoxarifado.Infra.Repository' e executar o comando Update-Database
* Executar o projeto pressionando o F5

### AppAlmoxarifado.Tests

Este projeto de teste é construído usando xUnit.NET para testar o aplicativo ASP.NET Core AppAlmoxarifado, Ele contém testes automatizados para garantir o funcionamento correto do aplicativo.

## Configuração

Certifique-se de ter .NET Core 8 SDK instalado e VS 2022 community.

### Como Executar os Testes

1. Abra o terminal.
2. Navegue até o diretório do projeto de teste (AppAlmoxarifado.Tests).
3. Execute o seguinte comando: dotnet test
