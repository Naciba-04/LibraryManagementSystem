namespace Library_Management_System;


abstract class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

}

internal class Librarian : Person
{
    public int HireDate { get; set; }
}

sealed class LibraryMember : Person
{
    public int Membershipdate { get; set; }
}
abstract class LibraryItem
{
    public string Title { get; set; }
    public DateTime PublicationYear { get; set; }
    public abstract void DisplayInfo();

    protected LibraryItem(string title, DateTime publicationYear)
    {
        this.Title = title;
        this.PublicationYear = publicationYear; 
    }
}
 


