using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreen : MonoBehaviour
{
    public Button startButton;
    private void Awake()
    {
        startButton.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        AppLogic.Instance.LoadGame();
    }
}
