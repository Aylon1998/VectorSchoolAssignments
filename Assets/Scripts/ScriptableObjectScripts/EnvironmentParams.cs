using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGameCode.DataLayer
{
    [CreateAssetMenu(fileName = "EnvironmentParamsData", menuName = "GameData/EnvironmentParamerters")]

    public class EnvironmentParams : ScriptableObject
    {
        #region Fields

        [SerializeField] private string _serverAddress, _logPrefix;
        [SerializeField] private float _serverTimeOut;
        [SerializeField] private int _gameVersion;

        #endregion

        #region Properties

        public string ServerAddress => _serverAddress;
        public string LogPrefix => _logPrefix;
        public float ServerTimeOut => _serverTimeOut;
        public int GameVersion => _gameVersion;

        #endregion

        #region Methods

        public string PrintConfigurationValues()
        {
            return $"Server: {ServerAddress}, Time Our: {ServerTimeOut}, Log Prefix: {LogPrefix}, Game Version: {GameVersion}";
        }

        #endregion
    }
}
