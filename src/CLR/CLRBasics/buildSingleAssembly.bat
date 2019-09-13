del *.exe

set csc="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\Roslyn\csc.exe"
set ildasm="C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\bin\x64\ildasm.exe" 
set out="SingleAssembly.exe"
set buildType=exe

%csc% /out:%out% /t:%buildType% Main.cs
%ildasm% %out%