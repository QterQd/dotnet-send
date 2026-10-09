using System;
using System.Collections.Generic;

public class Student
{
	public string name {get; set;}
	public int age {get; set;}
	public int clas {get; set;}
	public double avarageGrade {get; set;}
	public Student(string name, int age, int clas, double avarageGrade)
	{
		this.name = name;
		this.age = age;
		this.clas = clas;
		this.avarageGrade = avarageGrade;
	}

	public void Introduce()
	{
		Console.WriteLine($"My name: {name}, Age: {age}, Class: {clas}, Grades: {avarageGrade}");
	}
}

public class Book
{
	public string Title {get; set;}
	public string Author {get; set;}
	public int Year {get; set;}
	public bool IsAvailable {get; set;}
	public Book(string Title, string Author, int Year, bool IsAvailable)
	{
		this.Title = Title;
		this.Author = Author;
		this.Year = Year;
		this.IsAvailable = IsAvailable;
	}

	public void TakeOut()
	{
		IsAvailable = false;
	}
	public void Return()
	{
		IsAvailable = true;
	}
}

public class Library
{
	public List<Book> BookList = new List<Book>();

	public void AddBook(Book b)
	{
		BookList.Add(b);
	}

	public void ShowAll()
	{
		foreach (var book in BookList)
		{
				Console.WriteLine($"Title:'{book.Title}',Author:{book.Author},Year:{book.Year} [{book.IsAvailable}]");
		}
	}

	public void FindByAuthor(string author)
	{
		foreach (var book in BookList)
		{
			if(book.Author==author){
				Console.WriteLine($"Title:'{book.Title}',Author:{book.Author},Year:{book.Year} [{book.IsAvailable}]");
			}
		}
	}
}

public class Program
{
	public static void Main()
	{
		var student = new Student("Person", 15, 10, 9.5);
		student.Introduce();
		
		var lib = new Library();

		lib.AddBook(new Book("Test", "auth", 42, false));
		lib.AddBook(new Book("AnotherTest", "auth2", 2048, true));
		
		lib.ShowAll();
		lib.FindByAuthor("auth2");
	}
}