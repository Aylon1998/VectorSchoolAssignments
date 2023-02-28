using System;
using UnityEngine;

namespace VectorSchool.DataLayer
{
    [CreateAssetMenu(fileName = "PlayerModel", menuName = "GameData/PlayerModel")]
    public class PlayerModel : ScriptableObject
    {
        #region Fields

        private int _coinsBalance, _gemsBalance;

        #endregion

        #region Properties

        public int CoinsBalance => _coinsBalance;
        public int GemsBalance => _gemsBalance;

        #endregion

        #region Events 

        public event Action<int> CoinsBalanceChanged;
        public event Action<int> GemsBalanceChanged;

        #endregion

        #region Methods

        public void AddCoins(int amountOfCoinsToAdd)
        {
            _coinsBalance += amountOfCoinsToAdd;
            CoinsBalanceChanged?.Invoke(_coinsBalance);
        }

        public void WithdrawCoins(int amountOfCoinsToWithdraw)
        {
            if (_coinsBalance >= amountOfCoinsToWithdraw)
            {
                _coinsBalance -= amountOfCoinsToWithdraw;
                CoinsBalanceChanged?.Invoke(_coinsBalance);

            }
        }

        public void AddGems(int amountOfGemsToAdd)
        {
            _gemsBalance += amountOfGemsToAdd;
            GemsBalanceChanged?.Invoke(_gemsBalance);
        }

        public void WithdrawGems(int amountOfGemsToWithdraw)
        {
            if (_gemsBalance >= amountOfGemsToWithdraw)
            {
                _gemsBalance -= amountOfGemsToWithdraw;
                GemsBalanceChanged?.Invoke(_gemsBalance);

            }
        }

        #endregion

    }
}
