using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeapon", menuName = "ScriptableObjects/Weapon", order = 1)]
public class WeaponSO : ScriptableObject
{
    public int physicalDamage;
    public int magicDamage;
}
