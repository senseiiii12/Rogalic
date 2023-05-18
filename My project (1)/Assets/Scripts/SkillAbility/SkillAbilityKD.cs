using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SkillAbilityKD : MonoBehaviour
{
    public static SkillAbilityKD skillKD;
    public float cooldownSkill_1;
    public Image imageSkill_1;
    public bool IsCoolDownSkill_1;

    public float cooldownSkill_2;
    public Image imageSkill_2;
    public bool IsCoolDownSkill_2;


    // Start is called before the first frame update
    void Start()
    {
        skillKD = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCoolDownSkill_1 == true)
        {
            imageSkill_1.fillAmount += 1 / cooldownSkill_1 * Time.deltaTime;
                if(imageSkill_1.fillAmount == 1)
                {
                    IsCoolDownSkill_1 = false;
                }
        }

        if(IsCoolDownSkill_2 == true)
        {
            imageSkill_2.fillAmount += 1 / cooldownSkill_2 * Time.deltaTime;
            if (imageSkill_2.fillAmount == 1)
            {
                IsCoolDownSkill_2 = false;
            }
        }
        
    }
}
