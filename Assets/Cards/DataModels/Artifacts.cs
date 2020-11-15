using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Cards.Data
{
    [CreateAssetMenu(fileName = "Default", menuName = "Cards/Create Artifact Cards")]
    public class Artifacts : ScriptableObject
    {
        public PlayableCard[] ArtifactCardsData;
    }
}
