﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPress : MonoBehaviour {

    public void LoadSceneOnClick()
    {
        Application.OpenURL("http://debmayers.com/");
        Debug.Log("tried opening URL");
    }
}