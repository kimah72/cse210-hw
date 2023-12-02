class Video
{
    // Properties
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    // Method to add a comment to the video
    public void AddComment(string commenterName, string commentTimeStamp, string commentText)
    {
        _comments.Add(new Comment { _commenterName = commenterName, _commentTimeStamp = commentTimeStamp, _commentText = commentText });
    }

    // Method to get the number of comments for the video
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display information about the video and its comments
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine();
        foreach (var comment in _comments)
        {
            Console.WriteLine($"User:{comment._commenterName} - {comment._commentTimeStamp} - {comment._commentText}");
            Console.WriteLine();
        }
        Console.WriteLine(); // Add a newline for better readability
    }
}