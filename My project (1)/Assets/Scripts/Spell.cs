using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spell : MonoBehaviour
{
    
    public GameObject pref;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && PlayerStats.plStats.mana > 0)
        {
            PlayerStats.plStats.mana -= 5;
            GameObject spell = Instantiate(pref, transform.position, Quaternion.identity);
            Vector2 mPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 myPosition = transform.position;
            Vector2 direction = mPosition - myPosition;
            spell.GetComponent<Rigidbody2D>().velocity = direction * PlayerStats.plStats.force;
            Destroy(spell, 2);
        }
        else if(PlayerStats.plStats.mana <= 0)
        {
            PlayerStats.plStats.mana = 0;
            Debug.Log("no mana");
        }

        

    }

    
}
