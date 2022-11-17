using System;
using Characters.AI;
using Characters.HealthBar;
using UnityEngine;

namespace Characters
{
    public sealed class OpponentController : MonoBehaviour
    {
        [SerializeField] private CharacterController characterController;
        [SerializeField] private int maxHp;
        [SerializeField] private int currentHp;
        [SerializeField] private HealthBarController healthBar;
        
        private float _gravity;
        
        public PathBuilder PathBuilder { get; set; }

        private void Start()
        {
            _gravity = -9.81f * Time.deltaTime;
            healthBar.SetMaxHealth(maxHp);
        }
    
        private void Update()
        {
            characterController.Move(new Vector3(0f, _gravity, 0f));

            if (Input.GetKeyDown(KeyCode.Space))
            {
                TakeDamage(5);
            }
        }
    
        private void TakeDamage(int damage)
        {
            currentHp -= damage;
            healthBar.SetHealth(currentHp);
        }

        public void Test()
        {
            Debug.Log("HEYOO");
        }
    }
}
