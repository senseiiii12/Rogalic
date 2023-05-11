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

        }
        
    }
    public void CreateAgent()
    {
        
        int random;
        for(int i = 0; i < 5; i++)
        {
            random = Random.Range(1, 4);
            Vector3 point = (Random.insideUnitSphere * spawnradius) + transform.position;
            

            switch (random)
            {
                case 1: 
                    Instantiate(agent_coin, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
                    break;
                case 2:
                    Instantiate(agent_heal, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
                    break;
                case 3:
                    Instantiate(agent_mana, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
                    break;
            }
        }
    }
}
