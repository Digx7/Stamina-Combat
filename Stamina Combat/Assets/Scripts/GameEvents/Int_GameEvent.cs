using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewIntGameEvent", menuName = "ScriptableObjects/GameEvent/IntEvent", order = 1)]
public class Int_GameEvent : GameEvent
{
  public int value;

  public void SetValue(int input){
    value = input;
    Raise();
  }

  public void UpdateValue(int input){
    value += input;
    Raise();
  }

  public override int GetValue(){
    return value;
  }
}
