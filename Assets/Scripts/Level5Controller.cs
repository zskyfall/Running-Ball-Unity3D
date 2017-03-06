using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level5Controller : MonoBehaviour {
	public int target_point;

	public GameObject ball;
	public GameObject floor;
	public GameObject MenuCanvas;
	public GameObject NextButton;
	public GameObject troll_face;
	private GameObject dropBox;

	public Text missionTxt;
	public Text winTxt;
	public Text failTxt;
	public int current_level;
	private int point;
	// Use this for initialization
	void Start () {
		missionTxt.text = "HÃY THU THẬP 1 ĐIỂM!";
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < floor.transform.position.y - 69) {
			NextButton.SetActive (false);
			failTxt.text = "Thất Bại! \nNgu Người !";
			MenuCanvas.SetActive (true);
		}


	}
}
