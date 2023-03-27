using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enemyManager enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void destoryobject()
    {
        Debug.Log("fuck");
        Destroy(gameObject);
        enemy.Boxnum -= 1;
    }
}
