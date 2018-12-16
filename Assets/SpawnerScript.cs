using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

    // Rigidbody2D rb;

    int counter = 0;

    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7, prefab8, prefab9, prefab10, prefab11, prefab12, prefab13, prefab14, prefab15, prefab16, prefab17, prefab18, prefab19, prefab20;

    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int whatToSpawn;
	// Use this for initialization
	void Start () {
     //   rb = transform.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
      //  rb.velocity = new Vector2(0, 2);
        if(Time.time > nextSpawn) {
            if(counter < 2) {
                whatToSpawn = Random.Range(1, 6);
                    switch (whatToSpawn){
                        case 1:
                            Instantiate(prefab2, transform.position, Quaternion.identity);
                            counter++;
                            break;
                        case 2:
                            Instantiate(prefab3, transform.position, Quaternion.identity);
                            counter++;    
                            break;
                        case 3:
                            Instantiate(prefab7, transform.position, Quaternion.identity);
                            counter++;
                            break;
                        case 4:
                            Instantiate(prefab13, transform.position, Quaternion.identity);
                            counter++;
                            break;
                        case 5:
                            Instantiate(prefab14, transform.position, Quaternion.identity);
                            counter++;
                            break;

                    }
            }
            else {
                whatToSpawn = Random.Range(1, 21);

                switch (whatToSpawn)
                {
                    case 1:
                        Instantiate(prefab1, transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(prefab2, transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(prefab3, transform.position, Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(prefab4, transform.position, Quaternion.identity);
                        break;
                    case 5:
                        Instantiate(prefab5, transform.position, Quaternion.identity);
                        break;
                    case 6:
                        Instantiate(prefab6, transform.position, Quaternion.identity);
                        break;
                    case 7:
                        Instantiate(prefab7, transform.position, Quaternion.identity);
                        break;
                    case 8:
                        Instantiate(prefab8, transform.position, Quaternion.identity);
                        break;
                    case 9:
                        Instantiate(prefab9, transform.position, Quaternion.identity);
                        break;
                    case 10:
                        Instantiate(prefab10, transform.position, Quaternion.identity);
                        break;
                    case 11:
                        Instantiate(prefab11, transform.position, Quaternion.identity);
                        break;
                    case 12:
                        Instantiate(prefab12, transform.position, Quaternion.identity);
                        break;
                    case 13:
                        Instantiate(prefab13, transform.position, Quaternion.identity);
                        break;
                    case 14:
                        Instantiate(prefab14, transform.position, Quaternion.identity);
                        break;
                    case 15:
                        Instantiate(prefab15, transform.position, Quaternion.identity);
                        break;
                    case 16:
                        Instantiate(prefab16, transform.position, Quaternion.identity);
                        break;
                    case 17:
                        Instantiate(prefab17, transform.position, Quaternion.identity);
                        break;
                    case 18:
                        Instantiate(prefab18, transform.position, Quaternion.identity);
                        break;
                    case 19:
                        Instantiate(prefab19, transform.position, Quaternion.identity);
                        break;
                    case 20:
                        Instantiate(prefab20, transform.position, Quaternion.identity);
                        break;
                }
            }


            nextSpawn = Time.time + spawnRate;

        }
	}
}
