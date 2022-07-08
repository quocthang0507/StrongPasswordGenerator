namespace PasswordLib
{
    public class Constants
    {
        public static readonly int PASSWORD_LENGTH = 12;

        public static readonly int NON_ALPHABET_LENGTH = 3;

        public static readonly char[] SPECIAL_CHARACTERS =
        {
            '!','@','#','$','%','^','&','*','(',')',
            '-','_','"','\'','+',',','.','/',':',';',
            '<','=','>','?','\\','[',']','{','}','~',
            '`'
        };

        public static readonly char[] UPPER_CHARACTERS =
        {
            'A','B','C','D','E','F','G','H','I','J','K','L',
            'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        public static readonly char[] LOWER_CHARACTERS =
        {
            'a','b','c','d','e','f','g','h','i','j','k','l',
            'm','n','o','p','q','r','s','t','u','v','w','x','y','z'
        };

        public static readonly char[] NUMBERS =
        {
            '0','1','2','3','4','5','6','7','8','9'
        };

        public static readonly List<string[]> SIMILARITIES = new()
        {
            new string[]{"a","ci","@"},
            new string[]{"A","fi","4"},
            new string[]{"b","G","6"},
            new string[]{"B","8","I3","l3"},
            new string[]{"c","C","("},
            new string[]{"d","cl"},
            new string[]{"e","3"},
            new string[]{"g","q","9","cj"},
            new string[]{"k","K","|<"},
            new string[]{"l","L","i","L","|","j","1"},
            new string[]{"m","rn"},
            new string[]{"M","|V|","|v|","/v\\","/V\\"},
            new string[]{"N","|\\|"},
            new string[]{"R","Pv"},
            new string[]{"s","S","5"},
            new string[]{"v","V","U","\\/"},
            new string[]{"w","W","vv","VV","vV","Vv"},
            new string[]{"z","Z","2"},
            new string[]{"0","o","O"},
        };
    }
}