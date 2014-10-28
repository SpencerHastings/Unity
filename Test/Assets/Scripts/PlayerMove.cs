using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	Vector2 velocity;
	float movespeed = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		velocity = new Vector2 (Input.GetAxis ("Horizontal") * movespeed, Input.GetAxis ("Vertical") * movespeed);
		transform.position += new Vector3 (velocity.x, velocity.y, 0);
	
	}
}
