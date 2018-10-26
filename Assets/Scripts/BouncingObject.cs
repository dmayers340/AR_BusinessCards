using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingObject : MonoBehaviour {

    public float speed;
    public float height;



    void Update()
    {
        Vector3 position = transform.position;

        float newYValue = Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(position.x, newYValue, position.z) * height;
    }


}
