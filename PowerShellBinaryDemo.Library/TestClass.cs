using System.Collections.Generic;
using System.IO;

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

    public IEnumerable<ConversionResult> TestMethodWithEnumerable(string[] emlFile, string outputFolder, bool force) {
        LoggingMessages.Logger.WriteVerbose("TestMethodWithEnumerable");
        Logger.WriteVerbose("Converting some files to some files");
        foreach (var eml in emlFile) {
            var fileName = Path.GetFileNameWithoutExtension(eml);
            var targetFile = Path.Combine(outputFolder, $"{fileName}.msg");
            var msg = new ConversionResult() {
                EmlFile = eml,
                MsgFile = targetFile,
                Success = true
            };
            yield return msg;
        }
    }
}

public class ConversionResult {
    public string EmlFile { get; set; }
    public string MsgFile { get; set; }
    public bool Success { get; set; }
    public string? ErrorMessage { get; set; }
}
