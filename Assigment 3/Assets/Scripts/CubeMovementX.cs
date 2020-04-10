using System.Collections;
using UnityEngine;

public class CubeMovementX : MonoBehaviour
{
    public static bool noCollision;

    public GameObject ImpactEffect;

    private void Start()
    {
        noCollision = true;
    }

    void OnMouseDrag()
    {
        if (noCollision)
        {
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            objPosition.y = transform.position.y;
            objPosition.z = transform.position.z;
            transform.position = objPosition;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        SoundEffects.BumpSound = true;

        GameObject effectIns = Instantiate(ImpactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);

        noCollision = false;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        noCollision = true;
    }
}