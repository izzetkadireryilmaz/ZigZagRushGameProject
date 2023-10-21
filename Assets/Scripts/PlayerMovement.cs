using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Vector3 direction;
    public float speed;
    public PlaceSpawner SpawnerScript;
    public static bool fall;
    public float AddSpeed;
    public GameObject yourObjectToActivate;

    void Start()
    {
        direction = Vector3.forward;
        fall = false;
        yourObjectToActivate.SetActive(false);
    }


    void Update()
    {
        if (transform.position.y < 0.4f)
        {
            fall = true;
            yourObjectToActivate.SetActive(true);
        }

        if (fall == true)
        {
            return;
        }


        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            speed += AddSpeed + Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Place")
        {
            Score.score++;
            Score.deathScore++;
            collision.gameObject.AddComponent<Rigidbody>();
            SpawnerScript.PlaceSpawn();
            StartCoroutine(PlaceRemove(collision.gameObject));
        }
    }

    IEnumerator PlaceRemove(GameObject RemovedPlace)
    {
        yield return new WaitForSeconds(3f);
        Destroy(RemovedPlace);
    }
}
