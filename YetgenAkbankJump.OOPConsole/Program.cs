using System.Text.Json;
using System.Windows.Markup;
using YetgenAkbankJump.OOPConsole.Entities;

var filePath = "C:\\Users\\esman\\Desktop\\AccessControlLogs.txt";

var textFile = File.ReadAllText(filePath);

//split each line and remove the entries
var splittedLines = textFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

//33---FRNM3121049B---CARD---2023-08-09T11:10:37+00:00

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

File.WriteAllText("C:\\Users\\esman\\Desktop\\AccessControlLogsJson.txt", JsonSerializer.Serialize(logs));

Console.WriteLine("The operation was successfully completed");
Console.ReadLine();
//https://codebeautify.org/jsonviewer