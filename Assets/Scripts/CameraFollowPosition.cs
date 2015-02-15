using UnityEngine;
using System.Collections;

public class CameraFollowPosition : MonoBehaviour {
	public Transform Target;
	public float TargetYEuler = 45f;

	private Vector3 _initialOffset;

	// Use this for initialization
	void Start () {
		_initialOffset = transform.position - Target.position;
	}

	void Update() {
//		if(Input.GetKeyDown(KeyCode.Space)) {
//			TargetYEuler = Target.rotation.eulerAngles.y;
//		}
	}

	// Update is called once per frame
	void OnPreRender () {
		transform.position = Target.position + _initialOffset;

//		transform.rotation = Quaternion.Slerp(transform.rotation, 
//		                                      Quaternion.Euler (transform.rotation.eulerAngles.x, 
//		                                      					TargetYEuler,
//		                                      					transform.rotation.eulerAngles.z),
//		                                      0.125f);
	}
}
