using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards.Data
{
    [CreateAssetMenu(fileName = "Default", menuName = "Cards/Create Place of Power Cards")]
    public class PlaceOfPowers : ScriptableObject
    {
        public PlayableCard[] PlaceOfPowerCardsData;
    }
}
