namespace ROSHAMBO
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            switch (Roshambo)
            {
                case Roshambo.Rock:
                    return Roshambo.Rock;
                case Roshambo.Paper:
                    return Roshambo.Paper;
                default:
                    return Roshambo.Scissors;
            }
        }
    }
}