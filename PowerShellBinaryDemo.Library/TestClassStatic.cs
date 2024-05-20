namespace PowerShellBinaryDemo.Library;

public static class TestClassStatic {
    public static string TestMethod() {
        LoggingMessages.Logger.WriteVerbose("Test Verbose Message from inside the library");
        LoggingMessages.Logger.WriteWarning("Test Warning Message from inside the library");
        LoggingMessages.Logger.WriteDebug("Test Debug Message from inside the library");
        LoggingMessages.Logger.WriteError("Test Error Message from inside the library");
        return "Hello World!";
    }
}
