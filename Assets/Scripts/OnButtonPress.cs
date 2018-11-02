using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnButtonPress : MonoBehaviour {

    public GameObject[] pathObjects; 

    public void Start()
    {
        pathObjects = GameObject.FindGameObjectsWithTag("path");
    }

    public void setupPath() {
        foreach(GameObject path in pathObjects)
        {
            Debug.Log("Show path Pressed");
            path.SetActive(true);
        }
    }

    public void OpenURL()
    {
        Application.OpenURL("http://debmayers.com/");
        Debug.Log("tried opening URL");
    }

}
