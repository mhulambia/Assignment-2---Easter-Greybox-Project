using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{ 
   public void LoadMyScene(string scene)
    {
        SceneManager.LoadScene(scene);   
    }
}
