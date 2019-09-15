using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoord, int yCoord, string name, string description, string imageName)
        {
            _locations.Add(
                new Location() {
                    XCoordinate = xCoord,
                    YCoordinate = yCoord,
                    Name = name,
                    Description = description,
                    ImageName = imageName           
                }
            );
        }

        internal Location LocationAt(int xCoord, int yCoord)
        {
            foreach( Location loc in _locations )
            {
                if( loc.XCoordinate == xCoord && loc.YCoordinate == yCoord )
                    return loc;
            }
            return null;
        }
    }
}
