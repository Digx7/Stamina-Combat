using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public int currentStamina;
    public int maxStamina;

    public int LightAttackDamage;
    public int HeavyAttackDamage;
    public int OffHandAttackDamage;
    public int SpecialAttackDamage;

    public int physicalDamageNegation;
    public int magicDamageNegation;

    public CharacterStatsSO stats;
    public WeaponSO mainWeapon;
    public WeaponSO offHandWeapon;
    public ArmorSO armor;

    public void Awake(){
      Initialization();
    }

    public void Initialization(){

      if(mainWeapon == null){
        mainWeapon = Resources.Load<WeaponSO>("ScriptableObjects/Weapons/NOWEAPON");
      }
      if(offHandWeapon == null){
        offHandWeapon = Resources.Load<WeaponSO>("ScriptableObjects/Weapons/NOWEAPON");
      }
      if(armor == null){
        armor = Resources.Load<ArmorSO>("ScriptableObjects/Armors/NOARMOR");
      }

      maxHealth = stats.vitality;
      currentHealth = maxHealth;

      maxStamina = stats.stamina;
      currentStamina = maxStamina;

      LightAttackDamage = mainWeapon.physicalDamage + mainWeapon.magicDamage + stats.strength + stats.dextarity;
      HeavyAttackDamage = LightAttackDamage * stats.strength * stats.dextarity;
      OffHandAttackDamage = offHandWeapon.physicalDamage + offHandWeapon.magicDamage;
      SpecialAttackDamage = LightAttackDamage + OffHandAttackDamage;

      physicalDamageNegation = armor.physicalNegation + stats.Level;
      magicDamageNegation = armor.magicNegation + stats.Level;
    }

    public void GetHit(int input){
      currentHealth -= input;
    }

    public void LightAttack(){}

    public void HeavyAttack(){}

    public void OffHandAttack(){}

    public void SpecialAttack(){}


}
