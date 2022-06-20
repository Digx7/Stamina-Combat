using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewStaticGameEvent", menuName = "ScriptableObjects/GameEvent/StaticEvent", order = 1)]
public class Static_GameEvent : GameEvent
{
  public override int GetValue(){
    return 0;
  }
}
