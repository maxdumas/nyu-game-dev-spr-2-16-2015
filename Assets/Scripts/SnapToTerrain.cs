using UnityEngine;
using System.Collections;

public class SnapToTerrain : MonoBehaviour {
	public TerrainCollider Terrain;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position, Vector3.down);
		Debug.DrawRay(transform.position, Vector3.down);
		RaycastHit hit;
		if(Terrain.Raycast(ray, out hit, 10f)) {
//			transform.rotation *= Quaternion.FromToRotation(Vector3.up, hit.normal);
			transform.position = hit.point + new Vector3(0, this.collider.bounds.extents.y, 0);
		}
	}
}
