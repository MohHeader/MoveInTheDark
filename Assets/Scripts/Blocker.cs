using UnityEngine;
using System.Collections;

public class Blocker : MonoBehaviour {

	void OnMouseEnter(){
		GameMaster.Instance.OnTouchBlocker ();
	}
}
