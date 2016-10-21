using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour {

	public Text idText;
	public InputField nameField;
	public InputField ipField;
	public InputField portField;

	// Use this for initialization
	void Start () {
		idText.text = "ID:" + Utility.getID ();
		ipField.text = Utility.getIPAddress ();
		portField.text = Utility.getPort ();
		nameField.text = Utility.getName ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toOpeningScene() {
		Utility.setIPAddress (ipField.text);
		Utility.setName (nameField.text);
		Utility.setPort (portField.text);
		SceneManager.LoadScene ("opening");
	}
}
