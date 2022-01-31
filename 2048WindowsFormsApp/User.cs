namespace _2048WindowsFormsApp
{
    public class User
    {
        public string Name;
        public int Score;
        public User(string name)
        {
            Name = name;
            Score = 0;
        }

        public void AcceptScore(int score)
        {
            Score = score;
        }
    }
}
