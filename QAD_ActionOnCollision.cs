using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QAD_ActionOnCollision : MonoBehaviour
{

    public LayerMask m_mask;
    public UnityEvent m_action;

    private void OnCollisionEnter(Collision collision)
    {
        if(Contains(m_mask, collision.gameObject.layer))
        m_action.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Contains(m_mask, other.gameObject.layer))
            m_action.Invoke();

    }
    public static bool Contains( LayerMask mask, int layer)
    {
        return ((mask & (1 << layer)) != 0);
    }
}
