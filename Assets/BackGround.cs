using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
public GameObject Sprite1UI;
public GameObject Sprite2UI;
public GameObject Sprite3UI;
public GameObject Sprite4UI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void Sprite1(){
    Sprite1UI.SetActive(true);
    Sprite2UI.SetActive(false);
}
public void Sprite2(){
    Sprite2UI.SetActive(true);
    Sprite1UI.SetActive(false);
    }
}
