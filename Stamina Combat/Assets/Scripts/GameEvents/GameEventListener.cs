using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class GameEventListener : MonoBehaviour
{
public GameEvent Event;


private void OnEnable()
{ if(IsEventNull()) Debug.LogWarning("Event is null on " + gameObject);
  else Event.RegisterListener(this); }

private void OnDisable()
{ if(IsEventNull()) Debug.LogWarning("Event is null on " + gameObject);
  else Event.UnregisterListener(this); }

private bool IsEventNull(){
  if(Event == null) return true;
  else return false;
}

public abstract void OnEventRaised();
}
