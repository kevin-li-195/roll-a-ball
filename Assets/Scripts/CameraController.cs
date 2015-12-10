using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	private Vector3 offset;
	public GameObject player;
	void Start () {
		offset = this.transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		this.transform.position = player.transform.position + offset;	
	}
}
