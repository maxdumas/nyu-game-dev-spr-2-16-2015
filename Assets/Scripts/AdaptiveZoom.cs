using UnityEngine;
using System.Collections;

public class AdaptiveZoom : MonoBehaviour {
	public Transform Target;
	public float ZoomSpeed;
	public float ZoomFactor;
	public float FOVOffset;
	public float MinFOV;
	public float MaxFOV;
	public float HeightOffset;

	private Vector3 oldPos;

	// Use this for initialization
	void Start () {
		oldPos = Target.position;
	}
	
	// Update is called once per frame
	void Update () {
		this.camera.fieldOfView = Mathf.Lerp(this.camera.fieldOfView, FOVOffset + ZoomFactor * (Target.position.y + HeightOffset), ZoomSpeed);
		this.camera.fieldOfView = Mathf.Clamp(this.camera.fieldOfView, MinFOV, MaxFOV);
		if(Input.GetKey (KeyCode.UpArrow))
		transform.localRotation = Quaternion.Slerp(transform.localRotation,
		                                      Quaternion.Euler(5f,
						                                      transform.localRotation.eulerAngles.y,
						                                      transform.rotation.eulerAngles.z),
		                                      0.02f);
		else
			transform.localRotation = Quaternion.Slerp(transform.localRotation,
			                                           Quaternion.Euler(30f,
			                 transform.localRotation.eulerAngles.y,
			                 transform.rotation.eulerAngles.z),
			                                           0.125f);

		oldPos = Target.position;
	}
}
