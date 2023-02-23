using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckWheel : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,speed * Time.deltaTime * 10f);
    }
}
