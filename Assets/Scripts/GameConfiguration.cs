using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardGameCode.DataLayer;

namespace CardGameCode
{
    public class GameConfiguration
    {
       
        #region Constants 

        private const string MASTER_CONFIG_RESOURCE_NAME = "GameConfigurationSelectorData";

        #endregion


        #region Fields

        private static GameConfiguration _instance;
        private readonly GameConfigurationSelector _GameConfigurationSelector;

        #endregion


        #region Constructors

        private GameConfiguration(string configurationSelectorResourceName)
        {
            _GameConfigurationSelector = Resources.Load<GameConfigurationSelector>(configurationSelectorResourceName);
        }

        #endregion

        #region Properties

        public static GameConfiguration Instance => _instance ??= new GameConfiguration(MASTER_CONFIG_RESOURCE_NAME);


        public string CurrentConfig => _GameConfigurationSelector.GetCurrentConfig();

        #endregion
    }
}
