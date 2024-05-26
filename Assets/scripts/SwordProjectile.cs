using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordProjectile : MonoBehaviour
{
      public float projectileSpeed = 5f;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
            transform.Translate(new Vector3(0f,0f,projectileSpeed * Time.deltaTime));
            Destroy(gameObject, 3f);
    }
     private void OnCollisionEnter(Collision collision)
    {
            Transform debuffObject = transform.Find("Explosion"); // Find the Debuff object by name
        if (debuffObject != null)
        {
        debuffObject.gameObject.SetActive(true); // Enable the Debuff object if found
        }
            Destroy(gameObject,0.1f);
    }
}
