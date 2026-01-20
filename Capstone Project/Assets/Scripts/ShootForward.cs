using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootForward : MonoBehaviour
{
    private float attackSpeed = 40;

    void Start()
    {
        //
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * attackSpeed);
        StartCoroutine(Lifespan());
    }

    IEnumerator Lifespan()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
