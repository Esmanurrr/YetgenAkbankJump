using Week1.Entities;

Computer computer = new Computer("Apple", "MacBook Pro", "Intel i7", "16 GB");
Computer computer2 = new Computer();

Console.WriteLine($"Brand : {computer.Brand} Model : {computer.Model} CPU : {computer.CPU}");