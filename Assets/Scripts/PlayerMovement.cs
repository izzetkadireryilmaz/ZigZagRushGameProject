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
    public GameObject DeadCanvas;
    public GameObject GameCanvas;

    void Start()
    {
        direction = Vector3.forward;
        fall = false;
        DeadCanvas.SetActive(false);
        GameCanvas.SetActive(true);
    }


    void Update()
    {
        if (transform.position.y < 0.4f)
        {
            fall = true;
            DeadCanvas.SetActive(true);
            GameCanvas.SetActive(false);
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
