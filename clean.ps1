param (
    [string]$folderPath = "./src/FakeXrmEasy.Integration/bin"
)

if (Test-Path -Path $folderPath) {
  Get-ChildItem -Path $folderPath -Include * -File -Recurse | foreach { $_.Delete()}
}
