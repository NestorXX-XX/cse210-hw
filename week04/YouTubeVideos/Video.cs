class Video
{
    private string _title = "";
    private string _author = "";
    private int _lengthInSeconds = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = comments;
    }
    public int numberOfComments()
    {
        return _comments.Count;
    }

    public void displayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"{_title} ({_author}) (Length: {_lengthInSeconds} seconds)");
        Console.WriteLine();
        Console.WriteLine("Comments: ");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            comment.displayComment();
        }

    }
}