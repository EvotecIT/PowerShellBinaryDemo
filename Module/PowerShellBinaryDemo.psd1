@{
    AliasesToExport      = @('*')
    Author               = 'Przemyslaw Klys'
    CmdletsToExport      = @('*')
    CompanyName          = 'Evotec'
    CompatiblePSEditions = @('Desktop', 'Core')
    Copyright            = '(c) 2011 - 2024 Przemyslaw Klys @ Evotec. All rights reserved.'
    Description          = 'Simple module for testing'
    FunctionsToExport    = @('*')
    GUID                 = 'cabaa2c2-4c4d-41e3-8672-de9e94360a46'
    ModuleVersion        = '1.0.0'
    PowerShellVersion    = '5.1'
    PrivateData          = @{
        PSData = @{
            ExternalModuleDependencies = @('Microsoft.PowerShell.Utility', 'Microsoft.PowerShell.Management', 'Microsoft.PowerShell.Diagnostics')
        }
    }
    RequiredModules      = @('Microsoft.PowerShell.Utility', 'Microsoft.PowerShell.Management', 'Microsoft.PowerShell.Diagnostics')
    RootModule           = 'PowerShellBinaryDemo.psm1'
}