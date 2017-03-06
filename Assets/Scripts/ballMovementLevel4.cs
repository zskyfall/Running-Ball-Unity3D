using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using CnControls;
public class ballMovementLevel4 : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	private int point;
	public Text countPoints;
	public Text winText;
	public GameObject customJoyStick;

	//Audio RAM1 
	public AudioSource ram;
	public AudioClip ram1;
	public AudioClip ram2;
	public AudioClip ram3;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		countPoints.text = "Score: " + point.ToString ();
	}

	// Update is called once per frame
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;


	void FixedUpdate ()
	{
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(CnInputManager.GetAxis("Horizontal"), 0f, CnInputManager.GetAxis("Vertical"));
		rb.AddForce (movement * speed );
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("pick up 1")){
			other.gameObject.SetActive(false);
			point = point + 1;
			ram.clip = ram1;
			ram.Play ();
			countPoints.text = "Score:" + point.ToString ();

		}

		if(other.gameObject.CompareTag("pick up 2")){
			other.gameObject.SetActive(false);
			point = point + 1;
			ram.clip = ram2;
			ram.Play ();
			countPoints.text = "Score:" + point.ToString ();

		}
		if(other.gameObject.CompareTag("pick up 3")){
			other.gameObject.SetActive(false);
			point = point + 1;
			ram.clip = ram3;
			ram.Play ();
			countPoints.text = "Score:" + point.ToString ();

		}
	}
}

