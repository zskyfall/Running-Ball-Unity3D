using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class replay : MonoBehaviour {
	public int current_lv;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void rep(){
		SceneManager.LoadScene("Level"+current_lv);
	}
}
