using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static string consoleString;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (GetComponent<NetworkView> ().viewID + "/gameManager");
		GetComponent<NetworkView> ().viewID = Utility.nvID;
	}

	[RPC]
	public void addMessage(string mes) {
		consoleString += mes + "\n";
		Debug.Log ("sended" + Time.frameCount + " mes:" + mes);
		Debug.Log (consoleString);
	}
}
