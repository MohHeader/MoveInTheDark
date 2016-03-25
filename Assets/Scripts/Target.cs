using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
	void OnMouseDown(){
		GameMaster.Instance.SetStartPoint (this);
	}

	void OnMouseUp(){
		GameMaster.Instance.SetStartPoint (null);
	}

	void OnMouseEnter(){
		GameMaster.Instance.CheckEndPoint (this);
	}
}
