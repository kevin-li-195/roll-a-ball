using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 10.0f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 mvmt = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (mvmt * speed);
	}

	void SetCountText () {
		countText.text = "Count: " + count.ToString ();
		if (count >= 9) {
			winText.text = "You win!";
		}
	}

	void OnTriggerEnter(Collider a) {
		if (a.gameObject.CompareTag ("Pickup")) {
			a.gameObject.SetActive (false);	
			count += 1;
			SetCountText();
		}
	}
}
