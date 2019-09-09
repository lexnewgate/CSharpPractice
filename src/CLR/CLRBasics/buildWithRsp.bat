set csc="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\Roslyn\csc.exe"
%csc% @csc.rsp /out:Program1.exe main.cs test.cs

REM switches
REM /nostdlib