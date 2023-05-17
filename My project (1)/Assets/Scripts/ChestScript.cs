using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;
    public float spawnradius;
    public GameObject agent_coin;
    public GameObject agent_heal;
    public GameObject agent_mana;
    public GameObject agent_key;
   
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player" && PlayerStats.plStats.keys > 0 && isOpen == false)
        {
            isOpen = true;
            animator.SetBool("isOpen", true);
            PlayerStats.plStats.keys -= 1;
            CreateAgent();
            Destroy(gameObject, 4);
        }

        
    }
    public void CreateAgent()
    {
        
        int random;
        for(int i = 0; i < 5; i++)
        {
            random = Random.Range(1, 101);
            Vector3 point = (Random.insideUnitSphere * spawnradius) + transform.position;


            if (random > 5)
            {
                Instantiate(agent_coin, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }
            else
            {
                Instantiate(agent_key, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
            }          
            
        }
    }
}
