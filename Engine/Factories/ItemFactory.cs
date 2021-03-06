﻿using Engine.Models;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Factories
{
    static class ItemFactory
    {
        static List<GameItem> _standardGameItems;

        /// <summary>
        /// The first time anything is used in ItemFactory, 
        /// this function will run and populate our 
        /// _standardGameItems variable with all the items 
        /// in the game.
        /// </summary>
        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(1001, "Palo Punteagudo", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Espada Oxidada", 5, 1, 3));

            _standardGameItems.Add(new GameItem(9001, "Colmillo de serpiente", 1));
            _standardGameItems.Add(new GameItem(9002, "Piel de serpiente", 2));
        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeId);
            if(standardItem != null)
            {
                return standardItem.Clone();
            }
            return null;
        }
    }
}
