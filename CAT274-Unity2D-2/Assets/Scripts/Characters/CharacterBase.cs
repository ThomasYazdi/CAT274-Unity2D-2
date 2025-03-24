using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterBase : MonoBehaviour
{
    public string characterName;
    public int health;
    public TextMeshProUGUI displayHealth;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DisplayHealth();
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void DisplayHealth()
    {
        displayHealth.text = "Health: " + health;
    }
}
