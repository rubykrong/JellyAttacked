using UnityEngine;
using System.Collections;

namespace EnemyBag {

public  class EnemyBag{
	
		static  int CountEnemy = 0;

		 static public void Add()
		{
			CountEnemy++;
		}
		static public void Del()
		{
			CountEnemy--;
		}

		static public void DelAll()
		{
			Debug.Log (CountEnemy );
			CountEnemy = 0;
			Debug.Log (CountEnemy );
		}
		static public int Show()
		{
			
			return CountEnemy; 
		}

		static public bool Empty()
		{
			
			if (CountEnemy == 0)
				return true;
			else
				return false;
		}
}

}