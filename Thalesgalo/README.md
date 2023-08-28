# Comando para rodar os testes
``` bat
dotnet.exe test D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNarcisista.Testes\BibliotecaNumerosNarcisista.Testes.csproj -v:Minimal -c:Debug -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:CoverletOutput=D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNarcisista.Testes\coverage.opencover.xml
``` 
# Comando para gerar o relatorio
``` 
dotnet reportgenerator -reports:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNarcisista.Testes\coverage.opencover.xml" -targetdir:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNarcisista.Testes\coveragereport" -reporttypes:Html -historydir:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNarcisista.Testes\coveragehistory" -Title:"BibliotecaNumerosNarcisista - Test report"
``` 