﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState<T> : States<T>
{
	PlayerController _player;
	Animator _anim;
	
	public PlayerIdleState(PlayerController p, Animator animator)
	{
		_player = p;
		_anim = animator;
		
	}

	public override void Execute()
	{
		
	}

	public override void Sleep()
	{
		Debug.Log("Sleep de Iddle");
	}
}
