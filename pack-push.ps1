param (
    [string]$packageSource = "local-packages",
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "netcoreapp3.1"
 )

Write-Host "Running with versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'

Write-Host "Checking if temp nupkgs folder '$($tempNupkgFolder)' exists..."

$tempNupkgFolderExists = Test-Path $tempNupkgFolder -PathType Container

if(!($tempNupkgFolderExists)) 
{
    New-Item $tempNupkgFolder -ItemType Directory
}

Write-Host "Deleting temporary nupkgs..."
Get-ChildItem -Path $tempNupkgFolder -Include *.nupkg -File -Recurse | ForEach-Object { $_.Delete()}

Write-Host "Packing src packages..."
./pack-src.ps1 -targetFrameworks $targetFrameworks -versionSuffix $versionSuffix 
./push.ps1 -packageSource $packageSource -packagePrefix "FakeXrmEasy.Integration"

Write-Host "Packing test packages..."
./pack-tests.ps1 -targetFrameworks $targetFrameworks -versionSuffix $versionSuffix
./push.ps1 -packageSource $packageSource -packagePrefix "FakeXrmEasy.IntegrationTests"   

Write-Host "Pack Succeeded  :)" -ForegroundColor Green