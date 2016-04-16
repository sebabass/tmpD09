using UnityEngine;
using System.Collections;

public class Player : Character {

	public Weapon	sniper;
	public Weapon	rocket;

	protected Weapon	_currentWeapon;


	
	protected override void Attack() {
		if (!this._isDead) {
			Debug.Log ("Player attack()");
			this._currentWeapon.Shoot ();
		}
	}

	protected override void Die() {
		if (!this._isDead) {
			Debug.Log ("Player die()");
			this._isDead = true;
		}
	}
}
