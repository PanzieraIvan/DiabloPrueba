using UnityEngine;
using UnityEngine.UI;


public class PlayableCharacter : Entity
{
    public float m_maxHealth = 1f;
    public Slider m_slider;
    public float m_speed;
    public float m_rotation;
    public Animator m_animation;

    

    



    protected void MoveCharacter(Vector3 p_direction)
    {
        transform.position += p_direction * (m_speed * Time.deltaTime);
    }
}
