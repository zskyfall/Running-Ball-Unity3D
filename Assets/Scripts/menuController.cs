using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menuController : MonoBehaviour {

	public GameObject MenuCanvas;
	public GameObject BtnNewGame;
	public GameObject BtnExit;
	public GameObject BtnYes;
	public GameObject BtnNo;
	public Text TxtTitle;
	public Text TxtNewGameTitle;
	public Text TxtExitTitle;

	public void newGame(){
		SceneManager.LoadScene("Level1");
	}

	public void exit(){
		TxtTitle.text = "Muốn Thoát à?";
		BtnNewGame.SetActive (false);
		BtnExit.SetActive (false);
		BtnNo.SetActive (true);
		BtnYes.SetActive (true);
	}

	public void Yes(){
		TxtTitle.text = "Đùa chút hoy :3\n Thế còn muốn chơi nữa hem?";
		BtnNewGame.SetActive (true);
		BtnExit.SetActive (true);
		BtnNo.SetActive (false);
		BtnYes.SetActive (false);
		TxtNewGameTitle.text = "Không! Thoát Ngay!";
		TxtExitTitle.text = "Dạ có!";
	}

	public void No(){
		Application.Quit ();
	}
}
