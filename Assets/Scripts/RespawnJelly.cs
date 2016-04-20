using UnityEngine;
using System.Collections;
using EnemyBag;

public class RespawnJelly : MonoBehaviour {

	public GameObject JellyGreen, JellyRed;

	bool[] queueSpawn = new bool[4];
	void Start () {
	
		for (int i = 0; i < queueSpawn.Length; i++) {
			queueSpawn [i] = true;
		}

	}


	

	void Update () {

		if (queueSpawn [0]) {
			
			if (EnemyBag.EnemyBag.Empty ()) {
				
				Instantiate (JellyRed, new Vector2 (19f, 2.7f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (21f, 2.7f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (23f, 2.7f), Quaternion.identity);

				queueSpawn [0] = false;
			}
		} else if (queueSpawn [1]) {
			if (EnemyBag.EnemyBag.Empty ()) {
				
				Instantiate (JellyGreen, new Vector2 (19f, 2.7f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (21f, 2.7f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (23f, 2.7f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (20f, 5.2f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (22f, 5.2f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (24f, 5.2f), Quaternion.identity);

				queueSpawn [1] = false;
			}
		} else if (queueSpawn [2]) {
			if (EnemyBag.EnemyBag.Empty ()) {

				Instantiate (JellyGreen, new Vector2 (19f, 2.7f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (21f, 2.7f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (23f, 2.7f), Quaternion.identity);

				Instantiate (JellyGreen, new Vector2 (20f, 5.2f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (22f, 5.2f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (24f, 5.2f), Quaternion.identity);

				Instantiate (JellyGreen, new Vector2 (19f, 6.8f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (22f, 6.8f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (25f, 6.8f), Quaternion.identity);

				Instantiate (JellyGreen, new Vector2 (20f, 8.1f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (21f, 8.1f), Quaternion.identity);
				Instantiate (JellyGreen, new Vector2 (24f, 8.1f), Quaternion.identity);

				queueSpawn [2] = false;
			}
		} else if (queueSpawn [3]) {
			if (EnemyBag.EnemyBag.Empty ()) {

				Instantiate (JellyRed, new Vector2 (19f, 2.7f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (21f, 2.7f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (23f, 2.7f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (20f, 5.2f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (22f, 5.2f), Quaternion.identity);
				Instantiate (JellyRed, new Vector2 (24f, 5.2f), Quaternion.identity);

				queueSpawn [3] = false;
			}
		}
		else if(EnemyBag.EnemyBag.Empty())Application.LoadLevel (0);

	}
}
