using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJaw : MonoBehaviour {
    float angle;
    float originalRotation;

    public void Start()
    {

    }
    public void Update()
    {
        angle += Time.deltaTime * 20;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    /*
    private bool rotating = true;
    public void Update()
    {
        if (rotating)
        {
            Vector3 angleToRotateTo = new Vector3(0, 0, 90);
            if (Vector3.Distance(transform.eulerAngles, angleToRotateTo) > 0.01f)
            {
                transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, angleToRotateTo, Time.deltaTime);
            }
            else
            {
                transform.eulerAngles = angleToRotateTo;
                rotating = false;
            }
        }

    } 
    // Update is called once per frame
    /*
	public void Update () {
        transform.Rotate(Time.deltaTime, 0, 0);
        // transform.Rotate(Vector3.right * Time.deltaTime);
    }
    */
}
