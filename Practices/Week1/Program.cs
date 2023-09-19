

using Week1;

Student student1 = new Student()
{
    Id = 26029,
    Name = "Fatma Özlem",
    Surname = "Acar"
};

Student student2 = new Student()
{
    Id = 66435,
    Name = "Aygün",
    Surname = "Bayram"
};

//student1.Id = 26029;
//student1.Name = "Fatma Özlem";
//student1.Surname = "Acar";

Console.WriteLine($"İsim : {student1.Name} Soyisim : {student1.Surname}");
Console.WriteLine($"İsim : {student2.Name} Soyisim : {student2.Surname}");