 <img src="foto.jpg" alt="Imagem">
<h1>Aplicação de CRUD em C#, Bootstrap, jQuery, SQL Server e API</h1>
<h2>Descrição</h2>
Esta aplicação foi desenvolvida em C#, utilizando Bootstrap para o front-end, jQuery para manipulação de eventos, SQL Server para o banco de dados e uma API para comunicação entre o front-end e o back-end.
O objetivo é realizar operações de CRUD completo (Inserir, Alterar, Excluir e Selecionar) em um banco de dados. 
O exemplo utilizado é um cadastro de pessoa física com os seguintes campos: Nome completo, Data de nascimento, Valor da renda e CPF.
<h2>Instalação</h2>
Clone este repositório para o seu ambiente local.
Execute os scripts de criação da estrutura de dados no SQL Server para configurar o banco de dados.
<code>
CREATE DATABASE ClientesPF_PJ;
USE ClientesPF_PJ;
CREATE TABLE Pessoa_PF (
    Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    NomeCompleto nvarchar(100) NOT NULL,
    DataNascimento date NOT NULL,
    ValorRenda decimal(10, 2) NULL,
    CPF char(11) NOT NULL
);
</code>
Certifique-se de que as bibliotecas Bootstrap e jQuery estão incluídas em seu projeto e configuradas corretamente.
Verifique se a API está configurada e em execução.
<h2>Execução</h2>
Abra o projeto no Visual Studio.
Configure as conexões com o banco de dados e a API no arquivo de configuração do projeto.
Execute a aplicação.
Utilize a interface web(Bootstrap) para realizar operações de CRUD no banco de dados, utilizando a API para comunicação entre o front-end e o back-end.
