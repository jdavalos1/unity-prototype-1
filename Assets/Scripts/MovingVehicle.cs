using UnityEngine;

public class MovingVehicle : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* Speed * Time.deltaTime);
    }
}
