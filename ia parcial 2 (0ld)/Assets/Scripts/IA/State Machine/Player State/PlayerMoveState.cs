using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMoveState<T> : States<T>
{
	PlayerController _player;

	public PlayerMoveState(PlayerController p)
	{
		_player = p;
	}

	public override void Execute()
	{
		_player.correrUpdate();
	}
}
