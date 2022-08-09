using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4BoundList : MonoBehaviour
{
    public PolygonCollider2D entrance_;
    public PolygonCollider2D main_;
    public PolygonCollider2D room_;
    public PolygonCollider2D end_;

    public static A4BoundList Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    public void entrance() => ExBounds.Instance.setBound(entrance_);
    public void main() => ExBounds.Instance.setBound(main_);
    public void room() => ExBounds.Instance.setBound(room_);
    public void end() => ExBounds.Instance.setBound(end_);
}
