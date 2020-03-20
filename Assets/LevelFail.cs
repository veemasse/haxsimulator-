using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFail : MonoBehaviour
{
    

    void Start()
    {
        
    }
    public void RestartLevel ()
    {
        SceneManager.LoadScene("local");
    }
}
