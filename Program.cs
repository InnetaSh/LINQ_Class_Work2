//Задача 1: Имеется коллекция книг, каждая из которых имеет название, автора и год издания. Необходимо найти все книги, которые были изданы после 2000 года и упорядочить их по названию в алфавитном порядке.

//List<Book> books = new List<Book>
//{
//    new Book("песнь льда и пламени.Игра престолов.", "Джордж Мартин", 1996),
//    new Book("песнь льда и пламени.Танец с драконами.", "Джордж Мартин", 2011),
//    new Book("Ведьмак.Последнее желание.", "Анджей Сапковский", 1968),
//    new Book("песнь льда и пламени.Пир стервятников.", "Джордж Мартин", 2005),
//    new Book("песнь льда и пламени.Буря мечей.", "Джордж Мартин", 2000),
//     new Book("Ведьмак.Сезон гроз.", "Анджей Сапковский", 2013),
//};

//var booksList = books.Where(x => x.YearOfPublishing > 2000).OrderBy(x => x.Title);

//foreach (var book in booksList)
//{
//    book.GetInfo();
//}

//public class Book
//{ 
//    public string Title { get;  set; } //название ресурса.
//    public string Author { get;  set; } //автор ресурса.
//    public int YearOfPublishing { get;  set; } // год издания.

//    public Book(string title, string author, int year) 
//    {
//    Title = title;
//    Author = author;
//    YearOfPublishing = year;
//    }

//    public void GetInfo()
//    {
//        Console.WriteLine($"Книга \'{Title}\', автор - {Author}, год издания. - {YearOfPublishing}");
//         ;
//    }
//}






//Задача 2: Имеется коллекция студентов, каждый из которых имеет имя, возраст и список оценок.
//Найти средний балл для каждого студента и упорядочить студентов по этому среднему баллу в порядке убывания.

//var StudentList = new List<Student>
//{
//       new Student("Alex",18)
//       {
//       Grades = new List<int>{ 10,9,8,12,12, 12, 6, 8, 10, 12 }
//       },
//       new Student("Tom",19)
//       {
//       Grades = new List<int>{ 10,10,8,11,12,8, 10, 12, 10, 12, 11, 12, 12 }
//       },
//       new Student("Sam",17)
//       {
//       Grades = new List<int>{ 10,9,12,12,10,12,12, 10, 12, 10, 12, 11, 12,  12 }
//       },

//       new Student("Bob",19)
//       {
//       Grades = new List<int>{ 7,9,5}
//       },

//       new Student("Anna", 18)
//       {
//       Grades = new List<int>{ 12,10,11,11,10,10,12, 10, 9, 12, 12, 10, 12, 12 }
//       },
//};


//var grateSudents = StudentList.OrderByDescending(x => CalcAverageGrage(x)).ToList();



//foreach (var st in grateSudents)
//{
//    Console.WriteLine($"Name - {st.Name}, {CalcAverageGrage(st)} ");
//    Console.WriteLine("----------------------------------------------");
//}

//int CalcSumGrage(Student student)
//{
//    int sum = 0;
//    foreach (var gr in student.Grades)
//        {
//            sum += gr;
//        }

//    return sum;
//}
//double CalcAverageGrage(Student student)
//{
//    int totalSum = CalcSumGrage(student);
//    int totalCount = student.Grades.Count;
//    double Avarage = (double)totalSum / totalCount;
//    return Avarage;
//}

//class Student
//{
//    public string Name;
//    public int Age;

//    public List<int> Grades;

//    public Student(string name, int age)
//    {
//        Name = name;
//        Age = age;
//        Grades = new List<int>();
//    }

//}






//Задача 3: Имеется коллекция заказов, каждый из которых содержит дату заказа и список товаров. Найти все заказы, которые содержат хотя бы один товар на сумму более 1000.


//using System.ComponentModel.DataAnnotations;

//var OrdersList = new List<Order>
//{
//    new Order(new DateTime(2024, 07, 15))
//    {
//        products = new List<Product>
//        {
//            new Product("Iphone15", 32000),
//            new Product("Acum", 12000),
//            new Product("Invertor", 6000)
//         }
//    },
//    new Order(new DateTime(2024,06,10))
//    {
//        products = new List<Product>
//        {
//        new Product("TP-LINK ", 450)
//        }
//    },
//    new Order(new DateTime(2024,05,21))
//    {
//        products = new List<Product>
//        {
//        new Product("MacBook", 80000),
//        new Product("TP-LINK ", 950)
//        }
//    },
//     new Order(new DateTime(2024,01,10))
//    {
//        products = new List<Product>
//        {
//        new Product("desk lamp ", 550)
//        }
//    }
//};

//var OrdersListNew = OrdersList.Where(x =>x.products.Any(order => order.Price > 1000)).ToList();

