using UnityEngine;

namespace Utility
{
    public static class VectorUtility
    {
        /// <summary>
        /// Returns a normalized unit Vector3 in the direction of endPoint to startPoint.
        /// </summary>
        public static Vector3 GetDirectionVector( Vector3 startPoint, Vector3 endPoint )
        {
            return ( endPoint - startPoint ).normalized;

        }

        /// <summary>
        /// Returns the difference in angle of endPoint to startPoint; from 0 - 360 degrees in rotation.
        /// </summary>
        public static float GetTargetAngleFromPosition( Vector3 startPoint, Vector3 endPoint )
        {
            Vector3 targetDirection = GetDirectionVector( startPoint, endPoint );

            //Wacky tomfoolery to calculate the angle between the current position and target position.
            return Mathf.Atan2( targetDirection.y, targetDirection.x ) * Mathf.Rad2Deg;

        }

        /// <summary>
        /// Returns the given euler-rotation with the Y axis clamped between the min and max YAngle respectively.
        /// </summary>
        /// <remarks> Useful for quickly clamping a first person camera. </remarks>
        public static Vector3 ClampYAxisEulerRotation( Vector3 currentEulerRotation, float minYAngle = -89.0f, float maxYAngle = 89.0f )
        {
            Vector3 _clampedTargetRotation = currentEulerRotation;

            _clampedTargetRotation.x = Mathf.Clamp( _clampedTargetRotation.x - _clampedTargetRotation.y, minYAngle, maxYAngle );
            _clampedTargetRotation.y += _clampedTargetRotation.x;

            return _clampedTargetRotation;

        }
    }
}

