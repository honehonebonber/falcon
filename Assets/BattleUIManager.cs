using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class BattleUIManager : MonoBehaviour {

	public static BattleUIManager instance;
	public static int number;
	public CommandButtonController cmdLeft, cmdRight;
	public Transform stackCommandPanel;
	public GameObject attackCommandIcon, defenseCommandIcon;
	public List<Const.Commnad> stackCommands = new List<Const.Commnad>();

	// Use this for initialization
	void Start () {
		instance = this;

	}
	
	// Update is called once per frame
	public void PushButton (Const.Commnad cmd) {
		print (cmd);
		stackCommands.Add (cmd);
		switch (cmd) {
		case Const.Commnad.Attack:
			var obj = Instantiate (attackCommandIcon)as GameObject;
			obj.transform.SetParent (stackCommandPanel);
			obj.transform.localScale = Vector3.one;
			obj.transform.eulerAngles = Vector3.zero;
			obj.transform.localPosition = Vector3.zero;
			break;
		case Const.Commnad.Defense:
			
			break;
		}
	}

	public void InvokeCommand () {
		
		stackCommands.RemoveAt (0);
	}
}