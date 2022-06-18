using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
  public GameEnumSO Turn;

  public GameObject Attacks;
  public GameObject Counters;

  public TextMeshProUGUI CurrentTurnTMP;

  public void OnNewTurn(){
    if(Turn.currentTurn == Turns.PlayersTurn) PlayersTurnUI();
    else if(Turn.currentTurn == Turns.EnemyCounter) EnemyCounterUI();
    else if(Turn.currentTurn == Turns.EnemysTurn) EnemyTurnUI();
    else if(Turn.currentTurn == Turns.PlayerCounter) PlayerCounterUI();
  }

  private void PlayersTurnUI(){
    Attacks.SetActive(true);
    Counters.SetActive(false);

    CurrentTurnTMP.text = "Players Turn";
  }
  private void EnemyCounterUI(){
    Attacks.SetActive(false);
    Counters.SetActive(false);

    CurrentTurnTMP.text = "Enemy Counter";
  }
  private void EnemyTurnUI(){
    Attacks.SetActive(false);
    Counters.SetActive(false);

    CurrentTurnTMP.text = "Enemy Turn";
  }
  private void PlayerCounterUI(){
    Attacks.SetActive(false);
    Counters.SetActive(true);

    CurrentTurnTMP.text = "Player Counter";
  }
}
