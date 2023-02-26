#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion
using UnityEngine;
using UnityEngine.UI;
using VectorSchool.DataLayer;

namespace VectorSchool.VisualLayer
{
    public class PlayerDataView : MonoBehaviour
    {
        #region Editor fields

        [SerializeField]
        private Text _coinsBalanceText;

        [SerializeField]
        private Text _gemsBalanceText;

        #endregion

        #region Private fields

        private PlayerModel _playerModel;

        #endregion

        #region Methods

        private void Start()
        {
            _playerModel = PlayerModelProvider.Instance.GetPlayerModel();
            _playerModel.CoinsBalanceChanged += OnCoinsBalanceChanged;
            _playerModel.GemsBalanceChanged += OnGemsBalanceChanged;

            UpdateUI();
        }

        private void OnDestroy()
        {
            _playerModel.CoinsBalanceChanged -= OnCoinsBalanceChanged;
            _playerModel.GemsBalanceChanged -= OnGemsBalanceChanged;
        }

        private void OnCoinsBalanceChanged(int balance)
        {
            UpdateUI();
        }

        private void OnGemsBalanceChanged(int balance)
        {
            UpdateUI();
        }

        private void UpdateUI()
        {
            _coinsBalanceText.text = _playerModel.CoinsBalance.ToString();
            _gemsBalanceText.text = _playerModel.GemsBalance.ToString();
        }

        #endregion
    }
}