using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeXP : MonoBehaviour
{
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
        int randomXP = Random.Range(80, 90);
        if(collision.name == "Player")
        {
            if(randomXP >= (PlayerStats.plStats.sliderXP.maxValue - PlayerStats.plStats.sliderXP.value))
            {
                PlayerStats.plStats.XpHero = 0;
                PlayerStats.plStats.sliderXP.maxValue += 50;
                PlayerStats.plStats.LevelHero += 1;
                PlayerStats.plStats.skillPoint += 1;
                
            }
            else
            {
                PlayerStats.plStats.XpHero += randomXP;      
            }
            Destroy(gameObject);
        }
    }
}
