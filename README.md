# Agenda Telefônica
### 💻 Sobre o projeto
Aplicação de agenda telefônica capaz de incluir, editar, excluir e exibir os registros cadastrados com dados armazenados em memória.
### ⚙️ Funcionalidades
- [x] Contatos podem ser registrados contendo as seguintes informações:
  - [x] Nome
  - [x] Telefone
  - [x] Endereço
  ## 🚀 Como executar o projeto
Este projeto possui apenas Backend.

### Pré-requisitos
Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[Visual Studio 2019 16,8 ou posterior](https://visualstudio.microsoft.com/pt-br/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019), [SDK do .NET 5 ou posterior](https://dotnet.microsoft.com/download/dotnet/5.0) 
Além disto, será preciso adicionar os seguintes pacotes no Visual Studio: 
* Microsoft. EntityFrameworkCore. SqlServer
* Microsoft. EntityFrameworkCore. inmemory

#### 🎲 Rodando o Backend

```bash

# Clone este repositório
$ git clone git@github.com:mgbatista/agenda-telefonica.git

# Acesse a pasta do projeto no terminal/cmd
$ cd agenda-telefonica

# Abra o arquivo AgendaTelefonica.sln
$ clique duas vezes no arquivo, ele será aberto com o Visual Studio

# Selecione o projeto do lado direito
$ pressione Ctrl + F5 para execução sem o depurador

# O servidor inciará em uma porta aleatória
$ acesse https://localhost:<porta>/api/Contatos

```
#### 🧭 Testando a API através do Postman
* Inicie a aplicação (selecione o projeto e pressione Ctrl + F5)
	
	### Método Post
	* Defina o URI como  `https://localhost:<port>/api/Contatos`.
	* O corpo da solicitação deve ser um JSON do seguinte formato:
		```JSON
		{
			"Nome": "Lucas",
			"Telefone": "33965822",
			"Endereco": "Rua Vereador, 25 Jardim Pereira"
		}
		```
		>Se a requisição for bem sucedida, deve retornar **201 Created**, será gerado um Id automaticamente e no corpo da requisição será retornado o Id e as informações, como no exemplo abaixo:
		```JSON
		{
			"Id": 1,
			"Nome": "Lucas",
			"Telefone": "33965822",
			"Endereco": "Rua Vereador, 25 Jardim Pereira"
		}
		```

	### Método GET
	* Defina o URI como  `https://localhost:<port>/api/Contatos` para trazer uma matriz de JSON com todos os registros.
	* Defina o URI como  `https://localhost:<port>/api/Contatos/<Id>/` para trazer um JSON com o registro do referente Id.

	### Método Put
	* Deverá haver pelo menos um item no banco de dados antes de você fazer uma chamada PUT, e no Body você deverá informar todos os campos, mesmo aqueles que não sofrerão alteração, caso contrario, o valor dos campos passará a ser null.
		>Se a requisição for bem sucedida, deve retornar **204 No Content**.
	### Método Delete
	* Defina o URI do objeto a ser excluído`	https://localhost:<port>/api/Contatos/<Id>`
		>Se a requisição for bem sucedida, deve retornar **204 No Content**.

### 🛠 Linguagem
Foi utilizada para criação do projeto a linguagem C#
### 🦸 Autor

<a href="https://www.linkedin.com/in/maiarabueno/">
 <img style= "border-radius: 50% ;" src="https://media-exp1.licdn.com/dms/image/C4D03AQFu5rygQlkRpw/profile-displayphoto-shrink_200_200/0/1575936867043?e=1615420800&v=beta&t=_ujeVwcMiFhS9ue_whn1egOHj7zG-OXE1JLdmIZU3ic"/>
 <br />
 <sub><b>Maiara Batista</b></sub></a> <a href="https://www.linkedin.com/in/maiarabueno/" 
 <br />
 
### 📝 Licença

Este projeto esta sob a licença [MIT](./LICENSE).
