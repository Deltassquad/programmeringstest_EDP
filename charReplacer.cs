using Microsoft.VisualBasic;

namespace WindowsApplication1
{
    class charReplacer
    {
        private string at = "@";
        private string perc = "%";

        public string ReplaceCharachtersToSpace(string s)
        {
            if (s == null)
			{
				return "";
			}
			string s2 = "";
			for (int i = 1; i <= s.Length; i++)
            {
                if (Strings.Mid(s, i, 1) == at | Strings.Mid(s, i, 1) == perc)
                {
                    s2 = s2 + " ";
                }
                else
                {
                    s2 = s2 + Strings.Mid(s, i, 1);
                }
            }
            return s2;
        }

    }
}
