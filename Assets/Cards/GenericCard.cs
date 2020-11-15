using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ResArcana.Cards.Powers;
using System;

namespace ResArcana.Cards
{
    [Serializable]
    public class GenericCard
    {
        public string Name;
        public Sprite CardSprite;

        [Header("Collect")]
        public int ElanCollect;
        public int LifeCollect;
        public int CalmCollect;
        public int DeathCollect;
        public int GoldCollect;

        public GenericPower[] Powers;
    }
}
