using UnityEngine;
using System.Collections;
using Config;

public class StartConfig : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		if (!PlayerPrefs.HasKey ("Weapon")) {
			PlayerPrefs.SetString ("Weapon", Config.Config.defaultWeapon);
			PlayerPrefs.SetInt ("OpenedLevels", 0);
			PlayerPrefs.SetInt ("Gold", 0);
		}

			

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
