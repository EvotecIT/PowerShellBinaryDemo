namespace PowerShellBinaryDemo.Library;

public class TestClass : Settings {
    public TestClass(InternalLogger? internalLogger = null) {
        if (internalLogger != null) {
            _logger = internalLogger;
        }
    }
    public string TestMethod() {
        _logger.WriteVerbose("Test Verbose Message from inside the library");
        _logger.WriteWarning("Test Warning Message from inside the library");
        _logger.WriteDebug("Test Debug Message from inside the library");
        _logger.WriteError("Test Error Message from inside the library");
        return "Hello World!";
    }
}
