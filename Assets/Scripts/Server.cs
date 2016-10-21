using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using UnityEngine.UI;

public class Server : MonoBehaviour {

	public GameObject gameManager;
	public Text consoleText;

	public void OnServerInitialized() {
		Network.Instantiate (gameManager, gameManager.transform.position, gameManager.transform.rotation,1);
		Utility.nvID = gameManager.GetComponent<NetworkView> ().viewID;
		GameManager.consoleString = "";
	}

	// Use this for initialization
	void Start () {
		Network.InitializeServer (20, int.Parse(Utility.getPort ()), false);
	}
	
	// Update is called once per frame
	void Update () {
		string ipaddress = UnityEngine.Network.player.ipAddress;
		consoleText.text = "IPAddress:" + ipaddress + "\nPort:" + Utility.getPort () + "\n" + GameManager.consoleString;
		Debug.Log (gameManager.GetComponent<NetworkView> ().viewID + "/server");
		//Debug.Log ("consoleString:" + gameManager.GetComponent<GameManager> ().consoleString + " /server");
	}
}
