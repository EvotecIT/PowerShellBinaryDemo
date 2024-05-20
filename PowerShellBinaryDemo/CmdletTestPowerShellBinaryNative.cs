using System.Management.Automation;
using System.Threading.Tasks;
using PowerShellBinaryDemo.Library;

namespace PowerShellBinaryDemo;

[Cmdlet(VerbsDiagnostic.Test, "PowerShellBinaryNative")]
public sealed class CmdletTestPowerShellBinaryNative : PSCmdlet {
    // let's create a logger, so we can write messages to the console
    private InternalLogger InternalLogger = null!;
    // let's create a TestClass, so we can call the TestMethod from different sections
    private TestClass TestClass = null!;
    protected override void BeginProcessing() {
        // Initialize the logger to be able to see verbose, warning, debug, error, progress, and information messages.
        InternalLogger = new InternalLogger();

        // Initialize the InternalLoggerPowerShell to be able to write messages to the console.
        // We need to pass the InternalLogger, so we can write messages to the console from Library
        var internalLoggerPowerShell = new InternalLoggerPowerShell(InternalLogger, this.WriteVerbose, this.WriteWarning, this.WriteDebug, this.WriteError, this.WriteProgress, this.WriteInformation);

        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Begin Section");

        // Initialize the TestClass to be able to call the TestMethod.
        TestClass = new TestClass(InternalLogger);
    }
    protected override void ProcessRecord() {
        // Write a verbose message to the console.
        InternalLogger.WriteVerbose("Test Processing Section");

        // Write the result of the TestMethod to the console.
        WriteObject(TestClass.TestMethod());

        var output = TestClass.TestMethodWithEnumerable(["test", "test2"], "Output", true);
        // this won't display Verbose or anything
        WriteObject(output, true);
    }
    protected override void EndProcessing() {
        // Write a warning message to the console.
        InternalLogger.WriteWarning("Test Warning in End Section");
    }
}
