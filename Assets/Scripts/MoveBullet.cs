using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {

	public Vector2  speedMove;
	public float speed, cof, angl, x = 100f, y = 100f, tg;
	public int minDmg, maxDmg;
	public Animator anim;


	void Start () {



	}


	void Update () {

		if (transform.position.x < x)
			GetComponent<Transform> ().position = Vector2.MoveTowards (GetComponent<Transform> ().position, new Vector2(x, y), speed);// speed *Time.deltaTime);
		else
		if (transform.position.x >= x )
			FinishMoveBullet ();
		
		
			
			

	}

	public void FinishMoveBullet()
	{
		
		anim.SetBool ("Expl", true);

			
	}
	public void _Die()
	{
		Destroy (gameObject);
	}
}
