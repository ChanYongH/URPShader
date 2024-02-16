using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float m_Speed;
    [SerializeField] private float m_Sensitive;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        CameraRotation();
    }

    private void PlayerMove()
    {
        Vector3 t_Vec = transform.position;
        t_Vec.x += Input.GetAxisRaw("Horizontal") * Time.deltaTime * m_Speed;
        t_Vec.z += Input.GetAxisRaw("Vertical") * Time.deltaTime * m_Speed;
        transform.position = t_Vec;
    }
    private void CameraRotation()
    {
        Debug.Log($"Input.mousePosition : {Input.mousePosition}");
        float t_Horizontal = Input.mousePosition.x / 100 * m_Sensitive;
        float t_Vertical = -Mathf.Clamp(Input.mousePosition.y / 100 * m_Sensitive, -80, 80);
        transform.rotation = Quaternion.Euler(new Vector3(t_Vertical, t_Horizontal, 0));
    }
}
