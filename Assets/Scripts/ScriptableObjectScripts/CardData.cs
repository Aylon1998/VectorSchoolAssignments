using UnityEngine;

namespace CardGameCode.DataLayer
{
    [CreateAssetMenu(fileName = "GenericCardData", menuName = "Card/GenericCardData")]
    public class CardData : ScriptableObject
    {
        #region Fields

        [SerializeField] [Range(1, CardStrengthMaxValue)] private int _cardStrength;
        [SerializeField] [Range(0, CardManaMaxValue)] private float _cardMana;
        [TextArea] [SerializeField] private string _cardDescription;
        [SerializeField] private Sprite _frontSideArt;


        public CardType cardType;

        #endregion

        #region Constants

        private const int CardStrengthMaxValue = 10;
        private const float CardManaMaxValue = 1f;

        #endregion

        #region Properties

        public int CardStrength
        {
            get { return _cardStrength; }
            set { _cardStrength = Mathf.Clamp(value, 1, CardStrengthMaxValue); }
        }

        public float CardMana
        {
            get { return _cardMana; }
            set { _cardMana = Mathf.Clamp(value, 0, CardManaMaxValue); }
        }

        public string CardDescription => _cardDescription;
        public Sprite FrontSideArt => _frontSideArt;

        #endregion

        #region Enums

        public enum CardType
        {
            PowerUpCard,
            EventCard,
            FailureCard,
            SurvivalCard
        }

        #endregion
    }
}