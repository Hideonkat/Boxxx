using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpForce = 5.0f;
    [SerializeField] Transform groundCheck;
    private Rigidbody2D rb;
    private LayerMask groundLayer;
    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
