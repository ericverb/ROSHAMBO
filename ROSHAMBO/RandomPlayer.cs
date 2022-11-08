namespace ROSHAMBO
{
    public class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name)
        {
            Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int returnValue = random.Next(0, 2);

            switch (returnValue)
            {
                case 0:
                    return Roshambo.Rock;

                case 1:
                    return Roshambo.Paper;

                default:
                    return Roshambo.Scissors;
            }
        }
    }
}