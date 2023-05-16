using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public GameObject countCoin;
    public GameObject countSouls;
    public GameObject countKeys;

    public GameObject attackSpeed;
    public GameObject moveSpeed;
    public GameObject damage;
    public GameObject maxHealth;
    public GameObject killCount;
    public GameObject CountLevel;
    public GameObject CountSkillPoint;
    public GameObject CountInSliderAS;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        countCoin.GetComponent<Text>().text = PlayerStats.plStats.bitCoins.ToString();
        countSouls.GetComponent<Text>().text = PlayerStats.plStats.souls.ToString();
        countKeys.GetComponent<Text>().text = PlayerStats.plStats.keys.ToString();


        attackSpeed.GetComponent<Text>().text = PlayerStats.plStats.force.ToString();
        moveSpeed.GetComponent<Text>().text = PlayerStats.plStats.speed.ToString();
        damage.GetComponent<Text>().text = PlayerStats.plStats.maxDamage.ToString();
        maxHealth.GetComponent<Text>().text = PlayerStats.plStats.maxHealth.ToString();
        
        killCount.GetComponent<Text>().text = PlayerStats.plStats.killCount.ToString();
        CountLevel.GetComponent<Text>().text = PlayerStats.plStats.LevelHero.ToString();
        CountSkillPoint.GetComponent<Text>().text = PlayerStats.plStats.skillPoint.ToString();
        CountInSliderAS.GetComponent<Text>().text = LevelSkills.lvlskill.countSlider.ToString();

    }
}
