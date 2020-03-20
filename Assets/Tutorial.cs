using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
 public void NextTutorial () 
 {
  SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
 }
public void LoadNextTutorial (){
SceneManager.LoadScene("Tutorial2");
}
}