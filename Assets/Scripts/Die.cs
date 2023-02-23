using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour

{
    public float loseHeight = -6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < loseHeight) {
            Time.timeScale = 0; // stop scane
            gameObject.SetActive(false);
            GameController.instance.check(true);
        }
    }

    
}
