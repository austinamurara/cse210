public class Reference {
    private string _book;
    private int _chapter, _verse, _endVerse;
    public Reference(string book, int chapter, int verse) { 
        _book = book; _chapter = chapter; _verse = verse; _endVerse = verse; 
    }
    public Reference(string book, int chapter, int startV, int endV) { 
        _book = book; _chapter = chapter; _verse = startV; _endVerse = endV; 
    }
    public string GetDisplayText() => _verse == _endVerse ? $"{_book} {_chapter}:{_verse}" : $"{_book} {_chapter}:{_verse}-{_endVerse}";
}