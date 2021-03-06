﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level3Controller : MonoBehaviour {

	public int target_point;

	public GameObject ball;
	public GameObject floor;
	public GameObject MenuCanvas;
	public GameObject NextButton;
	public GameObject troll_face;
	private GameObject dropBox;
	public Collider drop;
	public Text missionTxt;
	public Text winTxt;
	public Text failTxt;
	public int current_level;
	private int point;

	// Use this for initialization
	void Start () {
		missionTxt.text = "HÃY THU THẬP 3 ĐIỂM!";
		dropBox = GameObject.FindGameObjectWithTag ("pick up 2");
	}

	// Update is called once per frame
	void Update () {
		if (ball.transform.position.y < floor.transform.position.y - 10) {
			NextButton.SetActive (false);
			failTxt.text = "Thất Bại! \nNgu Người !";
			MenuCanvas.SetActive (true);
		}

		if(drop.transform.position.y < floor.transform.position.y - 10){
			NextButton.SetActive (false);
			failTxt.text = "Thất Bại! \nNgu Người !";
			MenuCanvas.SetActive (true);
		}
	}


	void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("pick up 1") || other.gameObject.CompareTag("pick up 2")){
			other.gameObject.SetActive(false);
			point = point + 1;


			if(point >= target_point){
				winTxt.text = "Khá lắm Con của ba!!!";
				MenuCanvas.SetActive (true);
				troll_face.SetActive (false);
			}




		}

		if (other.gameObject.CompareTag ("pick up 3")) {
			drop.attachedRigidbody.useGravity = true;
		
		}

	}
}
