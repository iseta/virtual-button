using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class scriptTeste : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject btRed, btBlue, btYellow, btBlack, cube;
	// Declaring our buttons, and our cube. This way, they should be associated in the main scene, but it could also be done by GameObject.Find()
	void Start () {
		//Registers the event handler for each virtual button.
		btRed.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		btBlue.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		btYellow.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		btBlack.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}
	
	public void OnButtonPressed(VirtualButtonBehaviour vb){
		//Does whatever it should do when a certain button is pressed. 
		if(vb.Equals(btRed.GetComponent<VirtualButtonBehaviour>())){
			//With red, it turns the cube red, the same goes for blue, yellow and black.
			cube.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		}
		if(vb.Equals(btBlue.GetComponent<VirtualButtonBehaviour>())){
			cube.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
		}
		if(vb.Equals(btYellow.GetComponent<VirtualButtonBehaviour>())){
			cube.GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
		}
		if(vb.Equals(btBlack.GetComponent<VirtualButtonBehaviour>())){
			cube.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
		}		
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){
		//When any button is released, it reverts the cube to it's original color, which is white. 
		cube.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
		cube.transform.Rotate(Vector3.right * 0);

	}

	// Update is called once per frame
	void Update () {
		
	}
}
