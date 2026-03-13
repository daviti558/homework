
using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp16;

internal class MyString
{
    public static int Length(string l)
    {
        int count = 0;
        if (l == null) { return 0; }
        foreach (char a in l)
        {
            count++;
        }

        return count;
    }
    public static bool Equals(string a, string b)
    {
        if (a == null && b == null)
        {
            return true;
        }
        else if (a == null || b == null)
        {
            return false;
        }
        else if (a.Length != b.Length)
        {
            return false;
        }

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }

        return true;
    }
    public static bool StartsWith(string a, string b)
    {
        if (a == null)
        {
            return false;
        }
        if (b.Length > a.Length) return false;
        for (int i = 0; i < b.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
        return true;
    }
    public static bool EndsWith(string a, string b)
    {
        if (a == null || b == null)
            return false;

        if (b.Length > a.Length)
            return false;

        for (int i = 0; i < b.Length; i++)
        {
            if (a[a.Length - b.Length + i] != b[i])
                return false;
        }

        return true;
    }
    public static bool Contains(string a, string b)
    {
        if (a == null || b == null) return false;
        if (b.Length > a.Length) return false;


        for (int i = 0; i <= a.Length - b.Length; i++)
        {
            bool match = true;


            for (int j = 0; j < b.Length; j++)
            {
                if (a[i + j] != b[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                return true;
        }

        return false;
    }
    public static string ToUpper(string a)
    {
        StringBuilder StringBuilder = new StringBuilder();
        foreach (char c in a)
        {
            if ((int)c >= 97 && (int)c <= 122)
                StringBuilder.Append((char)(c - 32));
            else
            {
                StringBuilder.Append(c);
            }

        }

        return StringBuilder.ToString();
    }
    public static string ToLower(string a)
    {
        StringBuilder StringBuilder = new StringBuilder();
        foreach (char c in a)
        {
            if ((int)c >= 65 && (int)c <= 90)
                StringBuilder.Append((char)(c + 32));
            else
            {
                StringBuilder.Append(c);
            }

        }

        return StringBuilder.ToString();
    }
    public static int IndexOf(string a, char b)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b)
            {
                return i;
            }

        }
        return -1;
    }
    public static int LastIndexOf(string a, char b)
    {
        {
            int c = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    c = i;
                }

            }
            return c;
        }
    }
    public static string substring(string a, int b, int c)
    {
        {

            string d = "";
            for (int i = b; i < b + c; i++)
            {
                d += a[i];


            }
            return d;
        }
    }
    public static string substring(string a, int b)
    {
        {

            string d = "";
            for (int i = b; i < a.Length; i++)
            {
                d += a[i];

            }
            return d;
        }
    }
    public static string Replace(string a, char b, char c)
    {
        string d = "";

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == b)
            {
                d += c;
            }
            else
            {
                d += a[i];
            }
        }

        return d;
    }
    public static string Replace(string a, string b, string c)
    {
        string d = "";
        int i = 0;
        while (i < a.Length)
        {
            if (i + b.Length <= a.Length)
            {
                string f = MyString.substring(a, i, b.Length);
                if (MyString.Equals(f, b))
                {
                    d += c;
                    i += b.Length;
                }
                else  
                {
                    d += a[i];
                    i += 1;
                }
            }
            else 
            {
                d += a[i];
                i += 1;
            }
        }

        return d;
    }
    public static string Trim(string a)
    {
        int b =0;
        int c = a.Length - 1;
        for (int i = 0; i<a.Length; i++)
        {
            if (a[i] !=' ')
            {
                b = i;
                break;
            }
        }
        for (int i = a.Length - 1; i >=0; i--)
        {
            if (a[i] !=' ')
            {
                 c = i;
                break;
            }
        }
        return substring(a, b, c - b + 1);
    }
    public static string TrimStart(string a)
    {
        int b = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != ' ')
            {
                b = i;
                break;
            }
        }

        return substring(a, b, a.Length - b);
    }
    public static string TrimEnd(string a)
    {
        int b = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            if (a[i] != ' ')
            {
                b = i;
                break;
            }
        }
        return substring(a, 0, b + 1);
    }
      public static string Remove(string a, int b)
  {
      string c =  substring(a, 0, b);
      return c;
  }
  public static string Remove(string a, int b,int c)
  {
      string d = substring(a, 0, b);
      string e = substring(a, b + c);

      return d + e;
  }
  public static string Insert(string a, string b, int c)
  {
      string result = "";
      for (int i = 0; i <a.Length; i++)
      {
          if (i == c)
          {
              result += b;
    
          }
          result += a[i];
      }
      return result;
  }
  public static string padleft(string a, int b)
  {
      string c = "";
      int d = b - a.Length;
      for (int i = 0; i< d; i++)
      {
          c += ' ';
      }
      c += a;
      return c;
  }
  public static bool IsNullorEmpty(string a)
  {
      if (a == null || a.Length == 0)
      {
          return true;
      }
      else return false;
  }
  public static bool IsNullorWhtespace(string a)
  {
      if (a == null || a.Trim() == "")
      {
          return true;
      }
      else return false;
  }
}
