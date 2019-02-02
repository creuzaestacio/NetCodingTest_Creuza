# NetCodingTest_Creuza

OBS:
Banco de Dados SQL SERVER.
Alterar a string de conexão (usuário e senha) que esta no arquivo "EmployeeManagerAPIContext" no projeto Icatu.EmployeeManagerAPI.Data, no diretório Context.
No Packege Manager Console executar o comando [update-database] para criar o banco de dados atraves do migration.


Desenvolvi uma web api rest para incluir(POST), alterar(PUT), excluir(DELETE) e listar(GET) os dados.
A arquitetura DDD(Domain Driven Design) gerencia a modelagem do sistema.
--Application: Gerencia a entrada dos dados atraves das açoes(verbos):GET,POST,PUT,DELETE;
--Service: Projeto para transitar os dados entre Application e Data;
--Data : Projeto responsavel pela entrada/saida de dados atraves do entity framework;
--Domain: Projeto para gerenciar as entidade;


Utilizei o swagger para testar a api que também pode ser testada pelo postman.
A propriedade chave da entidade(employee) foi criada como tipo de dados "Guid", não informar no Json de entrada da ação POST.

