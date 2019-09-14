using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player: INotifyPropertyChanged
    {
        private string _name;
        private string _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }

        public string Name
        {
            get { return _name; }
            set
            {
                this._name = value;
                OnPropertyChanged( "Name" );
            }
        }

        public string CharacterClass {
            get { return this._characterClass; }
            set
            {
                this._characterClass = value;
                OnPropertyChanged( "CharacterClass" );
            }
        }

        public int HitPoints
        {
            get { return this._hitPoints; }
            set
            {
                this._hitPoints = value;
                OnPropertyChanged( "HitPoints" );
            }
        }

        public int ExperiencePoints
        {
            get { return this._experiencePoints; }
            set
            {
                this._experiencePoints = value;
                OnPropertyChanged( "ExperiencePoints" );
            }
        }

        public int Level
        {
            get { return this._level; }
            set
            {
                this._level = value;
                OnPropertyChanged( "Level" );
            }
        }

        public int Gold
        {
            get { return this._gold; }
            set
            {
                this._level = value;
                OnPropertyChanged( "Gold" );
            }
        }
    }
}
