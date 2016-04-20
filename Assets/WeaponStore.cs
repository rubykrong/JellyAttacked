using UnityEngine;
using System.Collections;

public class WeaponStore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChooseWeapon(string _nameWeapon)
	{
		PlayerPrefs.SetString("Weapon", _nameWeapon);
		LoadScene (0);

	}

	public void LoadScene(int i)
	{
		Application.LoadLevel (i);

	}
}
