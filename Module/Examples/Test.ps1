﻿Import-Module .\Module\PowerShellBinaryDemo.psd1 -Force

Write-Host -ForegroundColor Green "Testing Test-PowerShellBinary"

Test-PowerShellBinary -Verbose | Format-Table

Write-Host -ForegroundColor Green "Testing Test-PowerShellBinaryStatic"

Test-PowerShellBinaryStatic -Verbose