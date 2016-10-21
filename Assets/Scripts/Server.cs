using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.Net;
using UnityEngine.UI;

public class Server : MonoBehaviour {

	public GameObject gameManager;
	public Text consoleText;

	public void OnServerInitialized() {
		Network.Instantiate (gameManager, gameManager.transform.position, gameManager.transform.rotation, 1);
	}

	// Use this for initialization
	void Start () {
		Network.InitializeServer (20, int.Parse(Utility.getPort ()), false);
		string ipaddress = UnityEngine.Network.player.ipAddress;
		Debug.Log (ipaddress);
		consoleText.text = "IPAddress:" + ipaddress + "\nPort:" + Utility.getPort ();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
