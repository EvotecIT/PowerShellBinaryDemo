@{
    AliasesToExport      = @('*')
    Author               = 'Przemyslaw Klys'
    CmdletsToExport      = @('Test-PowerShellBinary', 'Test-PowerShellBinaryNative', 'Test-PowerShellBinaryStatic')
    CompanyName          = 'Evotec'
    CompatiblePSEditions = @('Desktop', 'Core')
    Copyright            = '(c) 2011 - 2026 Przemyslaw Klys @ Evotec. All rights reserved.'
    Description          = 'Simple module for testing PowerShell binary cmdlets.'
    FunctionsToExport    = @()
    GUID                 = 'cabaa2c2-4c4d-41e3-8672-de9e94360a46'
    ModuleVersion        = '1.0.0'
    PowerShellVersion    = '5.1'
    PrivateData          = @{
        PSData = @{
            ExternalModuleDependencies = @()
            Tags                       = @('PowerShell', 'Demo')
            ProjectUri                 = 'https://github.com/EvotecIT/PowerShellBinaryDemo'
            RequireLicenseAcceptance   = $false
}
    }
    RequiredModules      = @()
    RootModule           = 'PowerShellBinaryDemo.psm1'
    ScriptsToProcess     = @()
}