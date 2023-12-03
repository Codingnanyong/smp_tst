using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public float scaleFactor = 0.5f;        // The rate of change of the scale

    private Transform Table_Transform = null;
    public float minScale = 0.6f;
    public float maxScale = 2.0f;

    void Update()
    {
        // If there are two touches on the device...
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Change the scale based on the change in distance between the touches.
            Table_Transform.localScale += new Vector3(deltaMagnitudeDiff * scaleFactor, deltaMagnitudeDiff * scaleFactor, deltaMagnitudeDiff * scaleFactor);

            float Table_X, Table_Y, Table_Z;

            Table_X = Mathf.Clamp(Table_Transform.localScale.x, minScale, maxScale);
            Table_Y = Mathf.Clamp(Table_Transform.localScale.y, minScale, maxScale);
            Table_Z = Mathf.Clamp(Table_Transform.localScale.z, minScale, maxScale);

            Table_Transform.localScale = new Vector3(Table_X, Table_Y, Table_Z);
        }
    }
}