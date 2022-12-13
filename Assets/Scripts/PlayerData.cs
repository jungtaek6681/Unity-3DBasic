using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
	private Animator anim;

	public float speed
	{
		get { return anim.GetFloat("Speed"); }
		set { anim.SetFloat("Speed", value); }
	}

	private void Awake()
	{
		anim = GetComponentInChildren<Animator>();
	}
}
