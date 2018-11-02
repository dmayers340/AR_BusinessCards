using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPath : MonoBehaviour {
    public GameObject[] paths;
    public GameObject pathObject;
    public bool currentState;
    public Button button;

    public void Start()
    {
        button.onClick.AddListener(showObject);
        currentState = false;

        foreach (GameObject path in paths)
        {
            path.SetActive(false);
        }

    }

    public void showObject()
    {
            StartCoroutine(ShowPaths());
    
    }

    IEnumerator ShowPaths()
    {
        foreach (GameObject path in paths)
        {
            path.SetActive(true);
            yield return new WaitForSeconds(1);
        }

    }
}