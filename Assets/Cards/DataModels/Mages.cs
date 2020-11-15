using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards.Data
{
    [CreateAssetMenu(fileName = "Default", menuName = "Cards/Create Mage Cards")]
    public class Mages : ScriptableObject
    {
        public UnplayableCard[] MageCardsData;
    }
}
