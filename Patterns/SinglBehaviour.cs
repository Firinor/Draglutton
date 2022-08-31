using UnityEngine;

public class SinglBehaviour<T> : MonoBehaviour
{
    public static T instance;

    public void SingletoneCheck(T instance)
    {
        if (SinglBehaviour<T>.instance != null && !SinglBehaviour<T>.instance.Equals(instance))
        {
            Destroy(gameObject);
            return;
        }

        SinglBehaviour<T>.instance = instance;
    }
}