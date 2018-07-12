using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class click : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject VButtonObject;
	private GameObject zombie;
	// Use this for initialization
	void Start () {
		VButtonObject = GameObject.Find("VirtualButton");
		zombie = GameObject.Find("zombie");
		VButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log("DOWN");
		zombie.GetComponent<Animation>().Play();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb){
		zombie.GetComponent<Animation>().Stop();
	}
}
