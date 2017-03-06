using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level1Controller : MonoBehaviour {
	public Text winText;
	public Text failText;
	private int point;
	public GameObject MenuCanvas;
	private Rigidbody rb;
	public GameObject nextButton;
	public GameObject floor;
	public GameObject ball;
	public GameObject troll_face;
	public int current_level;

	public int target_point;

	// Use this for initialization
	void Start () {
		
		winText.text = "HÃY THU THẬP 4 ĐIỂM ĐỂ HOÀN THÀNH";
		rb = GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < floor.transform.position.y - 10) {
			winText.text = "Win";
			MenuCanvas.SetActive (true);
			troll_face.SetActive (false);
			failText.text = "Khá lắm!";
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("pick up 1") || other.gameObject.CompareTag("pick up 2") || other.gameObject.CompareTag("pick up 3")){
			other.gameObject.SetActive(false);
			point = point + 1;

		
			if(point >= target_point){
				winText.text = "Thắng bằng niềm tin ấy! Tin người VKL~!";
				failText.text = "FAIL! \n  ( Ngu thì chớt!)";
				MenuCanvas.SetActive (true);
				rb.drag = 10;
				nextButton.SetActive (false);
			}




		}
	}

	public void NextLevel(){
		current_level = current_level + 1;
		SceneManager.LoadScene ("Level"+current_level);
		Debug.Log (current_level);
	}
}
