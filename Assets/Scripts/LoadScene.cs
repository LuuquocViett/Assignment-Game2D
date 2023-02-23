using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void Load(int index) {
        SceneManager.LoadScene(index);
    }
    public void Restart(int index) {
        SceneManager.LoadScene(0);
    }
}
