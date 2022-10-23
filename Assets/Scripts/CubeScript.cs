using UnityEngine;

public class CubeScript : MonoBehaviour, IPooledObject
{
    public float upForce = 1f, sideForce = 0.1f;
    float xForce, yForce, zForce;
    Vector3 force;
    public void OnObjectSpawn()
    {
        xForce = Random.Range(-sideForce, sideForce);
        yForce = Random.Range(upForce / 2f, upForce);
        zForce = Random.Range(-sideForce, sideForce);
        force = new Vector3(xForce, yForce, zForce);
        GetComponent<Rigidbody>().velocity = force;
    }
}
