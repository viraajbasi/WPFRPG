﻿using System.Collections.Generic;

namespace Engine.Models
{
    public class Quest
    {
        public int ID
        {
            get;
            set;
        }
        public string NAME
        {
            get;
            set;
        }
        public string DESC
        {
            get;
            set;
        }

        public List<ItemQuantity> ItemsToComplete
        {
            get;
            set;
        }

        public int REWARDEXP
        {
            get;
            set;
        }
        public int REWARDGOLD
        {
            get;
            set;
        }
        public List<ItemQuantity> RewardItems
        {
            get;
            set;
        }

        public Quest(int _id, string _name, string _desc, List<ItemQuantity> _itemstocomplete, int _rewardexp, int _rewardgold, List<ItemQuantity> _rewarditems)
        {
            ID = _id;
            NAME = _name;
            DESC = _desc;
            ItemsToComplete = _itemstocomplete;
            REWARDEXP = _rewardexp;
            REWARDGOLD = _rewardgold;
            RewardItems = _rewarditems;
        }
    }
}