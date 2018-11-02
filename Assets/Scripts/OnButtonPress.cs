using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnButtonPress : MonoBehaviour {

    public void Start()
    {
        var colors = GetComponent<Button>().colors;
        colors.normalColor = Color.blue;
        colors.pressedColor = Color.white;
        GetComponent<Button>().colors = colors;
    }

 


}
