using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CommandButtonController : MonoBehaviour {

	public Const.Commnad command;
	public GameObject Icon;

	private void Start () {
		var button = GetComponent<Button>();
		button.onClick.AddListener (() => {
			BattleUIManager.instance.PushButton(this.command);
			Instantiate(Icon);
		});

	}

}