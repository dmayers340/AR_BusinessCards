using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {

    public Button button;
    public Color changedColor;
    
    void Start()
    {
        ColorBlock colors = button.colors;
        colors.highlightedColor = Color.white;
        colors.pressedColor = changedColor;
        button.colors = colors;
    }

    

}
