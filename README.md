# WinForms API Test Application

[![.NET](https://img.shields.io/badge/.NET-10.0-blue.svg)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![GitHub](https://img.shields.io/badge/GitHub-Repository-black.svg)](https://github.com/vinicivs/WinFormsAppTesteAPINetCoreTreinamento)

## 📋 Descrição

Aplicação Windows Forms desenvolvida em **.NET 10** para testar consumo de APIs RESTful. O projeto demonstra a integração entre uma aplicação desktop WinForms e uma API externa, com foco em recuperação e exibição de dados de CEP.

## 🎯 Objetivos

- ✅ Consumir dados de uma API RESTful
- ✅ Exibir dados em um DataGridView
- ✅ Implementação de requisições HTTP assíncronas
- ✅ Tratamento de exceções
- ✅ Desserialização de dados JSON

## 🚀 Primeiros Passos

### Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/pt-br/download/dotnet/10.0) ou superior
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/downloads/) Community ou superior
- Windows 7 ou superior

### Instalação

1. **Clone o repositório:**
```bash
git clone https://github.com/vinicivs/WinFormsAppTesteAPINetCoreTreinamento.git
cd WinFormsAppTesteAPINetCoreTreinamento
```

2. **Abra o projeto no Visual Studio:**
```bash
# Via Visual Studio IDE ou linha de comando
start WinFormsAppTesteAPINetCoreTreinamento.slnx
```

3. **Restaure as dependências:**
```bash
dotnet restore
```

4. **Compile o projeto:**
```bash
dotnet build
```

5. **Execute a aplicação:**
```bash
dotnet run
```

## 📁 Estrutura do Projeto

```
WinFormsAppTesteAPINetCoreTreinamento/
├── Form1.cs                    # Formulário principal (FrmTesteJson)
├── Form1.Designer.cs           # Designer do formulário
├── Form1.resx                  # Recursos do formulário
├── Cep.cs                      # Classe modelo para CEP
├── Program.cs                  # Ponto de entrada da aplicação
├── WinFormsAppTesteAPINetCoreTreinamento.csproj  # Configuração do projeto
└── README.md                   # Este arquivo
```

## 💻 Componentes Principais

### Form1.cs (FrmTesteJson)
Formulário principal da aplicação que implementa a lógica de requisição HTTP.

**Recursos:**
- `BtnTeste_Click()`: Realiza requisição GET assíncrona à API
- `BtnSair_Click()`: Encerra a aplicação
- `DgvListagem`: DataGridView para exibição dos dados

**Exemplo de uso:**
```csharp
private async void BtnTeste_Click(object sender, EventArgs e)
{
    try
    {
        var ceps = await http.GetFromJsonAsync<List<Ceps>>("api/v1/Cep");
        DgvListagem.DataSource = ceps;
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro: {ex.Message}");
    }
}
```

### Cep.cs
Classe modelo (Data Transfer Object - DTO) para deserialização dos dados de CEP retornados pela API.

## 🔌 Integração com API

A aplicação consome dados de uma API local em desenvolvimento:

| Propriedade | Valor |
|---|---|
| **URL Base** | `https://localhost:7184/` |
| **Endpoint** | `/api/v1/Cep` |
| **Método HTTP** | GET |
| **Retorno** | Lista de objetos CEP em JSON |

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão | Descrição |
|---|---|---|
| **.NET** | 10.0 | Framework de desenvolvimento |
| **Windows Forms** | 10.0 | Framework para UI desktop |
| **HttpClient** | Nativo | Cliente HTTP para requisições |
| **System.Net.Http.Json** | Nativo | Serialização/Desserialização JSON |
| **Visual Studio** | 2026 (Community) | IDE de desenvolvimento |

## ⚙️ Configuração do Projeto

```xml
<PropertyGroup>
  <OutputType>WinExe</OutputType>
  <TargetFramework>net10.0-windows</TargetFramework>
  <Nullable>enable</Nullable>
  <UseWindowsForms>true</UseWindowsForms>
  <ImplicitUsings>enable</ImplicitUsings>
</PropertyGroup>
```

## 🤝 Contribuindo

Contribuições são bem-vindas! Para contribuir ao projeto:

1. **Faça um Fork** do repositório
2. **Crie uma branch** para sua feature (`git checkout -b feature/AmazingFeature`)
3. **Commit suas mudanças** (`git commit -m 'Add some AmazingFeature'`)
4. **Push para a branch** (`git push origin feature/AmazingFeature`)
5. **Abra um Pull Request**

## 📝 Licença

Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para detalhes.

## 👨‍💻 Autor

**Vinícius**
- GitHub: [@vinicivs](https://github.com/vinicivs)
- Repositório: [WinFormsAppTesteAPINetCoreTreinamento](https://github.com/vinicivs/WinFormsAppTesteAPINetCoreTreinamento)

## 📚 Recursos Adicionais

- [Documentação do .NET 10](https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-10)
- [Windows Forms em .NET](https://learn.microsoft.com/pt-br/dotnet/desktop/winforms)
- [HttpClient e JSON](https://learn.microsoft.com/pt-br/dotnet/fundamentals/networking/http/httpclient)
- [Async/Await em C#](https://learn.microsoft.com/pt-br/dotnet/csharp/asynchronous-programming/)

## 🐛 Problemas e Sugestões

Encontrou um bug ou tem uma sugestão de melhoria? [Abra uma Issue](https://github.com/vinicivs/WinFormsAppTesteAPINetCoreTreinamento/issues)

## 📈 Status do Projeto

- ✅ Funcionalidades básicas implementadas
- 🔄 Em desenvolvimento/Manutenção
- 📝 Documentação atualizada

---

**Última atualização:** Dezembro 2024
**Versão:** 1.0.0