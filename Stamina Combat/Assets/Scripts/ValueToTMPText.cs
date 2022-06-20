using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValueToTMPText : MonoBehaviour
{
    public TextMeshProUGUI TMP_Object;

    public void UpdateText(int input){
      TMP_Object.text = "" + input;
    }

    public void UpdateText(string input){
      TMP_Object.text = input;
    }

    public string GetText(){
      return TMP_Object.text;
    }
}
