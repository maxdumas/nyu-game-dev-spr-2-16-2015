using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {
	public float Speed;
	public float TurnSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)) {
			transform.position += transform.forward * Speed * Time.deltaTime;
		} else if(Input.GetKey(KeyCode.S)) {
			transform.position += transform.forward * -Speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D)) {
			transform.Rotate(Vector3.up, TurnSpeed * Time.deltaTime);
		} else if(Input.GetKey(KeyCode.A)) {
			transform.Rotate(Vector3.up, -TurnSpeed * Time.deltaTime);
        }
	}
}
