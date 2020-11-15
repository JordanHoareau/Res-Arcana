using ResArcana.Cards.Data;
using ResArcana.Cards.GameCards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ResArcana.Game
{
    public class GameController : MonoBehaviour
    {
        [Header("Data from ScriptableObjects")]
        [SerializeField]
        private Artifacts dataArtifacts;
        [SerializeField]
        private Mages dataMages;
        [SerializeField]
        private MagicItems dataMagicItems;
        [SerializeField]
        private Monuments dataMonuments;
        [SerializeField]
        private PlaceOfPowers dataPlaceOfPowers;

        private List<PlayableGameCard> artifacts = new List<PlayableGameCard>();
        private List<UnplayableGameCard> mages = new List<UnplayableGameCard>();
        private List<PlayableGameCard> placeOfPowers = new List<PlayableGameCard>();
        private List<PlayableGameCard> monuments = new List<PlayableGameCard>();
        private List<UnplayableGameCard> magicItems = new List<UnplayableGameCard>();

        /// <summary>
        /// Initialize a Res Arcana Game
        /// Starting deal :
        /// - 8 Artifact Cards
        /// - 2 Mage Cards
        /// - 5 Place of Power Cards
        /// - 1 Essence of every type per Player
        /// </summary>
        private void CreateGame()
        {

        }

        /// <summary>
        /// Create every necessary assets for Unity from Scriptable Objects
        /// </summary>
        private void Start()
        {
            foreach(var dataArtifact in dataArtifacts.ArtifactCardsData)
            {

            }
        }
    }
}