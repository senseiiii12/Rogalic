using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSkills : MonoBehaviour
{
    public GameObject levelSkillPanel;
    public Slider sliderAS;
    
    void Start()
    {
        sliderAS.minValue = PlayerStats.plStats.force;
    }

   
    void Update()
    {
        sliderAS.value = PlayerStats.plStats.force;
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
        PlayerStats.plStats.force += 1; 
    }
}
