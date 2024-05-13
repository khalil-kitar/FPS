using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        // Vérifie si l'objet de la collision a le tag "Target"
        if (collision.gameObject.CompareTag("Target"))
        {
            print("Hit"+ collision.gameObject.name +"Target!");
            Destroy(gameObject);  // Détruit l'objet auquel ce script est attaché
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            print("Hit a wall");
            Destroy(gameObject);  // Détruit l'objet auquel ce script est attaché
        }
    }
}
