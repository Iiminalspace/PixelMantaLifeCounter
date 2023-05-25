using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace PixelMantaLifeCounter.ViewModels
{
    public partial class LifeCounterViewModel : ObservableObject
    {
        public LifeCounterViewModel()
        {
            Life = 40;
        }

        [ObservableProperty]
        int commanderDamage1;

        [ObservableProperty]
        int commanderDamage2;

        [ObservableProperty]
        int commanderDamage3;

        [ObservableProperty]
        int commanderDamage4;

        [ObservableProperty]
        int life;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Pixel), nameof(Manta))]
        int poisonCounters;

        [ObservableProperty]
        bool isMonarch;

        public string Pixel => GetPixelString();

        public string Manta => GetMantaString();

        [RelayCommand]
        public void AddLife()
        {
            Life++;
        }

        [RelayCommand]
        public void AddFiveLife()
        {
            Life += 5;
        }

        [RelayCommand]
        public void LoseLife()
        {
            Life--;
        }

        [RelayCommand]
        public void LoseFiveLife()
        {
            Life -= 5;
        }

        [RelayCommand]
        public void Reset()
        {
            Life = 40;
            PoisonCounters = 0;
            IsMonarch = false;
            CommanderDamage1 = 0;
            CommanderDamage2 = 0;
            CommanderDamage3 = 0;
            CommanderDamage4 = 0;
        }

        private string GetPixelString()
        {
            return PoisonCounters switch
            {
                0 => string.Empty,
                1 => "P",
                2 => "PI",
                3 => "PIX",
                4 => "PIXE",
                _ => "PIXEL",
            };
        }
        private string GetMantaString()
        {
            return PoisonCounters switch
            {
                6 => "M    ",
                7 => "MA   ",
                8 => "MAN  ",
                9 => "MANT ",
                10 => "MANTA",
                _ => string.Empty,
            };
        }
    }
}
