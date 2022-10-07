using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform MainCamT;
    public Transform SnowStormT;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        //SnowStormT.position = Vector3.Lerp(SnowStormT.position, MainCamT.position, 1f * Time.deltaTime);
        SnowStormT.position = MainCamT.position;
    }
}