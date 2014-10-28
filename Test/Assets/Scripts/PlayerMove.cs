using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public Vector2 speed = new Vector2(50,50);
	private Vector2 movement;

	// Use this for initialization
	void Start () 
	{
	

	}
	
	// Update is called once per frame
	void Update () 
	{
		movement = new Vector2 (speed.x * Input.GetAxis ("Horizontal"), speed.y * Input.GetAxis ("Vertical"));


	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;

	}
}
