set csc="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\Roslyn\csc.exe"
%csc% /out:Program.exe /t:exe /r:MscorLib.dll Main.cs

REM switches
REM /nostdlib