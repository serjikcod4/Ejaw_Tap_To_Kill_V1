using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts.BaseScripts;

//Скрипт который добавляет в список событие вызова паузы при клике на Паузу 
public class PauseObjectScript : MonoBehaviour
{
    public Button pauseButton;

    private void Start()
    {
        pauseButton = GetComponent<Button>();
        //Добавление события в список
        pauseButton.onClick.AddListener(MainScript.GetMainScript.pauseController.Pause);
    }
}
