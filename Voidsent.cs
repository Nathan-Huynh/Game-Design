using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voidsent : MonoBehaviour
{
    public int HP = 250;
    public Animator animator;
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
        }
        else
            animator.SetTrigger("damage");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
