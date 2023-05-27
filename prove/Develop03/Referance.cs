class Referance
{
    private string _book;

    private int _chapter;

    private int _beginningVerse;

    private int _endingVerse;


    public Referance(string book, int chapter, int beginningVerse, int endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _beginningVerse = beginningVerse;
        _endingVerse = endingVerse;
    }

    public string GetString()
    {
        if (_endingVerse == 0)
        {
            return $"{_book}: {_chapter} {_beginningVerse}";
        }
        return $"{_book}: {_chapter} {_beginningVerse} - {_endingVerse}";
    }

}