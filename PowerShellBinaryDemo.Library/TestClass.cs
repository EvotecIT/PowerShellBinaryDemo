namespace PowerShellBinaryDemo.Library;

public class TestClass : LoggingMessages {
    public TestClass(InternalLogger? internalLogger = null) {
        if (internalLogger != null) {
            Logger = internalLogger;
        }
    }
    public string TestMethod() {
        Logger.WriteVerbose("Test Verbose Message from inside the library");
        Logger.WriteWarning("Test Warning Message from inside the library");
        Logger.WriteDebug("Test Debug Message from inside the library");
        Logger.WriteError("Test Error Message from inside the library");
        return "Hello World!";
    }
}
