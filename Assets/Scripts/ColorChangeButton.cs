using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChangeButton : MonoBehaviour
{
    public Button button;
    public Color newColor;

    private void Start()
    {
        // Add a listener to the button click event
        button.onClick.AddListener(ChangeColor);
        Debug.Log("Color Change Ready");
    }

    private void ChangeColor()
    {
        // Change the color of the button (or any other object)
        button.image.color = newColor;
        Debug.Log("Change Color " + newColor);
    }
}