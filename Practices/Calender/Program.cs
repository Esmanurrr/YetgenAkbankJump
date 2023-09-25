using Calender.Entities;

Console.WriteLine("Calender App");


Meeting meeting = new Meeting()
{
    Title = "YetGen Jump & Akbank Backend Planlama Toplantısı",
    Details = new List<string> { "Katılımcıların alım süreçleri konuşulacak", "Akbank'tan gelen mail konuşulacak", "bütçe planlaması konuşulacak" },
    StartTime = new DateTime(2023, 09, 18, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 20, 00, 00),
    Guests = new() { "hakan@deneme.com", "mehmet@deneme.com", "ugur@deneme.com"}
};

Todo todo = new Todo()
{
    Title = "Katılımcı geri bildirimlerini teslim et",
    Details = new List<string> { "Değerlendirme sonuçlarının anonimleştirilmesi", "grafik oluşturulması" },
    StartTime = new DateTime(2023, 09, 18, 21, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 22, 00, 00),
    Importance = "High Priority"
};

meeting.GetNotification();

todo.GetNotification();
