using UnityEngine;

public class Entity_AnimaionTiggers : MonoBehaviour
{
    private Entity entity;

    public void Awake()
    {
        entity = GetComponentInParent<Entity>();
    }

    private void CurrentStateTrigger()
    {
        entity.CallAnimationTrigger();
    }


}
