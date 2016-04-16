using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager			gm;

	[HideInInspector]public Player		player;
	[HideInInspector]public bool		end = false;
	[HideInInspector]public bool		pause = false;
	public float						timeWave = 25f;
	public float						timeBetweenWave = 10f;

	void Awake () {
		gm = this;
		this.player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player>();
	}

	void GameOver() {
		Debug.Log ("GameOver");
		this.end = true;
	}

	void GameWin() {
		Debug.Log ("GameWin");
		this.end = true;
	}
}
