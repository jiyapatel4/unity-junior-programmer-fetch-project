using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    // dog cooldown times
    private float nextFire = 0.0f;
    private float fireRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            // update nextFire every time the space key is pressed
            nextFire += fireRate;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
