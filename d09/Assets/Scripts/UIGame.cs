using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIGame : MonoBehaviour {

	// Life
	public	Text 		textLife;
	public	Scrollbar 	scrollbarLife;

	// Time
	public	Text 		textTime;
	private	float 		timeWave;
	private	float 		timeBetweenWave;
	private	float 		time;

	// Message
	public	Text		textMessage;

	// Other
	private	bool		isWave;

	void Start () {
		isWave = true;
		timeWave = GameManager.gm.timeWave;
		timeBetweenWave = GameManager.gm.timeBetweenWave;
		time = (isWave) ? timeWave : timeBetweenWave;
		setMessage ();
	}

	void Update () {

		int life = GameManager.gm.player.getLife();
		textLife.text = life.ToString();
		scrollbarLife.size =  life / 10;

		if (time <= 0) {
			isWave = !isWave;
			setMessage();
			time = (isWave) ? timeWave : timeBetweenWave;
		}

		time -= Time.deltaTime;
		textTime.text = "Time: " + ((int)time).ToString () + "s";
	}

	void setMessage () {
		if (isWave) {
			textMessage.color = Color.yellow;
			textMessage.text = "A NEW WAVE IS STARTING!";
		} else {
			textMessage.color = Color.yellow;
			textMessage.text = "COOLDOWN TIME";
		}
		StartCoroutine (playFadeAway ());
	}

	IEnumerator playFadeAway () {
		float i = 0f;
		float inc = 0.001f;

		Color current = textMessage.color;

		while (i < 255f) {
			current.a = i / 255f;
			textMessage.color = current;
			i += 3f;
			yield return new WaitForSeconds(inc);
		}
		yield return new WaitForSeconds(2.0f);
		while (i >= 0f) {
			current.a = i / 255f;
			textMessage.color = current;
			i -= 3f;
			yield return new WaitForSeconds(inc);
		}
	}
}
