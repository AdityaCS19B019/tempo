
using UnityEngine;

public class playercamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 dis;
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + dis ;
    }
}
