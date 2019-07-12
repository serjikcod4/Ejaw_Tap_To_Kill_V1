using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.BaseScripts;

public class ContinueObjectScript : MonoBehaviour
{
    public Button pauseButton;

    private void Start()
    {
        pauseButton = GetComponent<Button>();
        pauseButton.onClick.AddListener(MainScript.GetMainScript.pauseController.Unpause);
    }
}
