using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana_bottle : MonoBehaviour
{
    public float mana;
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
        if (collision.name == "Player")
        {
            PlayerStats.plStats.getMana(mana);
            Destroy(gameObject);
        }
    }
}
