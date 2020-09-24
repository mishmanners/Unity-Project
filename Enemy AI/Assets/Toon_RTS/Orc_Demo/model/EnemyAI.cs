using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    
    public enum EnemyState
    {
        Alive,
        Dead,
        Attacking,
        Idle,
        Patroling,
        Chasing,
        Stunned,
        Burned,
        Frozen,
        Poisoned,
        Shocked,
        Agroed

    }

    public EnemyState currentState;
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.Patroling;
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patroling:
                Debug.Log("Enemies are patrolling this area. Be careful");
                if (Time.time > 10)
                {
                    currentState = EnemyState.Chasing;
                }
                break;
            case EnemyState.Alive:
                Debug.Log("There's enemies nearby, get em!");
                break;
            case EnemyState.Dead:
                Debug.Log("Enemy killed");
                break;
            case EnemyState.Attacking:
                Debug.Log("You're being attacked");
                break;
            case EnemyState.Idle:
                Debug.Log("Enemy is close, be sneaky");
                break;
            case EnemyState.Chasing:
                Debug.Log("You weren't sneaky... you're now being chased!");
                break;
            case EnemyState.Burned:
                Debug.Log("Fire damage");
                break;
            case EnemyState.Stunned:
                Debug.Log("Stunned");
                break;
            case EnemyState.Frozen:
                Debug.Log("Frozen");
                break;
            case EnemyState.Poisoned:
                Debug.Log("Poisoned");
                break;
            case EnemyState.Shocked:
                Debug.Log("Shocked");
                break;
            case EnemyState.Agroed:
                Debug.Log("You agroed everything! Better get your AOE on");
                break;
        
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentState = EnemyState.Attacking;
        }
        
    }
}
