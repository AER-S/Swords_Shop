using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Sword Data", fileName = "NewSwordData", order = 51)]
public class SwordData : ScriptableObject
{
    [SerializeField] private string swordName;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private int goldCost;
    [SerializeField] private int attackDamage;
    
    public string SwordName => swordName;
    public string Description => description;
    public Sprite Icon => icon;
    public int GoldCost => goldCost;
    public int AttackDamage => attackDamage;
}
