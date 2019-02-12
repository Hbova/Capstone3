using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour {

    public float rotationSpeed = 80;
    public float moveSpeed = 5;


    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        player.transform.Rotate(new Vector3(0f, Time.deltaTime * rotationSpeed * Input.GetAxis("Horizontal"), 0f));
        player.transform.Translate(new Vector3(0f,0f, Time.deltaTime * moveSpeed * Input.GetAxis("Vertical") * -1));
    }
}
