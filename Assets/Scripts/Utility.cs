using UnityEngine;
using System.Collections;

public class Utility : MonoBehaviour {

	public static NetworkViewID nvID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public static string getID() {
		if (PlayerPrefs.HasKey ("id")) {
			return PlayerPrefs.GetString ("id");
		}

		string id = "";
		for (int i = 0; i < 8; i++) {
			int index = Random.Range (0, 10 + 26 + 26);
			char c = 'a';
			if (index >= 0 && index < 10) {
				c = (char)(index + 48);
			} else if (index >= 10 && index < 36) {
				c = (char)(index + 55);
			} else {
				c = (char)(index + 61);
			}
			id += c;
		}

		PlayerPrefs.SetString ("id", id);

		return id;
	}

	public static string getIPAddress() {
		if (PlayerPrefs.HasKey ("ip")) {
			return PlayerPrefs.GetString ("ip");
		}
		return "";
	}

	public static void setIPAddress(string ip) {
		PlayerPrefs.SetString ("ip", ip);
	}

	public static string getPort() {
		if (PlayerPrefs.HasKey ("port")) {
			return PlayerPrefs.GetString ("port");
		}
		return "";
	}

	public static void setPort(string port) {
		PlayerPrefs.SetString ("port", port);
	}

	public static string getName() {
		if (PlayerPrefs.HasKey ("name")) {
			return PlayerPrefs.GetString ("name");
		}
		return "";
	}

	public static void setName(string name) {
		PlayerPrefs.SetString ("name", name);
	}
}
