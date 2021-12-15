using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    [SerializeField] private Text swordName;
    [SerializeField] private Text description;
    [SerializeField] private Image icon;
    [SerializeField] private Text goldCost;
    [SerializeField] private Text attackDamage;

    public void UpdateDisplayUI(SwordData _swordData)
    {
        swordName.text = _swordData.SwordName;
        description.text = _swordData.Description;
        icon.sprite = _swordData.Icon;
        goldCost.text = _swordData.GoldCost.ToString("0000");
        attackDamage.text = _swordData.AttackDamage.ToString("0000");
    }
}
