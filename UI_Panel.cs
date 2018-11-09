using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Panel : MonoBehaviour {

	// Use this for initialization
	public SwipeSystem swipeControls;
	public Animator Panel01;

	private void Update()
	{
		if(swipeControls.SwipeDown)
			Panel01.SetBool("open",true);
		if(swipeControls.SwipeUp)
			Panel01.SetBool("open",false);
	}
}
