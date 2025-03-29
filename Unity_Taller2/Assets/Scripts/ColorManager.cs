using System;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance { get; private set; }

    public event Action<Color> OnColorChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetColorRed()
    {
        ChangeColor(Color.red);
    }

    public void SetColorBlue()
    {
        ChangeColor(Color.blue);
    }

    public void SetColorGreen()
    {
        ChangeColor(Color.green);
    }

    private void ChangeColor(Color newColor)
    {
        OnColorChanged?.Invoke(newColor);
    }
}

public interface IColorObserver
{
    void OnColorChanged(Color newColor);
    public void Subscribe();
    public void UnSubscribe();

}
