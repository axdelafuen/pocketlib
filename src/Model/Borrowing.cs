namespace Model;

public class Borrowing
{
    public string Id { get; set; }
    public Person Owner  { get; set; }
    public DateTime BorrowedAt { get; set; }
    public DateTime? ReturnedAt { get; set; }
}