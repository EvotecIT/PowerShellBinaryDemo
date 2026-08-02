Import-Module PSPublishModule -Force -ErrorAction Stop

Build-Module -ModuleName 'PowerShellBinaryDemo' {
    $manifest = [ordered] @{
        ModuleVersion        = '1.0.0'
        CompatiblePSEditions = @('Desktop', 'Core')
        GUID                 = 'cabaa2c2-4c4d-41e3-8672-de9e94360a46'
        Author               = 'Przemyslaw Klys'
        CompanyName          = 'Evotec'
        Copyright            = "(c) 2011 - $((Get-Date).Year) Przemyslaw Klys @ Evotec. All rights reserved."
        Description          = 'Simple module for testing PowerShell binary cmdlets.'
        Tags                 = @('PowerShell', 'Demo')
        ProjectUri           = 'https://github.com/EvotecIT/PowerShellBinaryDemo'
        PowerShellVersion    = '5.1'
    }
    New-ConfigurationManifest @manifest

    New-ConfigurationDocumentation -Enable -PathReadme 'Docs\Readme.md' -Path 'Docs' -SyncExternalHelpToProjectRoot
    New-ConfigurationImportModule -ImportSelf

    $build = @{
        Enable                        = $true
        SignModule                    = $false
        NETProjectPath                = "$PSScriptRoot\..\..\PowerShellBinaryDemo"
        ResolveBinaryConflicts        = $true
        ResolveBinaryConflictsName    = 'PowerShellBinaryDemo'
        NETProjectName                = 'PowerShellBinaryDemo'
        NETBinaryModule               = 'PowerShellBinaryDemo.dll'
        NETConfiguration              = 'Release'
        NETFramework                  = 'net472', 'net8.0'
        NETSearchClass                = 'CmdletTestPowerShellBinary'
        RefreshPSD1Only               = $false
        NETBinaryModuleDocumentation  = $true
    }
    New-ConfigurationBuild @build

    New-ConfigurationArtefact -Type Unpacked -Enable -Path "$PSScriptRoot\..\Artefacts\Unpacked"
    New-ConfigurationArtefact -Type Packed -Enable -Path "$PSScriptRoot\..\Artefacts\Packed" -IncludeTagName
}
