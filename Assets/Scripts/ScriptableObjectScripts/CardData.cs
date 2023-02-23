using UnityEngine;

namespace CardGameCode.DataLayer
{
    [CreateAssetMenu(fileName = "GenericCardData", menuName = "Card/GenericCardData")]

        public class CardData : ScriptableObject
        {
             #region Variables

            [SerializeField] [Range(1,cardStrengthMaxValue)] private int cardStrength;
            [SerializeField] [Range(0, cardManaMaxValue)] private float cardMana;
            [TextArea] [SerializeField] private string cardDescription;

            private const int cardStrengthMaxValue = 10;
            private const float cardManaMaxValue = 1f;

            public Sprite frontSideArt;
            public CardType cardType;

            public int CardStrength
            { 
                get { return cardStrength; }

                set 
                {
                    if(value >= cardStrengthMaxValue)
                    {
                        value = cardStrengthMaxValue;
                    }

                    cardStrength = value;
                } 
            }

            public float CardMana
            {
                get { return cardMana; }

                set
                {
                    if (value >= cardManaMaxValue)
                    {
                        value = cardManaMaxValue;
                    }

                    cardMana = value;
                }
            }

            public string CardDescription => cardDescription;

            #endregion

             #region Enums

            public enum CardType
                 {
                        PowerUpCard,
                        EventCard,
                        FailureCard,
                        SurvivalCard
                 }
            }

            #endregion
}
