using UnityEngine;

namespace VectorSchool.DataLayer
{
    public class PlayerModelProvider
    {
        #region Constants 

        private const string MASTER_PLAYER_MODEL_RESOURCE_NAME = "PlayerModel";

        #endregion


        #region Fields

        private static PlayerModelProvider _instance;
        private readonly PlayerModel _playerModel;

        #endregion


        #region Constructors

        private PlayerModelProvider(string playerModelResourceName)
        {
            _playerModel = Resources.Load<PlayerModel>(playerModelResourceName);
        }

        #endregion

        #region Properties

        public static PlayerModelProvider Instance => _instance ??= new(MASTER_PLAYER_MODEL_RESOURCE_NAME);

        #endregion

        #region Methods

        public PlayerModel GetPlayerModel() => _playerModel;

        #endregion
    }
}

