using System.Text.Json;
using YetgenAkbankJump.OOPConsole.Entities;
using YetgenAkbankJump.OOPConsole.Services;

const string logFilePath = "C:\\Users\\esman\\Desktop\\logs.txt";

var consoleLogger = new ConsoleLogger();
var fileLogger = new FileLogger(logFilePath);

try
{

    var filePath = "C:\\Users\\esman\\Desktop\\AccessControlLogs.txt";

    var textFile = File.ReadAllText(filePath);

    consoleLogger.Log("Text file imported");
    fileLogger.Log("Text file imported");
    
    //split each line and remove the entries
    var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

    //33---FRNM3121049B---CARD---2023-08-09T11:10:37+00:00

    consoleLogger.Log("Lines are splitted");
    fileLogger.Log("Lines are splitted");



    List<AccessControlLog> logs = new();

    foreach (var splittedLine in splittedLines)
    {
        var values = splittedLine.Split("---", StringSplitOptions.RemoveEmptyEntries);

        var accessControlLog = new AccessControlLog()
        {
            Id = Guid.NewGuid(),
            CreatedOn = DateTimeOffset.Now,
            PersonId = Convert.ToInt64(values[0]),
            DeviceSerialNumber = values[1],
            AccessType = AccessControlLog.ConvertStringToAccessType(values[2]),
            LogTime = Convert.ToDateTime(values[3])
        };

        logs.Add(accessControlLog);
    }
    consoleLogger.Log("All lines are converted to objects");
    fileLogger.Log("All lines are converted to objects");

    File.WriteAllText("C:\\Users\\esman\\Desktop\\AccessControlLogsJson.txt", JsonSerializer.Serialize(logs));

    consoleLogger.Log("The json file was successfully created"); //logging
    fileLogger.Log("The json file was successfully created"); //logging


    consoleLogger.Log("The operation was successfully completed");
    fileLogger.Log("The operation was successfully completed");
    Console.ReadLine();

}
catch(Exception ex)
{
    consoleLogger.Log(ex.Message);
    fileLogger.Log(ex.Message);
}