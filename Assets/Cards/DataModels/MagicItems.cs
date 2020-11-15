using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards.Data
{
    [CreateAssetMenu(fileName = "Default", menuName = "Cards/Create Magic Items Cards")]
    public class MagicItems : ScriptableObject
    {
        public UnplayableCard[] MagicItemCardsData;
    }
}
