Sistema de Leilões Online

Este é um sistema de leilões online desenvolvido em C# com .NET 8, integrado com um banco de dados SQLite para armazenar informações sobre os leilões, ofertas e usuários. 
O sistema permite a criação de leilões com datas de início e término, bem como a realização de ofertas pelos usuários autenticados.


Requisitos
.NET 8 SDK
Visual Studio, Visual Studio Code ou Rider


Instalação e Execução
1 - Clone o repositório: https://github.com/Matuzen/Auction.git

2 - Abra o projeto no Visual Studio, Visual Studio Code ou Rider

3 - Baixe o sqlitebrowser: https://sqlitebrowser.org/dl/

4 - Ao fazer o clone do repositório, dentro da pasta raiz você encontrará o banco de dados com o nome: leilaoDbNLW, abra-o com o SQLite Browser

5 - No projeto em Program troque o caminho do banco de dados para onde você baixou: options.UseSqlite(@"Data Source=C:\dev\RocketseatAuction\leilaoDbNLW.db");

6 - Execute o projeto.


Funcionalidades
Autenticação: os usuários podem se autenticar para acessar o sistema.

Autorização: diferentes níveis de acesso são definidos para os usuários (admin, usuário comum).

Criação de Leilões: os usuários podem criar novos leilões, definindo data de início, data de término e descrição.

Realização de Ofertas: os usuários autenticados podem fazer ofertas nos leilões disponíveis.

Listagem de Leilões: os usuários podem ver os leilões disponíveis, incluindo informações sobre as ofertas feitas e o status do leilão.
