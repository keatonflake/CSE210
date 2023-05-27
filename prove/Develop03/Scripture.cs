class Scripture
{

    private List<string> wordList = new List<string>();

    private string _scripture;

    private string _newScripture;

    // placeholder for random
    private int _randomValue;

    private string display;

    private string resp;

    // constructor
    public Scripture(string scripture)
    {
        _scripture = scripture;

        // array to hold individual words
        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            // adding to private wordList
            wordList.Add(word);
        }
    }

    public void Display()
    {
        Console.WriteLine(string.Join(" ", wordList));
    }

    // main method
    public string HideMore()
    {
        _newScripture = "";

        int hideAmount = wordList.Count / 3;
        int loop = 0;

        // do this loop for 1/3 of the length of the amount of words in scripture
        while (loop <= hideAmount)
        {
            RandomValue();

            // creating instance of Word class called newWord and sending a random word there
            Word newWord = new Word(wordList[_randomValue]);

            string singleWord = wordList[_randomValue];

            // check the first letter of the word and if its an _ then add 1 to the random index
            if (singleWord.Substring(0, 1) == "_")
            {
                if (_randomValue >= wordList.Count)
                {
                    _randomValue = 0;
                }
                else
                {
                    _randomValue += 1;
                }
            }

            // hide word
            newWord.Hide();

            // hidden word is returned from GetText
            string hiddenWord = newWord.GetText();

            // word in word list is replaced by the hiddenWord
            wordList[_randomValue] = hiddenWord;

            loop++;
        }

        // grabbing all words from word list and puting them back together to a string
        foreach (string i in wordList)
        {
            _newScripture += i + " ";
        }
        Console.Clear();
        return _newScripture;
    }

    private void RandomValue()
    {
        Random r = new Random();
        int random = r.Next(0, wordList.Count - 1);
        if (random >= wordList.Count)
        {
            random = 0;
        }
        _randomValue = random;
        // Console.WriteLine(_randomValue);
    }

    public bool AllHidden()
    {
        int hidden = 0;

        foreach (string w in wordList)
        {
            if (w.Substring(0, 1) == "_")
            {
                hidden += 1;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Hidden word count: {hidden}");
        if (hidden == wordList.Count)
        {
            return false;
        }
        return true;
    }
}