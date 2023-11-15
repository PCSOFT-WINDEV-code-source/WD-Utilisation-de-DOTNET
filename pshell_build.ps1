$msbuild = (Get-ItemProperty hklm:\software\Microsoft\MSBuild\ToolsVersions\4.0).MSBuildToolsPath
$MyDir = [System.IO.Path]::GetDirectoryName($myInvocation.MyCommand.Definition) 
. "$msbuild\msbuild.exe" "$MyDir\Convertisseur Euro c#\Convertisseur Euro\Convertisseur Euro.csproj" /t:Build /p:Configuration=Release /p:Platform=x86
