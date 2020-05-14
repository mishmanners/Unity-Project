using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text activeEnemiesText;

    public void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Enemy Cats: " + SpawnManager.enemyCount;
        
    }

}
