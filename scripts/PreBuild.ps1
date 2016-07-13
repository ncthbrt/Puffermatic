Import-Module "$PSScriptRoot/Get-RelativePath.psm1"
function JavaInstalled (){
        try{
            java -version 2>&1 | out-null
            return $true;
        }
        catch
        {
            return $false;
        }    
}

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
        if(JavaInstalled){            
            java -jar $PSScriptRoot/tools/antlr4-csharp-4.5.3-SNAPSHOT-complete.jar -visitor -Dlanguage=CSharp_v4_5  -o ..\gen -package Puffermatic.Grammar ./$relativePath
        }else{                        
            Write-Warning "Java is not installed. Falling back to IKVM, however this will affect build times"
            cmd.exe /c "$PSScriptRoot/tools/ikvm.exe -jar $PSScriptRoot/tools/antlr4-csharp-4.5.3-SNAPSHOT-complete.jar -visitor -Dlanguage=CSharp_v4_5  -o ..\gen -package Puffermatic.Grammar ./$relativePath"
        }                                     
    }
    $name=Join-Path "../gen/" $_.Name;              
    if(Test-Path -PathType Container -Path "$name"){    
        Copy-Item ./project.json.template "$name/project.json"
    }
}
Set-Location "$PSScriptRoot/.."; 
Set-Location "./gen";
dotnet restore;
Set-Location $tmp;
Write-Output "Finished"