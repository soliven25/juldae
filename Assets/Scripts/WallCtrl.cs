using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision coll)
	{
		if(coll.collider.tag == "BULLET")
		{
			Destroy(coll.gameObject);
		}
	}
}
