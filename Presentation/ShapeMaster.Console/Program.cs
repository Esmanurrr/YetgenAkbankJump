using ShapeMaster.Domain.Entities;
using ShapeMaster.Infrastructure.Services;

Rectangle rectangle1 = new Rectangle();
rectangle1.ASide = 5.0m;
rectangle1.BSide = 10.0m;
decimal area1 = rectangle1.GetArea(); // Alanı hesapla
Console.WriteLine($"Tip: {rectangle1.Type}, Alan: {area1}");


Rectangle rectangle2 = new Rectangle();
rectangle2.ASide = 7.5m;
rectangle2.BSide = 3.0m;
decimal area2 = rectangle2.GetArea(); // Alanı hesapla
Console.WriteLine($"Tip: {rectangle2.Type}, Alan: {area2}");

