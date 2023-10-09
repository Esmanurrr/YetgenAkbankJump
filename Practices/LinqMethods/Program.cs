#region Average

//List<int> grades = new List<int>{ 78, 92, 100, 37, 81 };

//double average = grades.Average();

//Console.WriteLine($"Average is : {average}");

#endregion

#region Concat

//using LinqMethods.Entities;

//static Product[] GetPens()
//{
//    Product[] pens =
//    {
//        new Product {Name = "Pencil 1", Price = 100},
//        new Product {Name = "Pencil 2", Price = 200},
//        };
//    return pens;
//}

//static Product[] GetBooks()
//{
//    Product[] books =
//    {
//        new Product {Name = "Book 1", Price = 100},
//        new Product {Name = "Book 2", Price = 200},
//        };
//    return books;
//}


//Product[] pens = GetPens();
//Product[] books = GetBooks();

//IEnumerable<string> query = pens.Select(p => p.Name)
//    .Concat(books.Select(b => b.Name));

//foreach (string name in query)
//{
//    Console.WriteLine(name);
//}

//Output is : Pencil 1 Pencil 2 Book 1 Book 2

#endregion

#region Distinct

//useful

//List<int> ages = new List<int> { 13, 432, 23, 23, 13, 40 };

//IEnumerable<int> distinctAges = ages.Distinct();

//Console.WriteLine("Distinct Ages : ");

//foreach (int age in distinctAges)
//{
//    Console.WriteLine(age);
//}

//13, 432, 23, 40

#endregion

#region Skip

//string[] users = { "Selma", "Zeliha", "Deniz", "Esma", "Serkan" };

//Console.WriteLine("All users except the first three");
//foreach (string user in users.Skip(3))
//{
//    Console.WriteLine(user);
//}

//Output is : Esma Serkan

#endregion

#region Take

//int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

//IEnumerable<int> topThreeGrades = grades.OrderByDescending(x => x).Take(3);

//Console.WriteLine("The top three grades are : ");
//foreach (int grade in topThreeGrades)
//{
//    Console.WriteLine(grade);
//}

//Output is : 98 92 85

#endregion


//My picks

#region Except

//double[] numbers1 = { 2.0, 2.0, 2.1, 2.2, 2.3, 2.3, 2.4, 2.5 };
//double[] numbers2 = { 2.2, 2.3, 2.5};

//IEnumerable<double> onlyInFirstSet = numbers1.Except(numbers2);

//foreach (double number in onlyInFirstSet)
//    Console.WriteLine(number);

//Output is : 2, 2.1, 2.4

#endregion

#region Intersect

//int[] id1 = { 44, 26, 92, 30, 71, 38 };
//int[] id2 = { 39, 59, 83, 47, 26, 4, 30 };

//string[] students1 = { "Selin", "Esma", "İrem" };
//string[] students2 = { "Deniz", "Esma", "Merve" };

//IEnumerable<string> both = students1.Intersect(students2);

//foreach (string name in both)
//    Console.WriteLine(name);

//Output is : Esma

#endregion

#region Range

//IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

//foreach (int num in squares)
//{
//    Console.WriteLine(num);
//}

/*
 output is:

 1
 4
 9
 16
 25
 36
 49
 64
 81
 100
*/


#endregion

#region Union

//int[] ints1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
//int[] ints2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

//IEnumerable<int> union = ints1.Union(ints2);

//foreach (int num in union)
//{
//    Console.Write("{0} ", num);
//}

/*
 output is:

 5 3 9 7 8 6 4 1 0
*/

#endregion