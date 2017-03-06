using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class nextLevelScript : MonoBehaviour {
	public int current_level;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void NextLevel(){
		current_level = current_level + 1;
		SceneManager.LoadScene ("Level"+current_level);
	
	}
}
