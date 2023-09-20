using Week1.Entities;
using Week1.Enums;

Computer computer = new Computer("Apple", "MacBook Pro", "Intel i7", "Corsair 16GB","WD Blue", 16, CapacitySizeType.GB);
Computer computer2 = new Computer("Apple", "MacBook Pro", "Intel i7", "Corsair 16GB","WD Blue", 1, CapacitySizeType.TB);
Computer computer3 = new Computer("Apple", "MacBook Pro", "Intel Pentium", "Samsung 2GB","WD Blue", 512, CapacitySizeType.MB);
Computer computer4 = new Computer("Apple", "MacBook Pro", "Intel Pentium", "Samsung 2GB","WD Blue", 512, CapacitySizeType.MB);
Computer computer5 = new Computer();

Console.WriteLine($"Brand : {computer.Brand} Model : {computer.Model} CPU : {computer.CPU}");