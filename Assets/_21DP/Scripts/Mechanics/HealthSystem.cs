using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private float hp;

    [SerializeField]
    private Image healthBar;

    private void OnTriggerEnter(Collider other)
    {
        HealthObject healthObject = other.gameObject.GetComponent<HealthObject>();

        if (healthObject != null)
        {
            ManageHealth(healthObject.healthModifier);
            if (healthObject.myType == HealthObject.Type.HealthPack)
                Destroy(healthObject.gameObject);

        }
    }

    void ManageHealth(float modifier)
    {
        hp += modifier;

        float fillAmount = hp * 0.01f;
        healthBar.fillAmount = fillAmount;
    } 

    void Update()
    {
        if (hp <= 0)
        {
            Debug.Log("I am dead!");
        }
    }
}
