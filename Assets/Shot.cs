using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject bullet;
    public float shotInterval = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shotInterval += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�e�𐶐�����
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
