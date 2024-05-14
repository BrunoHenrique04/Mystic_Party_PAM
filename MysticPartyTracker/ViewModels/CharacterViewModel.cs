using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject
    {
        public CharacterViewModel()
        {
            AddCharCommand = new Command(AddChar);

        }

        public ICommand AddCharCommand { get; }

        [ObservableProperty]
        public string _name;
        [ObservableProperty]
        public string _class;
        [ObservableProperty]
        public int _level;
        [ObservableProperty]
        public string _race;

        private ObservableCollection<Character> _character = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _character; }
            set { _character = value; }
        }


        public void AddChar()
        {

            _character.Add(new Character(Name, Class, Race, Level));
        }


    }
}