//foreach (var o in OrdersListNew)
//{
//    o.PrintInfo();
//    Console.WriteLine("--------------------------------");
//}
//class Order
//{
//    public DateTime OrderDate;
//    public  List<Product> products;

//    public Order(DateTime orderDate)
//    {
//        products = new List<Product>();
//        OrderDate = orderDate;
//    }
//    public void PrintInfo()
//    {

//        Console.WriteLine($"Date - {OrderDate}");
//        foreach (var product in products)
//        {
//            product.PrintInfoProduct();
//        }

//    }
//}

//class Product
//{
//    public string Name;
//    public double Price;

//    public Product(string name, double price) 
//    { 
//        Name = name;
//        Price = price;
//    }
//    public void PrintInfoProduct()
//    {

//        Console.WriteLine($"Order name - {Name}, Price - {Price}");

//    }
//}





//Задача 4: Имеется коллекция сотрудников, каждый из которых имеет имя, должность и зарплату. Найти среднюю зарплату для каждой должности.

//var EmployeesList = new List<Employee>
//{
//    new Employee("Tom","manager", 27000),
//    new Employee("Sam", "manager",32000),
//    new Employee("Bob", "worker",20000),
//    new Employee("Jon", "manager",22000),
//    new Employee("Alex", "worker",18000),

//};

//var EmployeesListNew = EmployeesList.GroupBy(x => x.JobTitle)
//    .Select(gr => new
//{
//        JobTitle = gr.Key,
//        AverageSalary = gr.Average(x => x.Salary)
//});

//foreach (var emp in EmployeesListNew)
//{
//    Console.WriteLine($"JobTitle - {emp.JobTitle},AverageSalary - {emp.AverageSalary} ");
//}

//class Employee
//{
//    public string Name;
//    public string JobTitle;
//    public int Salary;

//    public Employee(string name, string title, int salary)
//    {
//        Name = name;
//        JobTitle = title;
//        Salary = salary;
//    }
//}







//Задача 5: Имеется коллекция фильмов, каждый из которых имеет название, год выхода и список актеров.
//Найти все фильмы, в которых снялся определенный актер.

//var FilmsList = new List<Film>
//{
//    new Film("Малефисента",2014)
//    {
//        ActorsName = new List<string>{ "Анджелина Джоли", "Эль Фэннинг", "Ханна Нью" , "Сэм Райли" }
//    },
//      new Film("007: Координаты \'Скайфолл\'",2012)
//    {
//        ActorsName = new List<string>{ "Дэниел Крейг", "Хавьер Бардем", "Джуди Денч" }
//      },
//    new Film("Мистер и миссис Смит",2005)
//    {
//        ActorsName = new List<string>{"Брэд Питт","Анджелина Джоли","Винс Вон" }
//    },
//     new Film("Лара Крофт: Расхитительница гробниц",2001)
//    {
//        ActorsName = new List<string>{ "Анджелина Джоли", "Джон Войт", "Дэниел Крейг" }
//     },
//     new Film("Не время умирать",2021)
//    {
//        ActorsName = new List<string>{"Дэниел Крейг","Рами Малек","Джеффри Райт" }
//     }

//};

//Console.WriteLine("Введите имя актера:");
//string Name = Console.ReadLine();
////string Name = "Анджелина Джоли";
//Console.WriteLine("-----------------------------");


//var FilmsListNew = FilmsList.Where(x => x.ActorsName.Any(order => order == Name)).ToList();

//if (FilmsListNew.Count == 0)
//{
//    Console.WriteLine("фильмов с таким актером нет");
//}
//else
//{
//    foreach (var film in FilmsListNew)
//    {
//        Console.WriteLine($"Film - {film.Title}, year - {film.YearOfPublishing}");
//        Console.WriteLine("актерский состав:");
//        foreach (var actor in film.ActorsName)
//        {
//            Console.WriteLine(actor + "\t");
//        }
//        Console.WriteLine("-----------------------------");
//    }

//}

//class Film
//{
//    public string Title;
//    public int YearOfPublishing;
//    public List<string> ActorsName;

//    public Film(string title, int year)
//    {
//        Title = title;
//        YearOfPublishing = year;
//        ActorsName = new List<string>();
//    }
//}






//Задача 6: Имеется коллекция продуктов, каждый из которых имеет название, категорию и цену. Найти среднюю цену продуктов для каждой категории.

//List<Product> products = new List<Product>
//        {
//            new Product ("яблоко", 59.99m, "фрукт"),
//            new Product ("груша", 49.99m,  "фрукт" ),
//            new Product("персик", 119.99m,  "фрукт" ),
//            new Product ("диван", 17999.99m,  "мебель"),
//            new Product ("шкаф",  1499.99m, "мебель" ),
//            new Product("нектарин", 119.99m,  "фрукт" ),
//            new Product ("стул",  1499.99m, "мебель" ),
//            new Product ("вишня", 20.99m, "фрукт")
//        };


