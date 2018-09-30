using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SCENECHANGE : MonoBehaviour {
   
    
    public void change_screen(string name)
    {
 
            SceneManager.LoadScene(name);
            
    }
		
	
}
