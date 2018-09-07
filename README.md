# MetroSPHelper
API informal para recuperar status do metro e trem(CPTM) da cidade de São Paulo

# How to
Utilizar a class static "Metro" para fazer as requests.

<pre lang="csharp">
var metro = await Metro.GetSituacaoMetroAsync();
var cptm = await Metro.GetSituacaCPTMAsync();
</pre>