﻿// See https://aka.ms/new-console-template for more information
using intro.Business;
using intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

//variables --> camelCase
bool isAuthenticated = true;
Console.WriteLine(message1);

//condition

if (isAuthenticated == true)
{
    Console.WriteLine("Buton -->Hoş geldin Çağla");
}

else
{
    Console.WriteLine("Buton-->Sisteme Giriş Yap");
}


/*
string kredi1 = "Kredi1";
string kredi2 = "Kredi2";
string kredi3 = "Kredi3";

Console.WriteLine(kredi1);
Console.WriteLine(kredi2);
Console.WriteLine(kredi3); */

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3" }; //dbden gelecek
//string[] loans2 = new string[3];
//loans2[0] = "Kredi 1";

     //start    condition       increment
for (int i= 0; i< loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

/*Course course1 = new Course(); //new ile referanslıyoruz kurs tipinde kurs1 demiş gibi
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8 vs.";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "JAVA";
course2.Description = "Java 17...";

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12..";

Course[] courses = {course1, course2, course3};

for (int i= 0;i<courses.Length;i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}*/


CourseManager courseManager = new();
Course[] courses2 = courseManager.GetAll();
for (int i= 0; i< courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}

Console.WriteLine("kod bitti");



IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678922";
customer1.FirstName = "Çağla";
customer1.LastName = "Durmaz";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345678912";
customer2.FirstName = "Özgü";
customer2.LastName = "Durmaz";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name="Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 3;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";
