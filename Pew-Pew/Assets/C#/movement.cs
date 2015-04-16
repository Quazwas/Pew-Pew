using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public GameObject player;
	public Rigidbody rb;

	public float speed = 5;


	void move() {
		rb.velocity = new Vector3 (Input.GetAxis("Horizontal") * speed, rb.velocity.y, Input.GetAxis("Vertical") * speed);
	}

	// Use this for initialization
	void Start () {
	
	}
	public NetworkView netView;
	// Update is called once per frame
	void Update () {
		//network.isMine
		if(netView.isMine) {
			move();
		}
	}
}
