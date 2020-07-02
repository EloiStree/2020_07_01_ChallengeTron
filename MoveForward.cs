using UnityEngine;

public class MoveForward : MonoBehaviour
{

    public float m_speed = 5;
    void Update()
    {

        transform.position += transform.forward * Time.deltaTime;
    }


}