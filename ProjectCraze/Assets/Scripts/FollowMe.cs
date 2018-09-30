using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMe : MonoBehaviour {
    public GameObject Collector;
    private Vector3 offset;

    //public Rigidbody player;
   

	// Use this for initialization
	void Start () {
        offset = transform.localPosition - Collector.transform.localPosition;
  }
	
	// Update is called once per frame
	private void FixedUpdate () {
        transform.localPosition = Collector.transform.localPosition + offset;
    }
}
