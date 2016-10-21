using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneTransition : MonoBehaviour {

	public Button serverButton;
	public Button clientButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toServer() {
		SceneManager.LoadScene ("server");
	}

	public void toClient() {
		SceneManager.LoadScene ("client");
	}
}
