using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveSlowState <T> : States<T>
{
	PlayerController _player;

	public PlayerMoveSlowState(PlayerController p)
	{
		_player = p;
	}

	public override void Execute()
	{
		_player.correrUpdate();
	}

	public override void Sleep()
	{
		Debug.Log("Sleep de MoveSlow");
	}

}
