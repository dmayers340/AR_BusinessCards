using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonPress : MonoBehaviour {

    public Button button;
    public Color colorToTurnWhenPressed;
    bool hasBeenPressed;

    public void Start()
    {
        hasBeenPressed = false;
    }
    public void pressedColor()
    {
        if (hasBeenPressed == false)
        {
            ColorBlock colors = button.colors;
            colors.normalColor = Color.blue;
            colors.highlightedColor = colorToTurnWhenPressed;
            colors.pressedColor = colorToTurnWhenPressed;
            button.colors = colors;
            hasBeenPressed = true;
        }
        else
        {
            revertColor();
        }
    }

    public void revertColor()
    {
        ColorBlock colors = button.colors;
        colors.normalColor = Color.blue;
        colors.highlightedColor = Color.blue;
        colors.pressedColor = Color.blue;
        button.colors = colors;
        hasBeenPressed = false;
    }

 


}
