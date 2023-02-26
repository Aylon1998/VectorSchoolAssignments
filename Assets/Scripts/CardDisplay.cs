 using UnityEngine;
 using CardGameCode.DataLayer;
 using UnityEngine.UI;
 using TMPro;

 namespace CardGameCode.VisualLayer { 

    public class CardDisplay : MonoBehaviour
    {
        #region Fields

        [SerializeField] private TextMeshProUGUI _cardDescriptionText, _cardStrengthText ,_cardNameText;
        [SerializeField] private Image _frontSideImage;
        [SerializeField] private Scrollbar _manaBar;
        [SerializeField] private CardData cardData;

        #endregion

        #region Methods 

        private void Start()
        {
            _manaBar.size = cardData.CardMana;
        }

        private void OnValidate()
        {
            if (cardData == null)
            {
                return;
            }

             _cardDescriptionText.text = cardData.CardDescription;
             _cardStrengthText.text = cardData.CardStrength.ToString();
             _cardNameText.text = ChooseCardName();
             _frontSideImage.sprite = cardData.FrontSideArt;
            
        }
        
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

    }
}