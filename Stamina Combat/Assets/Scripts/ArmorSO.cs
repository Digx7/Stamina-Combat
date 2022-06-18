using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewArmor", menuName = "ScriptableObjects/Armor", order = 1)]
public class ArmorSO : ScriptableObject
{
    public int physicalNegation;
    public int magicNegation;
}
