class Comment : Video
{
    protected string _name;
    protected List<string> VideoComments = new List<string>();


    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetComment()
    {
        foreach(string comment in VideoComments)
        {
        return comment;
        }
        return "Empty";
    }

    public string GetCommentCount()
    {
        return "The number of comments is: " + VideoComments.Count;
    }
    
    public void SetComment(string comment)
    {
        VideoComments.Add(comment);
    }
}