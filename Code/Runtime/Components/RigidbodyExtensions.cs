using UnityEngine;

namespace NiGames.Extensions
{
    public static class RigidbodyExtensions
    {
        #region Checks
        
        /// <summary>
        /// Checks if the object is on the ground.
        /// </summary>
        public static bool IsGrounded(this Rigidbody rb, float maxDistance = 0.1f)
        {
            return Physics.Raycast(rb.position, Vector3.down, maxDistance);
        }
        
        /// <summary>
        /// Checks if a collider collides with another collider.
        /// </summary>
        public static bool IsCollidingWith(this Collider rb, Collider other)
        {
            return rb.bounds.Intersects(other.bounds);
        }
        
        #endregion
        
        /// <summary>
        /// Applies impulse in a random direction.
        /// </summary>
        public static void AddRandomImpulse(this Rigidbody rb, float force)
        {
            var direction = Random.insideUnitSphere;
            
            rb.AddForce(direction * force, ForceMode.Impulse);
        }
        
        /// <summary>
        /// Applies the force of attraction to a point.
        /// </summary>
        public static void ApplyAttractionForce(this Rigidbody rb, Vector3 attractionPoint, float force)
        {
            var direction = (attractionPoint - rb.position).normalized;
            
            rb.AddForce(direction * force);
        }
        
        /// <summary>
        /// Simulates magnetic attraction.
        /// </summary>
        public static void ApplyMagneticAttraction(this Rigidbody rb, Rigidbody other, float magneticStrength)
        {
            var otherPos = other.position;
            var rbPos = rb.position;
            
            var direction = (otherPos - rbPos).normalized;
            var distance = Vector3.Distance(rbPos, otherPos);
            var forceMagnitude = magneticStrength / (distance * distance);
            
            rb.AddForce(direction * forceMagnitude);
        }
        
        /// <summary>
        /// Applies torque to rotate to the target.
        /// </summary>
        /// <param name="rb"></param>
        /// <param name="targetDirection"></param>
        /// <param name="torque"></param>
        public static void RotateTowards(this Rigidbody rb, Vector3 targetDirection, float torque)
        {
            var rotationAxis = Vector3.Cross(rb.transform.forward, targetDirection);
            
            rb.AddTorque(rotationAxis.normalized * torque);
        }
        
        /// <summary>
        /// Bounce off the surface.
        /// </summary>
        public static void Bounce(this Rigidbody rb, Vector3 normal, float bounciness)
        {
            var velocity = rb.velocity;
            
            rb.velocity = Vector3.Reflect(velocity, normal) * bounciness;
        }
    }
}