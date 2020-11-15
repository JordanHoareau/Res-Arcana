using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards
{
    [Serializable]
    public class PlayableCard : GenericCard
    {
        [Header("Price")]
        public int ElanPrice;
        public int LifePrice;
        public int CalmPrice;
        public int DeathPrice;
        public int GoldPrice;
    }
}