﻿#region Task2
using Csharp__16._12._2022;
using System.Transactions;

//Calculator calculator = new Calculator();


//calculator.Calculation();

#endregion
#region Task3
//Employee employee1 = new Employee();
//employee1.Name = "Cavid";
//employee1.Surname = "Ismayilzade";
//employee1.Age = 22;
//employee1.Salary = 1900;

//Employee employee2 = new Employee();

//employee2.Name = "Farid";
//employee2.Surname = "Abdullayev";
//employee2.Age = 17;
//employee2.Salary = 51;

//Employee employee3 = new Employee();

//employee3.Name = "Elcan";
//employee3.Surname = "Qurbanov";
//employee3.Age = 19;
//employee3.Salary = 700;

//Employee employee4 = new Employee();


//employee4.Name = "Konul";
//employee4.Surname = "Ibrahimova";
//employee4.Age = 26;
//employee4.Salary = 1500;

//Employee employee5 = new Employee();


//employee5.Name = "Shaig";
//employee5.Surname = "Kazimov";
//employee5.Age = 25;
//employee5.Salary = 1950;



//int startSalary = 1000;
//int endSalary = 2000;
//Employee[] arr = { employee1, employee2, employee3, employee4, employee5 };


//Employer(arr, 200 ,500);		
//static void Employer(Employee[] arr,int startSalary,int endSalary)
//{
//	bool SalaryPlus = false;

//	foreach (var item in arr)
//	{
//		if (item.Salary>startSalary && item.Salary<endSalary)
//		{
//			Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
//			SalaryPlus= true;
//		}
//	}
//	if (!SalaryPlus)
//	{
//		Console.WriteLine("1000-2000 maas yoxdur! ");
//	}
//}
#endregion


//using Csharp__16._12._2022;

#region Task4
Doctor doctor1 = new Doctor();

	doctor1.Name = "Cavid";
	doctor1.Surname = "Ismayilzade";
	doctor1.Address = "Sulutepe";
	doctor1.Birthday = new DateTime(1994, 04, 20);

Doctor doctor2 = new Doctor();

    doctor2.Name = "Konul";
    doctor2.Surname = "Ibrahimova";
    doctor2.Address = "Neftciler";
    doctor2.Birthday = new DateTime(1996, 01, 19 );

Doctor doctor3 = new Doctor();


    doctor3.Name = "Eycahan";
    doctor3.Surname = "Qurbanov";
    doctor3.Address = "Razin";
    doctor3.Birthday = new DateTime(2000, 11, 25);


Doctor doctor4 = new Doctor();


    doctor4.Name = "Shaig";
    doctor4.Surname = "Kazimov";
    doctor4.Address = "Sedmoy";
    doctor4.Birthday = new DateTime(1997, 11, 08);


Doctor doctor5 = new Doctor();


    doctor5.Name = "Ferid";
    doctor5.Surname = "Abdullayev";
    doctor5.Address = "Nizami";
    doctor5.Birthday = new DateTime(1998, 06, 18);


DateTime minimum = new DateTime(25, 05, 1993);
DateTime maximum = new DateTime(15, 12, 2002);

Doctor[] arr1 = {doctor1,doctor2,doctor3,doctor4,doctor5 };
 

DateTime(arr1,minimum,maximum);
static void list(Doctor[] arr1, int minimum, int maximum)
{
	bool Listplus = false;

	foreach (var item1 in arr1)
	{
		if (arr1.Birthday > minimum &&  arr1.Birthday< maximum)
		{
			Console.WriteLine(item1.Name + " " + item1.Surname + " " + item1.Address + " " + item1.Birthday);
			Listplus = true;
		}
	}
	if (!Listplus)
	{
		Console.WriteLine(" bu tevelludde Doktor yoxdur");
	}
}














#endregion





