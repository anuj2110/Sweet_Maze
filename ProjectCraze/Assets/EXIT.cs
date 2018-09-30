using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EXIT : MonoBehaviour {

    // Use this for initialization
    public Button Exit;
    // Use this for initialization
    void Start()
    {
        Button btn1 = Exit.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void TaskOnClick()
    {
        //Output this to console when the Button is clicked
        Application.Quit();
        Debug.Log("You have clicked the button!");
    }
}
