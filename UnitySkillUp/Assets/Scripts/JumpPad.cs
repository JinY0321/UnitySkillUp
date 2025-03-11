using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프 강도 설정

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z); // 기존 Y 속도 초기화
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

