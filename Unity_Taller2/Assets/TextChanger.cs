using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour, IColorObserver
{

    TextMeshProUGUI m_TextMeshProUGUI;

    [SerializeField]
    private GameObject button;

    private void Awake()
    {
        m_TextMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    public void Subscribe()
    {
        ColorManager.Instance.OnColorChanged += OnColorChanged;
        button.gameObject.SetActive(false);
    }

    public void UnSubscribe()
    {
        ColorManager.Instance.OnColorChanged -= OnColorChanged;
        button.gameObject.SetActive(true);
    }

    public void OnColorChanged(Color newColor)
    {
        m_TextMeshProUGUI.text = ColorToString(newColor); // Convierte el color a texto
        m_TextMeshProUGUI.color = newColor;
    }

    private string ColorToString(Color color)
    {
        if (color == Color.red) return "Red";
        if (color == Color.blue) return "Blue";
        if (color == Color.green) return "Green";
        return "Unknown Color";
    }
}
