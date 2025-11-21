A página `.razor` está presente no projeto publico no seguinte [repositório](https://github.com/GeovaniPrestes/Estudos-Blazor) no projeto BlazorAppTest a página em questão será a `BindProp.razor` nela estão algumas das coisas que pretendo abordar e explicar detalhadamente de acordo com o meu entendimento a respeito de colocar componentes na tela que podem ser atualizados pelo usuário ou pelo próprios servidor em tempo real.

Primeiro de tudo vamos dissecar o arquivo em si: começando por  sua primeira linha:
`@page "/LearnBlazor/BindProp";`
Está linha cria exatamente uma rota para acessar o arquivo `.razor`. 
Por fim começa uma linha de códigos básicos de Html utilizando do framework bootstrap para poder trabalhar melhor com o design da página, contudo pode-se notar algumas linhas um tanto quanto interessantes como:
`Is Active: <input type="checkbox" @bind="@Product.IsActive" /> <br />`
Nesta linha pode-se notar que existe um `@bind` este por sua vez é o que faz ser possível a ligação entre o Html e o C#,
assim que se nota que o `@Product.IsActive` se trata de uma classe com propriedades do C#:

```
public class Product
{
    public int IdProduct { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<ProductProp> ProductProp { get; set; }
}  
```
Esta classe por sua vez não pode ser acessada diretamente ou importando de forma "convencional" semelhante ao C#, é necessário ou `Models.Product` ou adicionar um `@using Models;` no topo do arquivo. E você pode estar se perguntado, no arquivo utilizado de exemplo não existe nenhuma dessas opções abordadas agora, então como esse projeto poderia estar correto? A resposta se encontra no arquivo `_Imports.razor` um arquivo nativo do próprio <font color="#7030a0">Blazor</font> que realiza exatamente o que seu nome diz ele é a raiz para toda e qualquer importação dentro do projeto portanto, qualquer `@using` que estiver nele pode ser utilizado por qualquer página criada sem a necessidade de ficar importando a mesma classe em locais diferentes do projeto economizando assim tempo de desenvolvimento e linhas de códigos.
Vale ressaltar que caso ainda não esteja claro ao analisar o código inicial demonstrado, quando é necessário acessar uma propriedade seja ela uma model ou um simples foreach é utilizado o @ para demonstrar que aquele deve ser compilado e não lido como um simples Html. Seria semelhante ao `echo` do Php onde dependo de se utiliza '' ou "" o comportamento da string escrita nele tende a variar.