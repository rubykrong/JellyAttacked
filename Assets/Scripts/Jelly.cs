using UnityEngine;
using System.Collections;
using EnemyBag;

public class Jelly : MonoBehaviour {

	public GameObject[] Bloods = new GameObject[4];
	public Animator anim;
	public Sprite[] spr = {};
	public GameObject bloodSpr;
	public Color clr;
	public float speed = 1.3f;

	void Start () {
		EnemyBag.EnemyBag.Add ();

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, 0f);

	}
	

	void Update () {
	


	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Bullets")
			Wound ();
	}

	void Wound()
	{
		

		anim.SetBool ("Die", true);	

	}

	void Die()
	{
		EnemyBag.EnemyBag.Del ();

		GameObject g1 =  Instantiate (bloodSpr, transform.position, Quaternion.identity) as GameObject;

		g1.GetComponent<SpriteRenderer>().sprite = spr[(int)Random.Range (0, 9)];
		g1.GetComponent<SpriteRenderer> ().color = clr;//new Color (1f, 0f, 0f, 0.6f);

		Destroy (gameObject);
	}
}
