# InvestmentControl

<img src="wwwroot/img/docVideo.gif" width="800px">

## Visão Geral

O **InvestmentControl** é um sistema web para controle e visualização de investimentos, permitindo cadastro, edição, exclusão, consulta e análise gráfica dos dados financeiros. O sistema foi desenvolvido com foco em usabilidade, responsividade e boas práticas de arquitetura de software.

---

## Tecnologias Utilizadas

- **.NET 9**  
  Plataforma principal para desenvolvimento web, garantindo performance, segurança e escalabilidade.

- **C# 13**  
  Linguagem utilizada para toda a lógica de backend, controllers, repositórios e modelos.

- **Blazor**  
  Framework para construção de interfaces web interativas utilizando C# no frontend, priorizando componentes Blazor quando aplicável.

- **ASP.NET Core MVC**  
  Utilizado para organização das views, controllers e rotas do sistema.

- **Entity Framework Core**  
  ORM para acesso e manipulação do banco de dados relacional de forma tipada e segura.

- **Bootstrap 5**  
  Framework CSS para responsividade, layout e componentes visuais modernos.

- **Bootstrap Icons**  
  Biblioteca de ícones vetoriais para enriquecer a interface do usuário.

- **Chart.js**  
  Biblioteca JavaScript para geração de gráficos dinâmicos (barras, doughnut, etc.) integrados via interop.

- **jQuery**  
  Utilizado para manipulação de DOM e integração com plugins JavaScript.

- **Newtonsoft.Json**  
  Serialização e desserialização de dados para integração entre backend e frontend (especialmente para gráficos).

---

## Arquitetura do Projeto

O projeto segue uma arquitetura baseada em camadas, promovendo separação de responsabilidades e facilidade de manutenção:

```
    InvestmentControl
    │
    ├── Controllers
    │   └── Responsáveis pelo fluxo de requisições HTTP, validação inicial e orquestração das operações.
    │
    ├── Models
    │   └── Entidades que representam as tabelas do banco de dados.
    │
    ├── ViewModels / DTOs
    │   └── Objetos de transferência de dados entre as camadas, incluindo validações e formatações.
    │
    ├── Repositories
    │   └── Implementação do padrão Repository para abstração do acesso a dados (CRUD, consultas customizadas).
    │
    ├── Data
    │   └── Contexto do Entity Framework Core (DbContext) e configuração do banco de dados.
    │
    ├── Views
    │   └── Páginas Razor para renderização da interface do usuário, com integração a componentes Blazor quando necessário.
    │
    ├── Attributes
    │   └── Validações customizadas utilizando DataAnnotations.
    │
    ├── wwwroot
    │   └── Arquivos estáticos: CSS, JS, imagens, bibliotecas de terceiros.
    │
    └── Program.cs / Startup.cs
        └── Configuração de serviços, middlewares e dependências do sistema.

```


---

## Funcionalidades Principais

- Cadastro, edição e exclusão de investimentos.
- Listagem paginada e ordenada de investimentos.
- Busca por nome e filtros dinâmicos.
- Validações customizadas (ex: valor maior que zero, data não futura).
- Visualização gráfica dos investimentos por tipo (barras e doughnut).
- Dashboard com cards de resumo e últimos investimentos cadastrados.
- Interface responsiva e moderna.

---

## Observações

- O sistema prioriza o uso de componentes Blazor quando aplicável, mas mantém compatibilidade com Razor Pages e MVC.
- As integrações JavaScript (ex: Chart.js) são feitas via interop ou scripts dedicados.
- O código segue boas práticas de separação de responsabilidades, facilitando testes e manutenção.

---

## Como Executar

1. Configure a string de conexão do banco de dados no `appsettings.json`.
2. Execute as migrações do Entity Framework Core para criar o banco.
3. Compile e execute o projeto via Visual Studio 2022 ou CLI do .NET 9.
4. Acesse `https://localhost:xxxx` no navegador.

---



