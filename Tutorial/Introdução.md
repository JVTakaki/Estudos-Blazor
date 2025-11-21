<font color="#7030a0">Blazor</font> é um framework SPA do ASP.NET Core que utiliza **Razor Components** como modelo de UI. Ele permite executar código **.NET** tanto no cliente quanto no servidor através de dois modelos principais: **Blazor Server** (renderização interativa via SignalR) e **Blazor WebAssembly** (execução .NET IL no navegador via WebAssembly).
O <font color="#7030a0">Blazor</font> pode vir a ser utilizado de 3 formas:
1. Blazor Server: uma aplicação que roda em tempo real no navegador. Carregamento rápido e leve para a maquina do cliente, contudo é totalmente dependente da conexão da internet do usuário, além de poder sobrecarregar o servidor no qual está hospedado.
2. Blazor WebAssembly (WASM): Um app baixado pelo cliente que roda diretamente no navegador em WebAssembly. Não depende de servidor contudo as primeiras vezes que ele carrega são um tanto quanto demoradas dependendo do tamanho do projeto.
3. Blazor Hybrid: Perfeito para apps Desktop/Mobile (MAUI), uma mistura de C# com Html.

### Características técnicas principais:
- **Component Model:**  
    Baseado em Razor, com renderização incremental, diff virtual DOM e ciclo de vida (OnInitialized, OnParametersSet, OnAfterRender).
- **Renderização:**  
    _Server:_ eventos são enviados por SignalR e HTML atualizado vem do servidor.  
    _WASM:_ tudo executa no navegador, interpretando IL através do runtime .NET WASM.
- **Routing:**  
    Implementado via `<Router>` que mapeia rotas para componentes.
- **Dependency Injection:**  
    Mesmo container do ASP.NET Core (`IServiceCollection`).
- **State Management:**  
    Controle via cascading parameters, session/local storage, serviços Singleton/Scoped, ou bibliotecas externas.
- **Interoperabilidade:**  
    JSInterop permite chamada de funções JS ⇄ C#.
- **Build:**  
    Empacotamento otimizado, lazy loading, AOT para WebAssembly.

## Como funciona
Blazor funciona com **componentes**, que são arquivos `.razor`.
Cada componente pode ter:
- HTML
- C#
- Eventos (onClick, onChange…)
- Injeção de serviços
- Ciclo de vida (OnInitialized, OnParametersSet…)

Exemplo de código que vem por padrão na criação do projeto Blazor:
```
@page "/counter"

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">Click me</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }
}

```
## Principais vantagens do Blazor
- C# no frontend (sem JS obrigatório)
- Reutilização de código
- Curva de aprendizado curta para quem já usa .NET
- Componentização de verdade
- Suporte completo a DI, Routing, Forms, Validations…
- Blazor usa **HttpClient** nativamente, integrando com Web APIs de forma fácil.
- Excelente para utilizar:
	- Painéis administrativos
	- Sistemas internos
	- ERPs
	- Ferramentas web corporativas
	- Aplicações SPAs modernas para empresas