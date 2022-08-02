using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
public class player: MonoBehaviour
{
 public float timeReset=10;
 FixedUpdate(){
 	GetInput();
 	if(timeReset<=0&&timeReset<10){
 		timeReset+=1;
 	}
 }
 public void GetInput(){
 	if(Input.GetKeyDawn("Shift")&&timeReset>0f){
 		timeReset-=1;
 	}
 }
}