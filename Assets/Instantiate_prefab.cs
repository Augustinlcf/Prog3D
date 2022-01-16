using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_prefab : MonoBehaviour {
    [SerializeField] private GameObject objectToBeSpawned;
    [SerializeField] private int numberOfObjects = 0;
    [SerializeField] private Transform parent;
    [SerializeField] private float radius = 4f;
    [SerializeField] private Vector3 Center = new Vector3(0,0,0);
    
    // Start is called before the first frame update
    void Start() {
        
    }

    void Update()
    {
        // Supprimer les anciens objets
        if (Input.GetKeyDown(KeyCode.D)) {
            foreach (Transform child in parent) Destroy(child.gameObject);
            numberOfObjects = 1;
        }
        
        // Ajouter un objet
        if (Input.GetKeyDown(KeyCode.A)) {
            foreach (Transform child in parent) Destroy(child.gameObject);
            numberOfObjects += 1;
            for (int i = 0; i < numberOfObjects; i++)
            {
                float angle = 2 * Mathf.PI * i / numberOfObjects;
                
                Instantiate(objectToBeSpawned, new Vector3(
                    Center.x + radius * Mathf.Cos(angle), 
                    Center.y + radius * Mathf.Sin(angle), 
                    Center.z), Quaternion.Euler(0,0,30), parent);
            }
        }
        
    }
   
}
