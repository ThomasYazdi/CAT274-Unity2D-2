using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTargeted : Enemy
{
    // Start is called before the first frame update
    public GameObject targetTower;

    void Start()
    {
        targetTower = GameObject.FindWithTag("Tower");
        speed = Random.Range(xSpeed, ySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += VectorToTower() * speed;
        DisplayHealth();
        if (health <= 0)
        {
            manager.money = manager.money + moneyValue;
            Destroy(gameObject);
        }
    }

    Vector3 VectorToTower()
    {
        Vector3 targetDir;
        targetDir = targetTower.transform.position - transform.position;

        targetDir = targetDir.normalized;
        return targetDir;
    }
}
