using UnityEngine;

public abstract class EntityState
{
    protected Player player;
    protected StateMachine stateMachine;
    protected string animBoolName;

    protected Animator anim;

    public EntityState(Player player, StateMachine stateMachine, string animBoolName)
    {
        this.player = player;
        this.stateMachine = stateMachine;
        this.animBoolName = animBoolName;

        anim = player.anim;
    }

    public virtual void Enter()
    {
        player.anim.SetBool(animBoolName, true);
        //Debug.Log($"I enter {animBoolName}");
    }

    public virtual void Update()
    {
        Debug.Log($"I run update of {animBoolName}");
    }

    public virtual void Exit() 
    {
        player.anim.SetBool(animBoolName, false);
        //Debug.Log($"I exit {animBoolName}");
    }
}
