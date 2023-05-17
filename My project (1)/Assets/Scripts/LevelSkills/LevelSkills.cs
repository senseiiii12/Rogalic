using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSkills : MonoBehaviour
{
    public static LevelSkills lvlskill;
    public GameObject levelSkillPanel;
    public Slider sliderAS;
    public Slider sliderMS;
    public Slider sliderD;
    public Slider sliderMH;
    public int countSliderAS;
    public int countSliderMS;
    public int countSliderD;
    public int countSliderMH;

    public int plus_skillAS;
    public int plus_skillMS;
    public int plus_skillD;
    public int plus_skillMH;
    

    
    void Start()
    {
        lvlskill = this;
    }

   
    void Update()
    {      
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!levelSkillPanel.activeSelf)
            {
                levelSkillPanel.SetActive(true);             
            }
            else
            {
                levelSkillPanel.SetActive(false);  
            }
        }
        sliderAS.value = countSliderAS;
        sliderMS.value = countSliderMS;
        sliderD.value = countSliderD;
        sliderMH.value = countSliderMH;
    }
    private void FixedUpdate()
    {
        
    }

    public void UpSkillAS()
    {
        if (PlayerStats.plStats.skillPoint > 0)
        {
            if (countSliderAS >= 10)
            {
                countSliderAS += 0;
            }
            else
            {
                PlayerUI.plUI.plus_AS.SetActive(true);
                countSliderAS++;
                plus_skillAS++;
                PlayerStats.plStats.force += 1;
                PlayerStats.plStats.skillPoint--;
            }
        }           
    }
    public void UpSkillMS()
    {      
        if (PlayerStats.plStats.skillPoint > 0)
        {
            if (countSliderMS >= 10)
            {
                countSliderMS += 0;
            }
            else
            {
                PlayerUI.plUI.plus_MS.SetActive(true);
                countSliderMS++;
                plus_skillMS++;
                PlayerStats.plStats.speed += 1;
                PlayerStats.plStats.skillPoint--;
            }
        }
    }

    public void UpSkillD()
    {    
        if (PlayerStats.plStats.skillPoint > 0)
        {
            if (countSliderD >= 10)
            {
                countSliderD += 0;
            }
            else
            {
                PlayerUI.plUI.plus_D.SetActive(true);
                countSliderD++;
                plus_skillD += 10;
                PlayerStats.plStats.maxDamage += 10;
                PlayerStats.plStats.minDamage += 10;
                PlayerStats.plStats.skillPoint--;
            }
        }
    }

    public void UpSkillMH()
    {   
        if (PlayerStats.plStats.skillPoint > 0)
        {
            if (countSliderMH >= 10)
            {
                countSliderMH += 0;
            }
            else
            {
                PlayerUI.plUI.plus_MH.SetActive(true);
                countSliderMH++;
                plus_skillMH += 25;
                PlayerStats.plStats.maxHealth += 25;
                PlayerStats.plStats.hBarPlayerSlider.maxValue += 25; 
                PlayerStats.plStats.skillPoint--;
            }
        }
    }
}
