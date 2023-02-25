using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGameCode.DataLayer
{
    [CreateAssetMenu(fileName = "GameConfigurationSelectorData", menuName = "GameData/GameConfigurationSelector")]

    public class GameConfigurationSelector : ScriptableObject
    {
        #region Fields

        [SerializeField] private EnvironmentType _environmentType;
        [SerializeField] private EnvironmentParams _productionParams, _developmentParams, _qaParams;

        #endregion

        #region Methods

        public string GetCurrentConfig()
        {
            switch (_environmentType)
            {
                case EnvironmentType.Production:
                    return _productionParams.PrintConfigurationValues();

                case EnvironmentType.Development:
                    return _developmentParams.PrintConfigurationValues();

                case EnvironmentType.QA:
                    return _qaParams.PrintConfigurationValues();

                default:
                    throw new System.Exception("Undefined environment type.");
            }
        }

        #endregion


    }
}

