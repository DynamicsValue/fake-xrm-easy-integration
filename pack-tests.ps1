param (
    [string]$versionSuffix = "",
    [string]$targetFrameworks = "net6.0"
 )

Write-Host "Running with versionSuffix '$($versionSuffix)'..."

$tempNupkgFolder = './nupkgs'

$packageIdPrefix = "FakeXrmEasy.IntegrationTests"
$projectName = "FakeXrmEasy.Integration.Tests"
$projectPath = "tests/FakeXrmEasy.Integration.Tests"

Write-Host "Packing All Configurations for project $($projectName)" -ForegroundColor Green

./pack-tests-project.ps1 -targetFrameworks $targetFrameworks -projectName $projectName -projectPath $projectPath -packageIdPrefix $packageIdPrefix -versionSuffix $versionSuffix

Write-Host "Pack Succeeded  :)" -ForegroundColor Green