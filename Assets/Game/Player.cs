using ResArcana.Cards.GameCards;
using ResArcana.Essences;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Game
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private List<PlayableGameCard> hand;
        [SerializeField]
        private UnplayableGameCard mage;
        [SerializeField]
        private UnplayableGameCard magicItem;

        private readonly Dictionary<EssenceType, int> essences = new Dictionary<EssenceType, int> {
            {EssenceType.Calm, 0 },
            {EssenceType.Death, 0 },
            {EssenceType.Elan, 0 },
            {EssenceType.Gold, 0 },
            {EssenceType.Life, 0 }
        };

    }
}