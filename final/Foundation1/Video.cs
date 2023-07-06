class Video
{
    private string _title;
    private string _author;
    private double _length;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetLength()
    {
        return _length.ToString("F2") +" is the length";
    }

    public void SetLength(double length)
    {
        _length = length;
    }
}   
