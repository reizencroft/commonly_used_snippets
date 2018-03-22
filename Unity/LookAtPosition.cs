using UnityEngine;

public static class LookAtPosition
{
	public static Quaternion LookAtPosition(Vector3 currentPosition, Vector3 targetPosition)
	{
            var positionDelta = targetPosition - currentPosition;
            return Quaternion.LookRotation(positionDelta);
	}
}
