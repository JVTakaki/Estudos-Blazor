`CascatingValue` é um valor que pode ser passado para um ou mais *ChildComponent* esses por sua vez para acessar precisam se atentar a duas coisas importantes:
1. O nome dos componentes não importam e sim o Tipo (string, int, Model);
2. Caso o mesmo tipo seja utilizado esse será sobrescrito pelo ultimo lido exemplo:
```
<CascadingValue Value="@MessageForGrandChild">
    <CascadingValue Value="@LuckyNumber">
        <_ChildComponent OnButttonClick="ShowMessage" Title="Banana">
            <ChildSomeContent>Banana azul</ChildSomeContent>
            <ChildMoreContent>@MessageText</ChildMoreContent>
        </_ChildComponent>
    </CascadingValue>
</CascadingValue>
```
Nesse caso se ambos os `@MessageForGrandChild` e `@LuckyNumber` forem do tipo string apenas o valor do `@LuckyNumber` será herdado na cascata. Contudo é possível evitar isso e passar mais de uma string diferente:
```
<CascadingValue Value="@MessageForGrandChild" Name="Message">
    <CascadingValue Value="@LuckyNumber" Name="LuckyNumber">
        <_ChildComponent OnButttonClick="ShowMessage" Title="Banana">
            <ChildSomeContent>Banana azul</ChildSomeContent>
            <ChildMoreContent>@MessageText</ChildMoreContent>
        </_ChildComponent>
    </CascadingValue>
</CascadingValue>
```
Utilizando o *Name* é possível ignorar a limitação por tipo e assim enviar mais de um Valor em cascata para os componentes filhos. ficando assim a propriedade que vai utilizar o `MessageForGrandChild`:
`[CascadingParameter(Name="Message")] public string MessageForGrandChild { get; set; }`
