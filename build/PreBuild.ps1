Import-Module "$PSScriptRoot/Get-RelativePath.psm1"

$tmp=Get-Location;
Set-Location "$PSScriptRoot/.."
$parent=Get-Item './src'
If(Test-Path -PathType Container  -Path ./gen){
    Remove-Item -Recurse "./gen"
}

Set-Location $parent;
Get-ChildItem "./" -Directory |
Foreach-Object {
    Get-ChildItem $_.FullName -Filter *.g4 -Recurse |
    Foreach-Object {        
        $relativePath=Get-RelativePath -Folder $parent -FilePath $_.FullName               
        cmd.exe /c "java -jar $PSScriptRoot/tools/antlr4-csharp-4.5.3-SNAPSHOT-complete.jar -visitor -Dlanguage=CSharp_v4_5  -o ..\gen -package Puffermatic.Grammar ./$relativePath"      
    }
    $name=Join-Path "../gen/" $_.Name;
    Write-Output $name          
    if(Test-Path -PathType Container -Path "$name"){    
        Copy-Item ./project.json.template "$name/project.json"
    }
}
Set-Location $tmp;
