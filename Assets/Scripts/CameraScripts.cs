using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScripts : MonoBehaviour
{
    public GameObject player;
    public float start, end;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // vi tri nhan vat
        var playerX = player.transform.position.x;
        // vi tri camera
        var camX = transform.position.x;
        var camY = transform.position.y; // 0
        var camZ = transform.position.z; // -10

        if (playerX > start && playerX < end) {
            camX = playerX;
        }else {
            if (playerX < start) {
                camX = start;
            }
            if (playerX > end) {
                camX = end;
            }
        }
        // set lai vi tri camera
        transform.position = new Vector3(camX, camY, camZ);
    }
}
