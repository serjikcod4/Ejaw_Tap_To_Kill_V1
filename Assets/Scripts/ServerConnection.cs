using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Assets.Scripts.BaseScripts;

public class ServerConnection : MonoBehaviour
{
    //Ссылка на UI текст для отображения статусов поключения
    [SerializeField] private Text statusConnection; 

    //Статус подключения к серверу
    private string connecting = "Connecting to Server";
    private string connected = "Connected";

    private void Start()
    {
        //Находим объект по тегу и берем UI текст
        statusConnection = GameObject.FindGameObjectWithTag("statusConnection").GetComponent<Text>();

        //Подключаемся к серверу
        StartCoroutine(NetworkConnectionServer());
    }
    
    /// <summary>
    /// Метод подключения к серверу
    /// </summary>
    private IEnumerator NetworkConnectionServer()
    {
        //Отображаем статус подключения
        statusConnection.text = connecting;        

        //Делаем искусственную задержку подключения между клиентом и сервером
        yield return new WaitForSeconds(2f);

        //Меняем статус подключения на подключенный
        statusConnection.text = connected;
        OnConnectedToServer();

        //Удаляем статус через 2 секунды
        yield return new WaitForSeconds(2f);
        statusConnection.text = null;      
    }

    /// <summary>
    /// Метод, своего рода событие, когда подключились к серверу
    /// </summary>
    private void OnConnectedToServer()
    {
        //Показываем меню
        MainScript.GetMainScript.menuAnimController.ShowMenu();
    }
}
