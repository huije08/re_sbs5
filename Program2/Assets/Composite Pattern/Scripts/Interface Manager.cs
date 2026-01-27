 public interface IRewardable
{
    public void Receive();

}

public interface IStateable
{
    public void Enter(Chaeacter chaeacter);

    public void Update(Chaeacter chaeacter);
    public void Exit(Chaeacter chaeacter);

}
