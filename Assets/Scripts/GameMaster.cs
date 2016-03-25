using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameMaster : MonoBehaviour {
	public static GameMaster Instance;

	Target StartPoint;
	public Text GameStateText;

	void Awake () {
		if (Instance == null) {
			Instance = this;
		} else {
			Destroy (gameObject);
		}
	}

	public void SetStartPoint(Target o){
		if (o != null) {
			GameStateText.text = "";
			Camera.main.backgroundColor = Color.black;
		} else {
			Camera.main.backgroundColor = Color.white;
		}
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
		GameStateText.text = "Win";
	}

	void Lose(){
		print ("Lose");
		SetStartPoint (null);
		GameStateText.text = "Lose";
	}
}
