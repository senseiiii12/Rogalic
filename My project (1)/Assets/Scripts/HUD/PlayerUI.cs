using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public static PlayerUI plUI; 
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
    public GameObject CountInSliderMS;
    public GameObject CountInSliderD;
    public GameObject CountInSliderMH;

    public GameObject plus_AS;
    public GameObject plus_MS;
    public GameObject plus_D;
    public GameObject plus_MH;

    public GameObject HP_text;
    public GameObject Mana_text;


    // Start is called before the first frame update
    void Start()
    {
        plUI = this;
        
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

        CountInSliderAS.GetComponent<Text>().text = LevelSkills.lvlskill.countSliderAS.ToString();
        CountInSliderMS.GetComponent<Text>().text = LevelSkills.lvlskill.countSliderMS.ToString();
        CountInSliderD.GetComponent<Text>().text = LevelSkills.lvlskill.countSliderD.ToString();
        CountInSliderMH.GetComponent<Text>().text = LevelSkills.lvlskill.countSliderMH.ToString();

        plus_AS.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillAS.ToString();
        plus_MS.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillMS.ToString();
        plus_D.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillD.ToString();
        plus_MH.GetComponent<Text>().text = "+" + LevelSkills.lvlskill.plus_skillMH.ToString();

        HP_text.GetComponent<Text>().text = PlayerStats.plStats.health.ToString();
        Mana_text.GetComponent<Text>().text = PlayerStats.plStats.mana.ToString();





    }
}
