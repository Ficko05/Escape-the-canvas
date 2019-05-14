using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {

    Image healthBar;

    float maxHealth = 100f;
    public static float health;

	
	void Start () {
       healthBar = GetComponent<Image>();
       health = maxHealth;
		
	}
	
	
	void Update () {
        healthBar.fillAmount = health / maxHealth;
	}

    //add to oncollision  HealthBarScript.health -= 10f;
}
