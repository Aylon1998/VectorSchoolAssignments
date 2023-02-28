using UnityEngine;

namespace VectorSchool.DataLayer
{
    public class PlayerDataManager
    {
        #region Constants 

        private const string COINS_BALANCE_KEY = "CoinsBalance";
        private const string GEMS_BALANCE_KEY = "GemsBalance";

        #endregion

        #region Fields

        private PlayerModel _playerModel;

        #endregion

        #region Methods

        public void Initialize(PlayerModel playerModel)
        {
            _playerModel = playerModel;
        }

        public void Save()
        {
            PlayerPrefs.SetInt(COINS_BALANCE_KEY, _playerModel.CoinsBalance);
            PlayerPrefs.SetInt(GEMS_BALANCE_KEY, _playerModel.GemsBalance);
            PlayerPrefs.Save();
        }

        public void Load()
        {
            int coinsBalance = PlayerPrefs.GetInt(COINS_BALANCE_KEY, 0);
            int gemsBalance = PlayerPrefs.GetInt(GEMS_BALANCE_KEY, 0);

            _playerModel.AddCoins(coinsBalance);
            _playerModel.AddGems(gemsBalance);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void OnBeforeSceneLoad()
        {
            var playerModelProvider = PlayerModelProvider.Instance;
            var playerDataManager = new PlayerDataManager();
            playerDataManager.Initialize(playerModelProvider.GetPlayerModel());
            playerDataManager.Load();
        }

        #endregion

    }
}