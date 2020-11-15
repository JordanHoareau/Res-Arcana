using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards.Data
{
    [CreateAssetMenu(fileName = "Default", menuName = "Cards/Create Monument Cards")]
    public class Monuments : ScriptableObject
    {
        public PlayableCard[] MonumentCardsData;
    }
}
