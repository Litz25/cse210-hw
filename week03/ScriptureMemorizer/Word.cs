public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Here I hide word
    public void Hide()
    {
        _isHidden = true;
    }

    // here I Show word
    public void Show()
    {
        _isHidden = false;
    }

    // Chere I check the hidden status
    public bool IsHidden()
    {
        return _isHidden;
    }

    // here it display word or underscores
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}