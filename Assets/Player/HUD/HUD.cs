﻿using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	public GUISkin resourceSkin, ordersSkin;
	private const int ORDERS_BAR_WIDTH = 150, RESOURCE_BAR_HEIGHT = 40;
	private Player player;

	// Use this for initialization
	void Start () {
		player = transform.root.GetComponent< Player >();
	}
	
	// OnGUI is called once per frame
	void OnGUI () {
		if(player && player.human) {
			DrawOrdersBar();
			DrawResourcesBar();
		}
	}

	private void DrawOrdersBar() {
		GUI.skin = ordersSkin;
		GUI.BeginGroup(new Rect(0,RESOURCE_BAR_HEIGHT,ORDERS_BAR_WIDTH,Screen.height-RESOURCE_BAR_HEIGHT));
		GUI.Box(new Rect(0,0,ORDERS_BAR_WIDTH,Screen.height-RESOURCE_BAR_HEIGHT),"");
		GUI.EndGroup();
	}

	private void DrawResourcesBar() {
		GUI.skin = resourceSkin;
		GUI.BeginGroup(new Rect(0,0,Screen.width,RESOURCE_BAR_HEIGHT));
		GUI.Box(new Rect(0,0,Screen.width,RESOURCE_BAR_HEIGHT),"");
		GUI.EndGroup();
	}
}
