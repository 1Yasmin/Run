using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
public GameObject p1;

public float Speed = 0f;
private float movex = 1f;
private float movey = 1f;

// Use this for initialization
void Start () {
}

// Update is called once per frame
void FixedUpdate () {
	if(p1){
		movex = Input.GetAxis ("P1_horizontal");
		movey = Input.GetAxis ("P1_vertical");
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

	}


}
}
