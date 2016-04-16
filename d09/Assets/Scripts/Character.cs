using UnityEngine;
using System.Collections;

public abstract class Character : MonoBehaviour {
	public int			maxLife;
	public float		moveSpeed;

	protected bool		_isDead;
	protected int		_life;

	void Awake() {
		this._isDead = false;
		this._life = this.maxLife;
	}

	protected abstract void Attack();
	protected abstract void Die();

	public int getLife () {
		return this._life;
	}
}
