using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Riddle : MonoBehaviour {

    [SerializeField] private string question;
    [SerializeField] private string option1;
    [SerializeField] private string option2;
    [SerializeField] private string option3;
    [SerializeField] private string option4;
    [SerializeField] private Button answer;

    public GameObject player;

	// Use this for initialization
	void Start () {
        Text [] newText = GetComponentsInChildren<Text>();
        newText[0].text = question;
        newText[1].text = option1;
        newText[2].text = option2;
        newText[3].text = option3;
        newText[4].text = option4;

        Button bt = answer.GetComponent<Button>();
        bt.onClick.AddListener(AnswerMatch);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void AnswerMatch()
    {
        gameObject.SetActive(false);
        player.SetActive(true);
    }
}
