using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Rigidbody player = GameObject.FindWithTag("Player").GetComponent<Rigidbody>();

        transform.LookAt(player.transform);
	}
}
