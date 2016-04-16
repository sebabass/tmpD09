using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float		cadence;
	public int			damage;
	public float		range;

	private bool		_availableToShoot = true;

	public void Shoot() {
		if (this._availableToShoot) {
			RaycastHit hit;
			
			StartCoroutine(coShoot());
			if (Physics.Raycast (this.transform.position, this.transform.forward, out hit)) {
				Debug.Log ("Shoot " + hit.collider.name);
			}
		}
	}

	IEnumerator coShoot() {
		this._availableToShoot = false;
		yield return new WaitForSeconds (this.cadence);
		this._availableToShoot = true;
	}
}
