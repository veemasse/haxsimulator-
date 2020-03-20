using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timescript : MonoBehaviour
{
    
    void Start() {
       
    }

    // Update is called once per frame
    void Update()
    {
        Invoke ("WaitingMethod", 5f);
    }
    void WaitingMethod()
    {
        SceneManager.LoadScene("LevelFail");
    }
}
