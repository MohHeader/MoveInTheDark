using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public static GameMaster Instance;

	Target StartPoint;

	void Awake () {
		if (Instance == null) {
			Instance = this;
		} else {
			Destroy (gameObject);
		}
	}

	public void SetStartPoint(Target o){
		StartPoint = o;
	}

	public void CheckEndPoint(Target o){
		if (StartPoint != null && o != StartPoint) {
			Win ();
		}
	}

	public void OnTouchBlocker(){
		if (StartPoint != null)
			Lose ();
	}

	void Win(){
		print ("Win");
		SetStartPoint (null);
	}

	void Lose(){
		
		print ("Lose");
		SetStartPoint (null);
	}
}
