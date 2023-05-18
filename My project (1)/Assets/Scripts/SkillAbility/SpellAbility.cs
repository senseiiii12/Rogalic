using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellAbility : MonoBehaviour
{
    public GameObject PrefabSkill_1;
    public GameObject PrefabSkill_2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) && SkillAbilityKD.skillKD.IsCoolDownSkill_1 == false)
        {
            SkillAbilityKD.skillKD.imageSkill_1.fillAmount = 0;
            SkillAbilityKD.skillKD.IsCoolDownSkill_1 = true;
            UseSkill(PrefabSkill_1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && SkillAbilityKD.skillKD.IsCoolDownSkill_2 == false)
        {
            SkillAbilityKD.skillKD.imageSkill_2.fillAmount = 0;
            SkillAbilityKD.skillKD.IsCoolDownSkill_2 = true;
            UseSkill(PrefabSkill_2);
        }
    }

    public void UseSkill(GameObject pref)
    {
        /// выпускаем скилл
        GameObject spell = Instantiate(pref, transform.position, Quaternion.identity);
        Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 myPosition = transform.position;
        Vector2 direction = mPosition - myPosition;
        spell.GetComponent<Rigidbody2D>().velocity = direction * 3;
        Destroy(spell, 4);
    }
}
