using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

// Interfaz para Observer
public interface IObserver
{
    void Update(string message);
}

// Singleton NotificationManager
public class NotificationManager
{
    private static NotificationManager _instance;
    private List<IObserver> observers = new List<IObserver>();

    public delegate void NotificationHandler(string message);
    public event NotificationHandler OnNotify;

    private NotificationManager() { }

    public static NotificationManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new NotificationManager();
            return _instance;
        }
    }

    public void Subscribe(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }

        OnNotify?.Invoke(message);
    }
}

// Clase que actúa como Observer y maneja la UI
public class NotificationSystem : MonoBehaviour, IObserver
{
    public TextMeshProUGUI notificationText;
    public Button sendButton;
    public Button clearButton;

    private void Start()
    {
        NotificationManager.Instance.Subscribe(this);

        sendButton.onClick.AddListener(() => NotificationManager.Instance.Notify("¡Nuevo mensaje en Unity!"));
        clearButton.onClick.AddListener(() => notificationText.text = "Notificaciones: ");
    }

    public void Update(string message)
    {
        notificationText.text += "\n" + message;
    }
}
