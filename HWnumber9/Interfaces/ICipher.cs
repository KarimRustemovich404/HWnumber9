namespace HWnumber9.Interfaces
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}
