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
    private bool hasBeenActivated;

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
        if (hasBeenActivated == false)
        {
            pathObject.SetActive(true);
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
            hasBeenActivated = true;
        }
        else
        {
            if (currentState)
            {
                pathObject.SetActive(false);
            }
            else
            {
                pathObject.SetActive(true);
            }
            currentState = !currentState;

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