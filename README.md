# Avaliação - Programação Avançada em C# - Módulo D3
Desenvolver uma aplicação de controle de acesso que irá validar as credenciais do usuário ao acessar o sistema e, em caso de sucesso, alimenta um arquivo de texto com os dados deste usuário.

## Como testar?
Clone esse repositório com o auxílio do Visual Studio, suba o banco de dados e com o SQL Server Management Studio, execute a [query do banco de dados](./izaiasmachado-d3-avaliacao.sql) para criar um novo banco de dados, uma tabela e também o usuário administrador. 

## Tecnologias Usadas

### Ferramentas
- [Visual Studio Community](https://visualstudio.microsoft.com/pt-br/downloads/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio](https://docs.microsoft.com/pt-br/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

### Bibliotecas Nuget
- [Bcrypt](https://github.com/BcryptNet/bcrypt.net)
- [SQL Client](https://www.nuget.org/packages/System.Data.SqlClient)

## Implementação
### Singleton para o Log
Como o log de saída é gravado em um arquivo, existe o compartilhamento de um mesmo arquivo em várias partes do código. Portanto, o log foi implementado usando o singleton para que possa haver uma única instância de acesso global a [classe que realiza a escrita do log](./Models/Log.cs).

### Diagrama de Estados da Interface de Usuário
A sucessão de telas da interface do usuário foi feita por meio do [state pattern](https://refactoring.guru/pt-br/design-patterns/state). Nesse sentido, foi criada uma interface [IScreen](./Interfaces/IScreen.cs) que define que todas as telas devem possuir um método show que retorna uma tela. Desse modo, é possível utilizar o polimorfismo para tratar todas as classes utilizando a interface implementada.

A sucessão é feita na [classe principal](./Program.cs) utilizando um loop while, e só acaba quando uma tela for nula. A única classe que retorna telas nulas é a a [CloseSystemScreen](./Views/CloseSystemScreen.cs).

![Diagrama de Estados](https://i.ibb.co/9TybKLZ/state-diagram-screens-drawio-2.png)

## Especificações
- Ao executar a aplicação, deverá ser apresentada uma interface de console com um menu e as seguintes opções: acessar e cancelar.
- Caso o usuário escolha cancelar, a aplicação será encerrada.
- Caso escolha acessar, será solicitado o e-mail e em seguida a senha do usuário. Se os dados não forem válidos, uma mensagem deverá ser exibida na tela e um novo acesso solicitado.
- Com as credenciais corretas, o usuário loga na plataforma. Isso implica na exibição de uma mensagem de sucesso e um novo menu com as opções: deslogar e encerrar sistema.
- Além disso, será feito o registro em um arquivo de texto contendo o id do usuário, o nome do usuário e a data/hora de autenticação.
- Neste novo menu, caso o usuário escolha deslogar, será redirecionado ao menu inicial (acessar e cancelar). Ao escolher encerrar sistema, a aplicação será finalizada.
- Usuário padrão para acesso ao sistema:
  - Email: admin@email.com / Senha: admin123

### **Observações**
- Os dados do usuário deverão ser salvos em um banco de dados. Os campos mínimos para esta entidade são: Id, Nome, Email e Senha. Fique à vontade para acrescentar mais campos, caso queira.
- Atente-se ao tipos de dados destes campos, tanto no banco de dados quanto no back-end.
- O arquivo de texto poderá ser no formato .txt ou .csv, ao seu critério.
- Sugestão de registro de acesso: O usuário NOME (ID) acessou o sistema às HORA do dia DATA.
- Ao concluir o desafio, anexe em um arquivo ou em uma pasta zipada todo o conteúdo desenvolvido, inclusive o script do banco de dados.
- Nomeie a pasta/repositório, a solução e o banco de dados como seunome-d3-avaliacao.
- Não é obrigatório utilizar um design pattern específico para a resolução, porém mantenha uma organização mínima da estrutura do projeto, como visto em aula, seguindo as boas práticas de programação.

### Extras
- Quando o usuário deslogar da plataforma, alimentar o arquivo de texto com os dados do usuário e a data/hora em que saiu da plataforma. Isso significa que o registro ao logar e o registro ao deslogar devem ser diferentes. Por exemplo: Usuário X logou no sistema às Y horas / Usuário X deslogou no sistema às Z horas.
- Criptografar a senha salva no banco de dados.
