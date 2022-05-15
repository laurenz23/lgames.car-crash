using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace game_ideas
{
    public class Turret : MonoBehaviour
    {

        [Header("Turret Properties")]
        public float turnSpeed = 5f;
        public Transform partToRotate;

        [Header("Shoot Properties")]
        public float firerate = 1f;
        public float projectileSpeed = 5f;
        public float damage = 10f;
        public float aoe = 0f;
        public GameObject bulletPrefab;
        public Transform targetPointer;
        public List<Transform> firePointer;

        [Header("Script Reference")]
        [SerializeField] private TurretTargetFinder targetFinder;

        private float minRange;
        private float maxRange;

        private float fireCountdown = 0f;

        private void Start()
        {
            minRange = targetFinder.GetMinRange();
            maxRange = targetFinder.GetMaxRange();
        }

        private void Update()
        {

            // return if no current target is lock
            if (targetFinder.GetTarget() == null)
                return;

            // get direction of target
            Vector3 dir = targetFinder.GetTarget().position - transform.position;
            // rotate to target rotation
            Quaternion lookRotation = Quaternion.LookRotation(dir);
            // smooth transition from current rotation to new rotation. And converts quaternion rotation to euler angles, since we just need the y axis
            Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, turnSpeed * Time.deltaTime).eulerAngles;
            // apply rotation
            partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f);

            if (targetFinder.IsTargetLock(targetPointer))
            {
                if (fireCountdown <= 0f)
                {
                    Shoot();
                    fireCountdown = firerate;
                }
            }

            fireCountdown -= Time.deltaTime;

        }

        private void Shoot()
        {
            foreach(Transform t in firePointer)
            {
                GameObject bullet = Instantiate(bulletPrefab, t.position, t.rotation);
                BulletProjectile bulletProjectile = bullet.GetComponent<BulletProjectile>();
                bulletProjectile.speed = projectileSpeed;
                bulletProjectile.damage = damage;
                bulletProjectile.aoeRadius = aoe;
                bulletProjectile.targetTag = targetFinder.GetTargetTag();
                bulletProjectile.target = targetFinder.GetTarget();
            }
        }

    }
}
