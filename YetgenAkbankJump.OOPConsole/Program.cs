using Microsoft.Extensions.Logging;
using System.Text.Json;
using YetgenAkbankJump.OOPConsole.Common;
using YetgenAkbankJump.OOPConsole.Entities;
using YetgenAkbankJump.OOPConsole.Services;

ILogger logger = new Logger<string>(new LoggerFactory());

const string logFilePath = "C:\\Users\\esman\\Desktop\\logs.txt";

var consoleLogger = new ConsoleLogger();

var fileLogger = new FileLogger(logFilePath);

List<AccessControlLog> logs = new();

try
{

    var filePath = "C:\\Users\\esman\\Desktop\\AccessControlLogs.txt";

    var textFile = File.ReadAllText(filePath);

    consoleLogger.LogInfo("Text file imported");

    fileLogger.LogInfo("Text file imported");
    
    //split each line and remove the entries
    var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

    //33---FRNM3121049B---CARD---2023-08-09T11:10:37+00:00

    consoleLogger.LogInfo("Lines are splitted");
    fileLogger.LogInfo("Lines are splitted");


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
    consoleLogger.LogInfo("All lines are converted to objects");
    fileLogger.LogInfo("All lines are converted to objects");

    File.WriteAllText("C:\\Users\\esman\\Desktop\\AccessControlLogsJson.txt", JsonSerializer.Serialize(logs));

    consoleLogger.LogSuccess("The json file was successfully created"); //logging
    fileLogger.LogSuccess("The json file was successfully created"); //logging


    consoleLogger.LogSuccess("The operation was successfully completed");
    fileLogger.LogSuccess("The operation was successfully completed");

    Console.WriteLine(consoleLogger.Name);

    consoleLogger.LogFatal(consoleLogger.Name);

    Console.ReadLine();


    Console.ReadLine();

}
catch(Exception ex)
{
    consoleLogger.LogError(ex.Message);
    fileLogger.LogError(ex.Message);
}



List<object> myObjects = new List<object>();

myObjects.Add(consoleLogger);

myObjects.Add(fileLogger);

logs.ForEach(x => myObjects.Add(x));

foreach (var myObject in myObjects)
{
    if (myObject is LoggerBase)
    {
        var baseLogger = myObject as LoggerBase;

        baseLogger.LogInfo("Ben bir base logger'ım");
    }


    if (myObject is ICreatedByEntity)
    {
        var entity = myObject as ICreatedByEntity;

        entity.CreatedOn = DateTimeOffset.Now;
    }

    if (myObject is IDeletedByEntity)
    {
        var entity = myObject as IDeletedByEntity;

        entity.DeletedOn = DateTimeOffset.Now;
        entity.IsDeleted = true;
    }
}

decimal finalAmount = 0;

int amount = 68;

double doubleAmount = 68.5d;

finalAmount = amount;

finalAmount = (decimal)doubleAmount;

Teacher teacher = new Teacher()
{
    FirstName = "Alper",
    LastName = "Tunga",
    CreatedOn = DateTimeOffset.Now
};

Student student = new Student()
{
    FirstName = "Ahmet",
    LastName = "Kök",
    CreatedOn = DateTimeOffset.Now
};


teacher = student;