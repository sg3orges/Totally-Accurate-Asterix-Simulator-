namespace TAAS;

public class MyRandom
{
    public int _seed;
    public int seed
    {

        get
        {
            _seed = (int)(8944 * Math.Sqrt(_seed + 42) % 5150757);
            return _seed;
        }
        set { _seed = value; }
    }

    public MyRandom(int s)
    {
        _seed = s;
    }


    public int Next(int max = int.MaxValue)
    {
        int n = seed % (max - 0) + 0;
        return n;
    }

    public int NextMin(int min, int max)
    {
        int nm = seed % (max - min) + min;
        return nm;
    }
    
    


   

   
    
    
    
}