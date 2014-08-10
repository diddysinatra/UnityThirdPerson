using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed;
	private float maxSpeed = 5f;
	private Vector3 input;
	private Vector3 spawn;

	// Use this for initialization
	void Start () {
		spawn = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if(rigidbody.velocity.magnitude < maxSpeed){
			rigidbody.AddForce(input * moveSpeed);
		}
	}
	
	void OnCollisionEnter(Collision other){
		print("What Did I Hit?");
		if(other.transform.tag == "Enemy"){
			print ("An enemy");
			transform.position = spawn;
		}
	}
}
