namespace Library_Management_System;

class Book : LibraryItem
{
    public string Genre { get; set; }
    public Book(string genre)
    {
        this.Genre = genre;
    }
    public void Read()
    {
        Console.WriteLine("Sefiller");
    }
}
class Magazine : LibraryItem
{
    public void Whrite()
    {
        Console.WriteLine("Maqazin");
    }

}
class DVD : LibraryItem
{
    public void Dvdname()
    {
        Console.WriteLine("Music");
    }

}
struct LibraryLocation
{
    public int Aisle { get; set; }
    public int Shelf { get; set; }
    public LibraryLocation(int aisle, int shelf)
    {
        this.Aisle = aisle;
        this.Shelf = shelf;

    }
}
public static class LibraryHelper
{
    public static int CalculateAge(this LibraryItem item)
    { 
    if (item == null) 
            return 0;

    
    }
    public static int ToTitleCase(this LibraryItem item)
    { 
    
    
    }

}
class LibraryCatalog
{ 

}
//Book, Magazine və DVD class-ları yaradılmalı və hər biri Library Item class-dan miras almalıdır.
//Polymorphism tətbiq edilərək hər bir class üçün Display İnfo method-u özəlləştirilməlidir.

//Book class-ı
//* Genre(Janr)

//* LibraryLocation
//Not: Fiction, NonFiction, Science, Art janrlarından biri saxlanıla bilər bunun üçün də BookJenre Enum yaradılmalıdır.
//LibraryLocation bir struct olmalı və daxilində Aisle(Koridor) və Shelf(Rəf) dəyərlərini saxlamalıdır.
//Biz beləliklə kitabın harada yerləşdiyini tapmalıyıq.Hər iki dəyər integer olmalıdır.

//LibraryHelper class-ı
//CalculateAge() extension method-u yer alır.Bu Method Libraryİtem-dan törəyən hər bir item üçün buraxılışından neçə ilk keçdiyini hesablayır.


//ToTitleCase() extension method-u yer alır.Bu Method Libraryİtem-dan törəyən hər bir item üçün Title-larını düzgün hala gətirmək üçün istifadə edilir.
//LibraryCatalog class-ı
//Daxilində hər bir kitabı id ilə gətirən bir indexer-i olmalıdır.

//Not: Əgər Catalogda olmayan bir kitab əldə edilməyə çalışılsa CustomBookError exception işə düşməli və Daxilin edilən Id-ə sahib kitabın catalogda yer almadığı mesajı verməlidir.
