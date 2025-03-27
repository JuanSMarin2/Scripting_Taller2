using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour, IColorObserver
{
    private RawImage rawImage;

    [SerializeField]
    private GameObject button;

    private void Awake()
    {
        rawImage = GetComponent<RawImage>();
    }

    public void Suscribe()
    {
        ColorManager.Instance.OnColorChanged += OnColorChanged;
        button.gameObject.SetActive(false);
    }

    public void UnSuscribe()
    {
        ColorManager.Instance.OnColorChanged -= OnColorChanged;
        button.gameObject.SetActive(true);
    }

    public void OnColorChanged(Color newColor)
    {
        rawImage.color = newColor;
    }
}
