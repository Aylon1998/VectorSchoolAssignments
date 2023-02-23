using UnityEngine;
using CardGameCode.DataLayer;
using UnityEngine.UI;
using TMPro;

namespace CardGameCode.VisualLayer { 

    public class CardDisplay : MonoBehaviour
    {
        #region Variables 

        [SerializeField] private TextMeshProUGUI cardDescriptionText, cardStrengthText ,cardNameText;
        [SerializeField] private Image frontSideImage;
        [SerializeField] private Scrollbar manaBar;

        public CardData cardData;

        private string ChooseCardName()
        {
            switch (cardData.cardType)
            {
                case CardData.CardType.PowerUpCard:
                    return "Power Up Card";

                case CardData.CardType.EventCard:
                    return "Event Card";

                case CardData.CardType.FailureCard:
                    return "Failure Card";

                case CardData.CardType.SurvivalCard:
                    return "Survival Card";

                default:
                    return "Unknown Card Type";
            }
        }

        #endregion

        #region Methods 

        private void Start()
        {
            manaBar.size = cardData.CardMana;
        }

        private void OnValidate()
        {
            if (cardData != null)
            {
                cardDescriptionText.text = cardData.CardDescription;
                cardStrengthText.text = cardData.CardStrength.ToString();
                cardNameText.text = ChooseCardName();
                frontSideImage.sprite = cardData.frontSideArt;
            }
        }

        #endregion

    }
}