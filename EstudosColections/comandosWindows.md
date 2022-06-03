# Criando um projeto c# usando vscode

Abrir a pasta > abrir o cmd naquela pasta:
Depois de criar uma solução, criar o projeto na pasta

1. Uma solution serve para agrupar um ou mais projetos. É a primeira etapa deste processo;

dotnet new sln --name Colecoes

2. Criar projeto

dotnet new console --name Colecoes

3. Adicionar o projeto na solução criada:

dotnet sln add Colecoes/Colecoes.csproj

4. Abrir a pasta com code

code .

5. Instalar as extensões

C# Microsoft, C# Extensions, vscode-icons

6. Habilitar o Intellisense:

No VScode: clicar F1: OminiSharp: Select Project
Vai mostrar duas opções: escolha a opção com a solução (Colecoes.sln) e confirma

7. Escreva qualquer codigo. Para rodar, entre na pasta com o arquivo *.csproj e digite:
dotnet run








