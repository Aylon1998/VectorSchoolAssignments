#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion
using UnityEngine;
using VectorSchool.DataLayer;

namespace VectorSchool.VisualLayer
{
    public class GameScreen : MonoBehaviour
    {
        #region Editor fields

        [SerializeField]
        private int _coinsToAdd = 30;

        [SerializeField]
        private int _coinsToTake = 30;

        [SerializeField]
        private int _gemsToAdd = 1;

        [SerializeField]
        private int _gemsToTake = 1;

        #endregion

        #region Private fields

        private PlayerModel _playerModel;

        #endregion

        #region Methods

        private void Start()
        {
            _playerModel = PlayerModelProvider.Instance.GetPlayerModel();
        }

        public void OnAddCoinsButtonClick()
        {
            _playerModel.AddCoins(_coinsToAdd);
        }

        public void OnTakeCoinsButtonClick()
        {
            _playerModel.WithdrawCoins(_coinsToTake);
        }

        public void OnAddGemsButtonClick()
        {
            _playerModel.AddGems(_gemsToAdd);
        }

        public void OnTakeGemsButtonClick()
        {
            _playerModel.WithdrawGems(_gemsToTake);
        }

        #endregion

    }
}
