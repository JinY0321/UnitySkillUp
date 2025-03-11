using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // ���� ���� ����

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // ���� Y �ӵ� �ʱ�ȭ
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

