using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterStats", menuName = "ScriptableObjects/CharacterStats", order = 1)]
public class CharacterStatsSO : ScriptableObject
{
    public int Level;
    public int vitality;
    public int stamina;
    public int strength;
    public int dextarity;
    public int intelligance;
    public int wisdom;
    public int charisma;
}
