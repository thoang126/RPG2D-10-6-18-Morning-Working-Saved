//////////////////////
// Simple Teleport  //
//    Tiles By:     //
//    RCTesting     //
//      A.K.A.      //
//   (KD, DirtyD)   //
//////////////////////

//////
//TeleportTiles - version 1.2
//////

using UnityEngine;
using Mirror;
using UnityEngine.AI;
using System;
using System.Linq;
using System.Collections.Generic;


public partial class Player : Entity
{
	public TeleportTile tp;
	
	public void OnTriggerEnter2D(Collider2D other){
		try{
			if (other.GetComponent<TeleportTile>() != null)
			{
				tp = other.GetComponent<TeleportTile>();
				agent.Warp(tp.Teleport.position);
				Debug.Log("The teleport from [" + other.name + "] to [" + tp.Teleport.name + "] was successfull!!");
			}
		}catch{
			Debug.Log("Something went terribly wrong!! " + other.name + " is [" + tp.Teleport.name + "] <- if this says it is null, you need to set the teleport in inspector!");
		}
		
	}
	
	public void OnTriggerEnter(Collider other){
		try{
			if (other.GetComponent<TeleportTile>() != null)
			{
				tp = other.GetComponent<TeleportTile>();
				agent.Warp(tp.Teleport.position);
				Debug.Log("The teleport from [" + other.name + "] to [" + tp.Teleport.name + "] was successfull!!");
			}
		}catch{
			Debug.Log("Something went terribly wrong!! " + other.name + " is [" + tp.Teleport.name + "] <- if this says it is null, you need to set the teleport in inspector!");
		}
		
	}
}
