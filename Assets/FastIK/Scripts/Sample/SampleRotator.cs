using UnityEngine;

namespace DitzelGames.FastIK
{
    public class SampleRotator : MonoBehaviour
    {
        public float speed;

        void Update()
        {
            //just rotate the object
            transform.Rotate(0, Time.deltaTime * speed, 0);
        }
    }
}
