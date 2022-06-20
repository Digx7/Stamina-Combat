using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Int_GameEventListener : GameEventListener
{
  public IntEvent Response;

  public override void OnEventRaised(){
    if(Event is Int_GameEvent) Response.Invoke(Event.GetValue());
    else Response.Invoke(0);
  }
}
