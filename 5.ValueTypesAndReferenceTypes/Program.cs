State state1 = new State();
Country country1 = new Country();

struct State
{
    public int x;
    public int y;
    public Country country;
    public State()
    {
        x = 0;
        y = 0;
        country = new Country();
    }
}
class Country
{
    public int x;
    public int y;
}