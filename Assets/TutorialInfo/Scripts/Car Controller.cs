using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 5.3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
