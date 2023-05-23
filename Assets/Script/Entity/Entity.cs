using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private string m_name;
    [SerializeField] private string m_id;

    public string GetName() => m_name;

    public string GetID() => m_id;
}
