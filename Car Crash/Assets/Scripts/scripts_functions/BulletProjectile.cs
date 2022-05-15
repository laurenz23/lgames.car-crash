using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class BulletProjectile : MonoBehaviour
    {
        public float speed;
        public float damage;
        public float aoeRadius;
        public string targetTag;
        public Transform target;

        private Vector3 dir;
        private float distanceThisFrame;

        public Vector3 lastTargetPosition;

        // Update is called once per frame
        void Update()
        {
            if (target == null)
            {
                dir = lastTargetPosition - transform.position;
                distanceThisFrame = speed * Time.deltaTime;

                if (dir.magnitude <= distanceThisFrame)
                {
                    Destroy(gameObject);
                }

                return;
            }
            else
            {
                dir = target.position - transform.position;
                distanceThisFrame = speed * Time.deltaTime;

                if (dir.magnitude <= distanceThisFrame)
                {
                    HitTarget();
                    return;
                }
            }

            transform.Translate(dir.normalized * distanceThisFrame, Space.World);
            transform.LookAt(target);
            lastTargetPosition = target.position;
        }

        private void HitTarget()
        {
            if (aoeRadius > 0)
            {
                Explode();
            }
            else
            {
                Damage(target);
            }

            Destroy(gameObject);
        }

        private void Explode()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, aoeRadius);

            foreach (Collider collider in colliders)
            {
                if (collider.CompareTag(targetTag))
                {
                    Damage(collider.transform);
                }
            }
        }

        private void Damage(Transform target)
        {
            if (targetTag == "Enemy")
            {
                //Destroy(target);
                Debug.Log("Enemy is Destroyed");
            }
            else if (targetTag == "Player")
            {
                //Destroy(target);
                Debug.Log("Player is Destroyed");
            }
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, aoeRadius);
        }

    }
}
