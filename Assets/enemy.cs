using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private int enemyHp;
    // Start is called before the first frame update
    void Start()
    {
        //¶¬‚É‘Ì—Í‚ğw’è‚µ‚Ä‚¨‚­
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHp <= 0)
        {
            //©•ª‚ÅÁ‚¦‚é
            Destroy(this.gameObject);
        }
    }
    public void Damage()
    {
        //enemy‚Ìhp‚ğ1‚Ö‚ç‚·
        enemyHp = enemyHp - 1;
    }
}
