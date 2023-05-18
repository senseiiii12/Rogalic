using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSkill_1 : MonoBehaviour
{
    public int damage_skill_1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //int damage = Random.Range(, PlayerStats.plStats.maxDamage);
        ScriptEnemy enemy = collision.GetComponent<ScriptEnemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage_skill_1);
            Destroy(gameObject);
        }

    }
}
