using System;
using UnityEngine;

namespace Command
{
    public class PlayerMoving: MonoBehaviour
    {
        public float GoPower;
        public float JumpPower;
        
        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = FindObjectOfType<Rigidbody2D>();
        }

        public void GoLeft()
        {
            _rigidbody2D.AddForce(Vector2.left * GoPower);
        }
        
        public void GoRight()
        {
            _rigidbody2D.AddForce(Vector2.right * GoPower);
        }

        public void Jump()
        {
            _rigidbody2D.AddForce(Vector2.up * JumpPower);
        }
    }
}