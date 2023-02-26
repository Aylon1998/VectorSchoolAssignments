using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGameCode
{
    public class ButtonFunctionality : MonoBehaviour
    {
        public void OnPrintConfigButtonClick()
        {
            var currentGameConfiguration = GameConfiguration.Instance.CurrentConfig;
            Debug.Log(currentGameConfiguration);
        }
    }
}
