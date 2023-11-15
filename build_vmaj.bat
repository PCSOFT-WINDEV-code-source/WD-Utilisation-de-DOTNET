@REM Build WD Utilisation de DONET
@set MAJOR_VERSION=23

@REM Supprime les DLL des versions précédentes
del ".\Convertisseur Euro c#\Convertisseur Euro\wd*.dll" /S /F /Q
rd ".\Convertisseur Euro c#\Convertisseur Euro\bin" /S /Q

@REM Crée le .csproj avec la référence vers la librairie WDxxxNET2.DLL de la version courante
type ".\build.csproj" | build_repl "XXX_VERSION_XXX" %MAJOR_VERSION% > ".\Convertisseur Euro c#\Convertisseur Euro\Convertisseur Euro.csproj"

@REM Copie la DLL de référence
copy ".\Exe\wd%MAJOR_VERSION%0net2.dll" ".\Convertisseur Euro c#\Convertisseur Euro\" /Y

@REM Build du CSPROJ
Powershell.exe -executionpolicy remotesigned -File .\pshell_build.ps1

@REM Nettoyage
rd ".\Convertisseur Euro c#\Convertisseur Euro\obj" /S /Q

@REM Copie les DLL du framework
copy ".\Exe\wd*.dll" ".\Convertisseur Euro c#\Convertisseur Euro\bin\x86\Release" /Y

@REM Recopie le .exe généré dans le répertoire EXE
copy ".\Convertisseur Euro c#\Convertisseur Euro\bin\x86\Release\Convertisseur Euro.exe" ".\Exe\Convertisseur Euro.exe" /Y