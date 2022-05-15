using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class TurretTargetFinder : MonoBehaviour
    {

        [SerializeField] private float minRange = 1f;
        [SerializeField] private float maxRange = 10f;
        [SerializeField] private string targetTag;

        private Transform targetAtRange;

        private void Start()
        {
            // instead of update target each frame, we are going to update it according to specific time to OPTIMIZE GAME PERFORMANCE
            InvokeRepeating("UpdateTarget", 0f, 0.2f);
        }

        private void UpdateTarget()
        {
            GameObject[] targetsAtRange = GameObject.FindGameObjectsWithTag(targetTag);
            GameObject nearestTarget = null;
            float shortestDistance = Mathf.Infinity;

            foreach (GameObject t in targetsAtRange)
            {
                float distanceToTarget = Vector3.Distance(transform.position, t.transform.position);
                if (distanceToTarget < shortestDistance)
                {
                    shortestDistance = distanceToTarget;
                    nearestTarget = t;
                }
            }

            // set target if enemy is inside the range
            if (nearestTarget != null && shortestDistance >= minRange && shortestDistance <= maxRange)
            {
                targetAtRange = nearestTarget.transform;
            }
            // reset target if there is no enemy inside the range
            else
            {
                targetAtRange = null;
            }

            if (nearestTarget == null)
                return;
        }

        public bool IsTargetLock(Transform firePoint)
        {
            RaycastHit hit;
            if (Physics.Raycast(firePoint.position, firePoint.forward, out hit, maxRange))
            {
                if (hit.transform == targetAtRange)
                {
                    Debug.DrawLine(firePoint.position, hit.transform.position, Color.green);
                    return true;
                }
            }

            return false;
        }

        public Transform GetTarget()
        {
            return targetAtRange;
        }

        public float GetMinRange()
        {
            return minRange;
        }

        public float GetMaxRange()
        {
            return maxRange;
        }

        public string GetTargetTag()
        {
            return targetTag;
        }

        private void OnDrawGizmosSelected()
        {
            // min range
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, minRange);

            // max range
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, maxRange);
        }

    }
}
