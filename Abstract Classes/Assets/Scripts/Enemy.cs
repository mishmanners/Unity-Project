using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    public int speed;
    public int health;
    public int gems;

    public abstract void Attack();
    public virtual void Die()
    {
        Destroy(this.gameObject);
    }
    

}

public class CrimsonTwilight : Enemy
{
    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void Die()
    {
        //custom particles
        base.Die();
    }

}