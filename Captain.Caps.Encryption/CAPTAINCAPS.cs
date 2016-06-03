using System.Collections.Generic;
using System.Linq;

namespace Captain.Caps.Encryption
{
    public class CAPTAINCAPS : ICAPTAINCAPS
    {
        private readonly Dictionary<char, char> _translationTable = new Dictionary<char, char>
        {
            {'1', '!'},
            {'2', '@'},
            {'3', '#'},
            {'4', '$'},
            {'5', '%'},
            {'6', '^'},
            {'7', '&'},
            {'8', '*'},
            {'9', '('},
            {'0', ')'},
            {'-', '_'},
            {'=', '+'},
            {'`', '~'},
            {'[', '{'},
            {']', '}'},
            {'\\', '|'},
            {';', ':'},
            {'\'', '"'},
            {',', '<'},
            {'.', '>'},
            {'/', '?'}
        };

        public string Hash(string input)
        {
            return
                string.Concat(input.ToUpper().Select(c => _translationTable.ContainsKey(c) ? _translationTable[c] : c));
        }
    }

    public interface ICAPTAINCAPS
    {
        string Hash(string input);
    }
}