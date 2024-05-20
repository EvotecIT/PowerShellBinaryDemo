using System.Management.Automation;
using System.Threading.Tasks;
using PowerShellBinaryDemo.Library;

namespace PowerShellBinaryDemo;

[Cmdlet(VerbsDiagnostic.Test, "PowerShellBinary")]
public sealed class CmdletTestPowerShellBinary : AsyncPSCmdlet {
    // let's create a logger, so we can write messages to the console
    private InternalLogger InternalLogger;
    // let's create a TestClass, so we can call the TestMethod from different sections
    private TestClass TestClass;
    protected override Task BeginProcessingAsync() {
        // Initialize the logger to be able to see verbose, warning, debug, error, progress, and information messages.
        InternalLogger = new InternalLogger(false);
        var internalLoggerPowerShell = new InternalLoggerPowerShell(InternalLogger, this.WriteVerbose, this.WriteWarning, this.WriteDebug, this.WriteError, this.WriteProgress, this.WriteInformation);

        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Begin Section");

        // Initialize the TestClass to be able to call the TestMethod.
        TestClass = new TestClass(InternalLogger);

        return Task.CompletedTask;
    }
    protected override Task ProcessRecordAsync() {
        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Processing Section");

        // Write the result of the TestMethod to the console.
        WriteObject(TestClass.TestMethod());

        return Task.CompletedTask;
    }
    protected override Task EndProcessingAsync() {
        // Write a warning message to the console.
        InternalLogger.WriteWarning("Test Warning in End Section");
        return Task.CompletedTask;
    }
}
