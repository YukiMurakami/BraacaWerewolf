using UnityEngine;
using System.Collections;

public class Client : MonoBehaviour {

	public GameObject gameManager;

	// Use this for initialization
	void Start () {
		Network.Connect (Utility.getIPAddress(), int.Parse (Utility.getPort()));
	}

	public void sendMessage() {
		//GameManager.addMessageRPC ("Name:" + Utility.getName () + " ID:" + Utility.getID ());
		// .addMessage ("Name:" + Utility.getName () + " ID:" + Utility.getID ());
		string mes = "Name:" + Utility.getName () + " ID:" + Utility.getID ();
		//gameManager.GetComponent<GameManager> ().addMessageRPC (mes);
		gameManager.GetComponent<NetworkView> ().viewID = Utility.nvID;
		Debug.Log (gameManager.GetComponent<NetworkView> ().viewID + "/client");

		gameManager.GetComponent<NetworkView> ().RPC ("addMessage", RPCMode.All, mes);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
