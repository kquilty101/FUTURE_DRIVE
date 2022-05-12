using UnityEngine; 
using UnityEngine.UI; 

public class DemoGetSpeed : MonoBehaviour 
{ 
    private Vector3 m_LastPosition; 
    public float m_Speed; 
    public Text m_MeterPerSecond, m_KilometersPerHour; 

    void FixedUpdate() 
    { 
        m_Speed = GetSpeed(); 
        m_MeterPerSecond.text = string.Format("{0:00.00} m/s", m_Speed); 
        m_KilometersPerHour.text = string.Format("{0:00.00} km/h", m_Speed * 3.6f); 
    } 

    float GetSpeed() 
    { 
        float speed = (((transform.position - m_LastPosition).magnitude) / Time.deltaTime); 
        m_LastPosition = transform.position; 

        return speed; 
    } 
}