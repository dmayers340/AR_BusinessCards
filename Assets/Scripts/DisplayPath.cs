using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayPath : MonoBehaviour
{
    public GameObject[] paths;
    public GameObject pathObject;
    public bool currentState;
    public Button button;
    private bool firstTime = true;

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
        pathObject.SetActive(true);
        if (firstTime)
        {
            setupPaths();
            firstTime = false;
        }
        else
        {
            quickSetupPath();
        }
        currentState = !currentState;

    }

    public void quickSetupPath()
    {
        if (currentState)
        {
            pathObject.SetActive(false);
        }
        else
        {
            pathObject.SetActive(true);
        }
    }

    public void setupPaths()
    {
        if (currentState)
        {
            foreach (GameObject path in paths)
            {
                path.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(ShowPaths());
        }
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