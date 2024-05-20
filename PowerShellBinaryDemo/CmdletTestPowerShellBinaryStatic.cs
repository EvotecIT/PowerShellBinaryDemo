using System.Management.Automation;
using System.Threading.Tasks;
using PowerShellBinaryDemo.Library;

namespace PowerShellBinaryDemo;

[Cmdlet(VerbsDiagnostic.Test, "PowerShellBinaryStatic")]
public sealed class CmdletTestPowerShellBinaryStatic : AsyncPSCmdlet {
    // let's create a logger, so we can write messages to the console
    private InternalLogger InternalLogger = null!;
    // let's create a TestClass, so we can call the TestMethod from different sections
    protected override Task BeginProcessingAsync() {
        // Initialize the logger to be able to see verbose, warning, debug, error, progress, and information messages.
        InternalLogger = new InternalLogger(false);

        // Assign the InternalLogger to the static Logger in LoggingMessages
        LoggingMessages.Logger = InternalLogger;
        var internalLoggerPowerShell = new InternalLoggerPowerShell(InternalLogger, this.WriteVerbose, this.WriteWarning, this.WriteDebug, this.WriteError, this.WriteProgress, this.WriteInformation);

        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Begin Section");

        return Task.CompletedTask;
    }
    protected override Task ProcessRecordAsync() {
        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Processing Section");

        // Write the result of the TestMethod to the console.
        WriteObject(TestClassStatic.TestMethod());

        return Task.CompletedTask;
    }
    protected override Task EndProcessingAsync() {
        // Write a warning message to the console.
        InternalLogger.WriteWarning("Test Warning in End Section");
        return Task.CompletedTask;
    }
}
