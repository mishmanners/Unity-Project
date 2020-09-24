using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public Spell[] spells = new Spell[5];
    // fire, ice, lightning, wind, heart
    public GameObject[] magics;

    /* public Spell fireBlast;
    public Spell iceBlast;
    public Spell thunderBlast;
    */

    public int level = 1;
    public int exp;

    public int SpellElement { get; private set; }

    // public GameObject Fire;
    // public GameObject Ice;
    // public GameObject Lightning;

    // Start is called before the first frame update
    void Start()
    {
        spells[0] = new Spell("Fire Blast", 1, 27, 35);
        spells[1] = new Spell("Ice Blast", 2, 12, 45);
        spells[2] = new Spell("Thunder Blast", 2, 13, 50);
        spells[3] = new Spell("Heart Blast", 3, 19, 60);
        spells[4] = new Spell("Wind Blast", 3, 22, 90);

    }

    // Update is called once per frame
    void Update()
    {
        CastSpell(KeyCode.Y, 0);
        CastSpell(KeyCode.U, 1);
        CastSpell(KeyCode.I, 2);
        CastSpell(KeyCode.O, 3);
        CastSpell(KeyCode.P, 4);

        /*
        if (Input.GetKeyDown(KeyCode.U))
        {

            spells[].Cast();
            exp += spells[0].expGained;
            Instantiate(magics[0], transform.position, Quaternion.identity);

            if (fireBlast.levelRequired == level)
            {
                fireBlast.Cast();
            }
            
    
        
        if (Input.GetKeyDown(KeyCode.P))
        {
            spells[2].Cast();
            exp += spells[2].expGained;
            Instantiate(magics[2], transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            spells[3].Cast();
            exp += spells[3].expGained;
            Instantiate(magics[3], transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            spells[4].Cast();
            exp += spells[4].expGained;
            Instantiate(magics[4], transform.position, Quaternion.identity);
        }
        */

        foreach (var Amazon in spells)
        {
            if (Amazon.levelRequired == level)
            {
                spells[SpellElement].Cast();
            }
        }
    }


    private void CastSpell(KeyCode KeyPress, int SpellElement)
    {
        if (Input.GetKeyDown(KeyPress))
        {
            spells[SpellElement].Cast();
            exp += spells[SpellElement].expGained;
            Instantiate(magics[SpellElement], transform.position, Quaternion.identity);

        }
    }
}
