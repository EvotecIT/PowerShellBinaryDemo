using System.Management.Automation;
using System.Threading.Tasks;

using PowerShellBinaryDemo.Library;

namespace PowerShellBinaryDemo;

[Cmdlet(VerbsDiagnostic.Test, "PowerShellBinary")]
public sealed class CmdletWriteWinEvent : AsyncPSCmdlet {

    private InternalLogger InternalLogger;
    private TestClass TestClass;
    protected override Task BeginProcessingAsync() {
        // Initialize the logger to be able to see verbose, warning, debug, error, progress, and information messages.
        InternalLogger = new InternalLogger(false);
        var internalLoggerPowerShell = new InternalLoggerPowerShell(InternalLogger, this.WriteVerbose, this.WriteWarning, this.WriteDebug, this.WriteError, this.WriteProgress, this.WriteInformation);
        InternalLogger.WriteVerbose("Test Begin Section");

        TestClass = new TestClass();

        return Task.CompletedTask;
    }
    protected override Task ProcessRecordAsync() {
        InternalLogger.WriteVerbose("Test Processing Section");

        WriteObject(TestClass.TestMethod());

        return Task.CompletedTask;
    }
    protected override Task EndProcessingAsync() {
        InternalLogger.WriteWarning("Test Warning in End Section");
        return Task.CompletedTask;
    }
}
