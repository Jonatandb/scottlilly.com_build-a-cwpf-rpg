// https://scottlilly.com/build-a-cwpf-rpg/
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged( nameof(Name) );
            }
        }

        public string CharacterClass {
            get { return _characterClass; }
            set
            {
                _characterClass = value;
                OnPropertyChanged( nameof(CharacterClass) );
            }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
            set
            {
                _hitPoints = value;
                OnPropertyChanged( nameof(HitPoints) );
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                _experiencePoints = value;
                OnPropertyChanged( nameof(ExperiencePoints) );
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropertyChanged( nameof(Level) );
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged( nameof(Gold) );
            }
        }

        /// <summary>
        /// An ObservableCollection automatically notifies the UI 
        /// when objects are added to it, or removed from it. 
        /// Because of this, we don’t need to call “OnPropertyChanged” 
        /// every time we modify the item’s in the player’s inventory.
        /// </summary>
        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }
    }
}
