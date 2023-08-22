# Sobre esse repositório
Esse repositório visa dar suporte ao aprendizado de conceitos-chave para desenvolvimento de software

# Procurando números narcisistas Narcissistic Number

Esse repositório foi criado inspirado em um post da página Fermat's Library sobre os números narcisistas. O link para o post pode ser visto abaixo:

https://www.linkedin.com/feed/update/urn:li:activity:7098654583048015873/

O objetivo desse projeto de aprendizado é desenvolver uma biblioteca (ou pacote - https://www.geeksforgeeks.org/how-to-build-a-python-package/) que descubra todos os números narcisistas existentes entre dois números a e b, sendo b > a e também diga se um número w é narcisista ou não.

Essa biblioteca deve ter uma aplicação console que a acompanhe no mesmo repositório. Um README com as instruções básicas de como executar a aplicação console, incluindo as dependências, deve estar presente também.

Tanto a biblioteca quanto a aplicação console devem ser criadas sob uma pasta com o mesmo nome que seu usuário no GitHub. No meu caso, os arquivos estariam organizados sob disouzam como ilustrado abaixo (nomes fictícios, divisão de subpastas sugerida para projetos em C#, para projetos em Python, somente a pasta principal deve ser seguida estritamente):

disouzam
|--Library
|   |-- file1.cs
|   |-- file2.cs
|   |-- library.csproj
|--Tests
|   |-- file1Tests.cs
|   |-- file2Tests.cs
|   |-- library.tests.csproj
|--Console
|   |-- Program.cs
|   |-- Util.cs
|   |-- console.csproj

A biblioteca deve conter uma suíte de testes e garantir 100% de cobertura de testes (baseado em branches).

# Carga de dados de exemplo
Carga de dados com 88 números narcisistas: 
- https://oeis.org/A005188/b005188.txt

# Referências:
- https://oeis.org/A005188/
- https://oeis.org/A005188/a005188_1.pdf, 
- http://web.archive.org/web/20180303194332/
- http://www.magic-squares.net:80/narciss.htm#Perfect%20Digital%20Invariants
- https://www.fq.math.ca/Scanned/30-3/miller.pdf
- https://opensource.guide/starting-a-project/
- https://opensource.guide/how-to-contribute/