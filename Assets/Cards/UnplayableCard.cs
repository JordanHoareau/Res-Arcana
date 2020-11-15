using ResArcana.Cards;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards
{
    public enum CardType { Mage, MagicItem }
    [Serializable]
    public class UnplayableCard : GenericCard
    {
        public CardType Type;
    }
}
