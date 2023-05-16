using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSkills : MonoBehaviour
{
    public static LevelSkills lvlskill;
    public GameObject levelSkillPanel;
    public Slider sliderAS;
    public int countSlider;
    

    
    void Start()
    {
        lvlskill = this;
    }

   
    void Update()
    {
        sliderAS.value = countSlider;
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
    }

    public void UpSkillAS()
    { 
        if (PlayerStats.plStats.skillPoint > 0)
        {
            if (countSlider >= 10)
            {
                countSlider += 0;
            }
            else
            {
                countSlider++;
                PlayerStats.plStats.force += 1;
                PlayerStats.plStats.skillPoint--;
            }
        }           
    }
}
