# Boas-vindas ao repositório do exercício Farm Classes!

Abaixo estão os desafios que cumpri.

# Requisitos

Parabéns, você recebeu de herança uma fazenda! 🚜🐄🐖

Entretanto, você não tem controle sobre os animais da fazenda, e depois de um mês tentando administrar tudo, percebe que está uma absoluta desordem!

Com isso, você decide usar seus conhecimentos em C# para organizar os diferentes tipos de animal em classes, para que assim consiga se organizar melhor. 
 
## 1 - Crie uma classe `Cow`

Primeiramente, vamos ao gado!

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Todos os animais da propriedade deverão possuir identificadores únicos. Por esse motivo vamos usar o tipo <code>Guid</code> para declarar a propriedade que conterá esses Ids.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Weight</code> do tipo <code>int</code></summary><br />

Você também precisa saber o peso de cada uma das vacas, então atribua um peso com `int`.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir uma propriedade pública <code>Breed</code> do tipo <code>string</code></summary><br />

Você também precisa saber qual a raça de cada uma das vacas para depois poder organizar o pasto. Atribua o nome da raça em uma `string`.
  
</details>

<details>
  <summary>A classe <code>Cow</code> deve possuir um construtor público que receba todos os valores das propriedades como parâmetros, exceto o <code>Id</code></summary><br />

Os valores dos parâmetros devem ter a mesma ordem das propriedades elencadas nesse requisito.
  
</details>

<details>
  <summary>O construtor da classe <code>Cow</code> deve <strong>validar</strong> e <strong>atribuir</strong> os valores das propriedades</summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `Weight` _menor ou igual a zero_ ou uma `Breed` que seja uma _`string` nula ou vazia_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Pronto, os bovinos já estão devidamente organizados. 🐮

## 2 - Crie uma classe `Pig`

Agora é a vez dos porcos!

<details>
  <summary>A classe <code>Pig</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Assim como com as vacas, deve ser possível atribuir um `Id` único para cada porco.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Pig</code> deve possuir uma propriedade pública <code>Age</code> do tipo <code>int</code></summary><br />

Temos muitos porcos jovens e idosos na fazenda. Atribuindo uma idade podemos organizá-los melhor.
  
</details>

<details>
  <summary>A classe <code>Pig</code> deve possuir um construtor público que receba a idade do porco como parâmetro</summary><br />  

A idade deve ser atribuída ao parâmetro correto.
</details>

<details>
  <summary>O construtor da classe <code>Pig</code> deve <strong>validar</strong> e <strong>atribuir</strong> os valores das propriedades</summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `Age` _menor que zero_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Agora já organizamos os bovinos e suínos. 🐮🐷

## 3 - Crie uma classe `Chicken`

Agora é a vez das galinhas!

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>Id</code> do tipo <code>Guid</code> com o valor padrão de <code>Guid.NewGuid();</code></summary><br />

Assim como com as vacas e porcos, deve ser possível atribuir um `Id` único para cada galinha.

> Se quiser saber mais sobre a estrutura <code>Guid</code>, nativa do C#, consulte a <a href="https://docs.microsoft.com/pt-br/dotnet/api/system.guid?view=net-6.0" target="_blank">documentação</a>.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>EggsPerWeek</code> do tipo <code>int</code></summary><br />

Precisamos saber quais galinhas são mais produtivas e quantas podem estar com algum problema de saúde. Uma boa métrica para isso é a quantidade de ovos por semana.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir uma propriedade pública <code>Mother</code> do tipo <code>Chicken?</code></summary><br />

Você achou que seria uma boa ideia traçar a genealogia materna das galinhas. Por isso, cada galinha poderá ter uma mãe atribuída, caso a mãe também seja parte da sua granja.

Caso contrário, o valor da mãe pode permanecer como `null`. Inclusive é por isso que usamos a interrogação após o tipo `Chicken`: ela permite atribuir o valor `null` a tipos de referência que normalmente não poderiam ser nulos.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir um construtor público que receba todos os valores das propriedades como parâmetros, exceto o <code>Id</code></summary><br />

Os valores dos parâmetros devem ter a mesma ordem das propriedades elencadas nesse requisito. Além disso, o parâmetro mother não precisa ser anulável, podendo ter o tipo `Chicken` sem a interrogação.
  
</details>

<details>
  <summary>A classe <code>Chicken</code> deve possuir, em paralelo, <strong>outro</strong> construtor público que receba o <code>EggsPerWeek</code> como parâmetro, mas que não receba nem o <code>Mother</code> nem o <code>Id</code></summary><br />

Nesse caso, não será necessário atribuir um valor à propriedade Mother, que deverá permanecer nula.
  
</details>

<details>
  <summary>Ambos os construtores da classe <code>Chicken</code> devem <strong>validar</strong> e <strong>atribuir</strong> os valores da propriedade <code>EggsPerWeek</code></summary><br />

A atribuição deve ocorrer no corpo do construtor para que ocorra no momento da inicialização dos objetos.

Caso seja passado um `EggsPerWeek` _menor que zero_, o construtor deve lançar uma `ArgumentException`.
</details>

<br />

Parabéns, você separou classes para todos os animais da fazenda. 🐮🐷🐔

Mas o trabalho ainda não acabou!

## 4 - Crie testes unitários pra todas as classes de animais
Agora precisamos ter certeza de que tudo ocorreu bem, então vamos aos Testes usando `xUnit` e `FluentAssertions`!

<details>
  <summary>Os testes devem ser criados na pasta <code>farm-classes.Test</code>, nos arquivos já criado para esse fim</summary><br />

Os arquivos dos testes são `ChickenTest.cs`, `CowTest.cs` e `PigTest.cs`.
  
</details>

<details>
  <summary>
  O <code>CowTest</code> deve testar se a classe <code>Cow</code> possui um construtor válido que atribui corretamente as propriedades <code>Weight</code> e <code>Breed</code>
  </summary><br />

O teste deve verificar:
- se o valor das propriedades é igual ao passado no construtor,
- se é lançada uma `ArgumentException` quando a classe recebe um `Weight` menor ou igual a zero
- se é lançada uma `ArgumentException` quando a classe recebe uma `Breed` nula ou vazia
</details>

<details>
  <summary>
  O <code>PigTest</code> deve testar se a classe <code>Pig</code> possui um construtor válido que atribui corretamente a propriedade <code>Age</code>
  </summary><br />

O teste deve verificar:
- se o valor da `Age` é igual ao passado no construtor,
- se é lançada uma `ArgumentException` quando a classe recebe uma `Age` negativa
</details>

<details>
  <summary>
  O <code>ChickenTest</code> deve testar se a classe <code>Chicken</code> possui um construtor válido que atribui corretamente as propriedades <code>EggsPerWeek</code> e, quando for o caso, <code>Mother</code>
  </summary><br />

O teste deve verificar:
- se o valor das propriedades é igual ao passado no construtor,
- se é possível instanciar a classe com e sem uma `Mother` 
- se é lançada uma `ArgumentException` quando a classe recebe um `EggsPerWeek` negativo
</details>

<br />

Agora sim, pode respirar fundo! Sua fazenda está muito mais gerenciável e as coisas estão começando a se encaixar!
