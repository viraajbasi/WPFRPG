﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static List<GameItem> _standardgameitems;

        static ItemFactory()
        {
            _standardgameitems = new List<GameItem>();

            _standardgameitems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardgameitems.Add(new Weapon(1002, "Rusty Sword", 5, 1, 3));
        }

        public static GameItem CreateGameItem(int _itemtypeid)
        {
            GameItem standarditem = _standardgameitems.FirstOrDefault(item => item.ITEMTYPEID == _itemtypeid);

            if(standarditem != null)
            {
                return standarditem.Clone();
            }

            return null;
        }
    }
}