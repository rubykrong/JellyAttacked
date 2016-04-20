using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class movePlayer : MonoBehaviour {

	public GameObject bullets, gun;
	public float speedShot, maxAmountBull, timeReload, timeDelay = 0f;

	float z, angle, Hypotenuse, currDelay , currAmountBull 
	;


	public Text txt;
	float X, Y;
	void Start () {
		EnemyBag.EnemyBag.DelAll ();
		z = 1f;
		X = 4f;
		Y = 4f;
		currDelay = 0f;

		currAmountBull = maxAmountBull;
	}
	

	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
			Debug.Log (EnemyBag.EnemyBag.Show ());
		if (currAmountBull != 0)
			txt.text = currAmountBull + " / ∞ ";
		else
			txt.text = "Reload";

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

			if (currDelay == 0) {

				Vector2 pos = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);

			
				Hypotenuse = Mathf.Sqrt (pos.x * pos.x + pos.y * pos.y);
				angle = Mathf.Atan2 (Mathf.Abs (Y - pos.y), Mathf.Abs (X - pos.x));
				Hypotenuse += 4f;



				GameObject g1 = Instantiate (bullets, new Vector2 (gun.transform.position.x, gun.transform.position.y), Quaternion.identity) as GameObject;

			
				g1.GetComponent<MoveBullet> ().x = pos.x;
				g1.GetComponent<MoveBullet> ().y = pos.y;
				

				if (pos.y >= Y)
					z = 1f;
				else
					z = -1f;

				g1.GetComponent<MoveBullet> ().cof = z;
				g1.GetComponent<MoveBullet> ().angl = angle;

				g1.GetComponent<Transform> ().Rotate (new Vector3 (0f, 0f, z * (Mathf.Atan2 (Mathf.Abs (Y - pos.y), Mathf.Abs (X - pos.x)) * 57.2958f)));

				gun.transform.eulerAngles = new Vector3 (0f, 0f, angle * 57.2958f * z);
				currDelay = 1f;
				StartCoroutine( DelayShot ());

			}

			}
		}



	IEnumerator DelayShot()
	{
		currAmountBull--;

		if (currAmountBull == 0)
			StartCoroutine (Reload ());
		else {
			yield return new WaitForSeconds (timeDelay);
		
			currDelay = 0f;
		}
	}

	IEnumerator Reload()
	{
		yield return new WaitForSeconds (timeReload);

		currAmountBull = maxAmountBull;

		currDelay = 0f;

	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Enemy")
			Die ();
	}

	void Die()
	{
		

		Application. LoadLevel (0 );


	}
}
