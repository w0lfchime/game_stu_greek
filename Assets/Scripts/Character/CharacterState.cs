

/// <summary>
/// Abstract class state to manage state transitions 
/// </summary>
public abstract class CharacterState
{
    public CharacterCore ch;

    public CharacterState(CharacterCore character)
    {
        this.ch = character;
    }

    public virtual void Enter() { }
    public virtual void Exit() { }
    public virtual void Update() { }

    public virtual void FixedUpdate() { }

    public virtual void LateUpdate() { }

}
