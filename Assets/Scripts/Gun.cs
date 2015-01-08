﻿using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
	public string fireButton = "Fire1";
	public float fireDelay = 0.1f;
	public float damage = 1.0f;
	public int initialAmmo = 10;
	public int maxAmmo = 100;

	protected int _currentAmmo;
	protected bool _canFire = true;

	public int currentAmmo
	{
		get
		{
			return _currentAmmo;
		}
	}

	// Use this for initialization
	void Start ()
	{
		_currentAmmo = initialAmmo;
	}

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown(fireButton) && _currentAmmo > 0 && _canFire)
		{
			Fire();
		}
	}

	protected virtual void Fire()
	{
		_currentAmmo--;
		_canFire = false;
		Invoke("CanFireNow", fireDelay);
	}

	void CanFireNow()
	{
		_canFire = true;
	}
}