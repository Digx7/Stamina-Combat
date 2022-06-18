using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Turns{PlayersTurn, EnemyCounter, EnemysTurn, PlayerCounter}

[CreateAssetMenu(fileName = "NewGameEnumSO", menuName = "ScriptableObjects/Enum", order = 1)]
public class GameEnumSO : ScriptableObject
{
    public Turns currentTurn;

    public GameEvent newTurn;

    public void IncrementTurn(){
      if(currentTurn == Turns.PlayerCounter) currentTurn = Turns.PlayersTurn;
      else currentTurn++;

      newTurn.Raise();
    }
}