//var ProductsList = products.GroupBy(x => x.Category)
//    .Select(gr => new
//    {
//        Category = gr.Key,
//        AveragePrice = gr.Average(x => x.Price)
//    });

//foreach (var pr in ProductsList)
//{
//    Console.WriteLine($"Category name - {pr.Category}, - {pr.AveragePrice} ");
//}
//internal class Product
//{

//    public string Name;
//    public decimal Price;
//    public string Category;
//    public Product(string name, decimal price, string category)
//    {
//        Name = name;
//        Price = price;
//        Category = category;
//    }
//}





//Задача 7: Имеется коллекция пользователей, каждый из которых имеет имя и список друзей. Найти всех пользователей, у которых больше 5 друзей.


//using System.Security.Authentication.ExtendedProtection;

//var Persons = new List<Person>
//{
//    new Person("Tom")
//    {
//        friends = new List<string>{"Bob","Sam","Anna","Alex","Polya","Maria","Dania"}
//    },
//    new Person("Ivan")
//    {
//        friends = new List<string>{"Polya","Maria","Dania"}
//    },
//    new Person("Den")
//    {
//        friends = new List<string>{"Alya","Alex","Polya","Maria","Dania","Nik"}
//    },
//    new Person("Bob")
//    {
//        friends = new List<string>{"Sam","Anna","Alex"}
//    },
//    };

//var PersonsListNew = Persons.Where(x => x.friends.Count > 5).ToList();

//foreach (var pers in PersonsListNew)
//{
//    Console.WriteLine($"Name - {pers.Name},\tfriends:");
//    foreach (var fr in pers.friends)
//    {
//        Console.Write(fr + ", ");
//    }
//    Console.WriteLine();
//    Console.WriteLine("-------------------------------------");
//}

//class Person
//{
//    public string Name;
//    public List<string> friends;

//    public Person(string name)
//    {
//        Name = name;
//        friends = new List<string>();
//    }
//}






//Задача 8: Имеется коллекция транзакций, каждая из которых имеет сумму и дату. Найти все транзакции за последний месяц и вычислить их общую сумму.


using System.Transactions;

var Transactions = new List<Transaction>
{
    new Transaction(52000,new DateTime(2024,07,11)),
    new Transaction(210000,new DateTime(2024,04,21)),
    new Transaction(60000,new DateTime(2024,07,01)),
    new Transaction(10000,new DateTime(2024,06,07)),
    new Transaction(120000,new DateTime(2024,07,14)),
    new Transaction(110000,new DateTime(2024,07,01))
};

DateTime nowDate = DateTime.Today;

DateTime lastMonthDate = nowDate.AddMonths(-1).Date.AddDays(nowDate.Day);


var transactionsNow = Transactions.Where(t => t.Date >= lastMonthDate && t.Date <= nowDate).Sum(t => t.Amount);


    Console.WriteLine($"totalAmount - {transactionsNow}");

public class Transaction
{
    public double Amount;
    public DateTime Date;

    public Transaction(double sum, DateTime date)
    {
        Amount = sum;
        Date = date;
    }
}







//Задача 9: Имеется коллекция студентов, каждый из которых имеет имя и список курсов. Найти всех студентов, которые записаны на курс "Математика".

//Задача 10: Имеется коллекция сотрудников, каждый из которых имеет имя, отдел и список проектов. Найти все отделы и количество сотрудников в каждом отделе.

//Задача 11: Имеется коллекция книг, каждая из которых имеет название, автора и год издания. Найти автора, у которого наибольшее количество книг.

//Задача 12: Имеется коллекция пользователей, каждый из которых имеет имя, возраст и список хобби. Найти всех пользователей, у которых есть хобби "футбол".

//Задача 13: Имеется коллекция продуктов, каждый из которых имеет название, категорию и цену. Найти 3 самых дорогих продукта в каждой категории.

//Задача 14: Имеется коллекция заказов, каждый из которых содержит дату заказа и список товаров. Найти месяц, в котором было сделано больше всего заказов.

//Задача 15: Имеется коллекция фильмов, каждый из которых имеет название, год выхода и список актеров. Найти актера, который снялся в наибольшем количестве фильмов.

//Задача 16: Имеется коллекция студентов, каждый из которых имеет имя и список оценок. Найти студента с наибольшим средним баллом.

//Задача 17: Имеется коллекция сотрудников, каждый из которых имеет имя, должность и зарплату. Найти самую высокую зарплату для каждой должности.

//Задача 18: Имеется коллекция пользователей, каждый из которых имеет имя и список друзей. Найти всех пользователей, у которых есть друг с именем "Алексей".

//Задача 19: Имеется коллекция транзакций, каждая из которых имеет сумму и дату. Найти транзакцию с наибольшей суммой за последний год.

//Задача 20: Имеется коллекция студентов, каждый из которых имеет имя и список курсов. Найти все курсы и количество студентов, записанных на каждый курс.