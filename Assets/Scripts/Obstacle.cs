using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float left, right;
    private bool isRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var obstacleX = transform.position.x;
        if (obstacleX < left) {
            isRight = true;
        }
        if (obstacleX > right) {
            isRight = false;
        }
        if (isRight) {
            transform.Translate(new Vector3(Time.deltaTime * 1, 0, 0));
            
        }else {
            transform.Translate(new Vector3(-Time.deltaTime * 1, 0, 0));

        }
    }
}
