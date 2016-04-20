using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {
	public SpriteRenderer gun; 
	public SpriteRenderer gunUI;
	public Sprite[] weapons = { };

	 
	// Use this for initialization
	void Start () {
		int num = 0;
		for (int i = 0; i < weapons.Length; i++)
			if (weapons [i].name == PlayerPrefs.GetString ("Weapon"))
				num = i;
		
		gun.sprite = weapons [num];
		gunUI.sprite = weapons [num];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
