using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using ResArcana.Essences;

namespace ResArcana.Cards.GameCards
{
    public abstract class GenericGameCard : MonoBehaviour
    {
        private string Name;
        private Sprite CardSprite;

        private readonly Dictionary<EssenceType, int> collectedEssences = new Dictionary<EssenceType, int> {
            {EssenceType.Calm, 0 },
            {EssenceType.Death, 0 },
            {EssenceType.Elan, 0 },
            {EssenceType.Gold, 0 },
            {EssenceType.Life, 0 }
        };
        public abstract void InitializeCard();
    }
}
