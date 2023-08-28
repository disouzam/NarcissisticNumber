# Comando para rodar os testes
``` bat
dotnet.exe test D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNascisista.Testes\BibliotecaNumerosNascisista.Testes.csproj -v:Minimal -c:Debug -p:CollectCoverage=true -p:CoverletOutputFormat=opencover -p:CoverletOutput=D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNascisista.Testes\coverage.opencover.xml
``` 
# Comando para gerar o relatorio
``` 
dotnet reportgenerator -reports:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNascisista.Testes\coverage.opencover.xml" -targetdir:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNascisista.Testes\coveragereport" -reporttypes:Html -historydir:"D:\GitHubRepos\NarcissisticNumber\Thalesgalo\BibliotecaNumerosNascisista.Testes\coveragehistory" -Title:"BibliotecaNumerosNascisista - Test report"
``` 