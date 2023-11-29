namespace CraftLR.Exercice7;

public class HelloButtonViewModel : HelloButtonViewModelBase
{
    private string _buttonCaption;
    private bool _isButtonEnabled = true;
    private int _numberOfClicks;
    public HelloButtonViewModel()
    {
        _buttonCaption = "Hello!";
        _numberOfClicks = 0;
    }

    public string ButtonCaption
    {
        get => _buttonCaption;
        set
        {
            if (_buttonCaption == value) return;
            _buttonCaption = value;
            OnPropertyChanged();
        }
    }

    public bool IsButtonEnabled
    {
        get => _isButtonEnabled;
        set
        {
            if (_isButtonEnabled == value) return;
            _isButtonEnabled = value;
            OnPropertyChanged();
        }
    }

    public void CountClick()
    {
        if (_numberOfClicks >= 5)
        {
            // Empêche de dépasser 5 clicks
            ButtonCaption = "Suppérieur à 5 clicks";
            IsButtonEnabled = false;
        }
        else
        {
            _numberOfClicks++;
            ButtonCaption = $"{_numberOfClicks} Clicks";
        }
    }
}