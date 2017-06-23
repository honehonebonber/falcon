using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BattleUIManager : MonoBehaviour {

	public static BattleUIManager instance;
	public static int number;
	public CommandButtonController cmdLeft, cmdRight;

	public List<Const.Commnad> stackCommands = new List<Const.Commnad>();

	// Use this for initialization
	void Start () {
		instance = this;

	}
	
	// Update is called once per frame
	public void PushButton (Const.Commnad cmd) {
		print (cmd);
		stackCommands.Add (cmd);
	}

	public void InvokeCommand () {
		
		stackCommands.RemoveAt (0);
	}
}
