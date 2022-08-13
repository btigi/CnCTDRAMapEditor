﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MobiusEditor.Utility
{
    public class ExplorerComparer : IComparer<string>
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        static extern int StrCmpLogicalW(String x, String y);

        public int Compare(string x, string y)
        {
            return StrCmpLogicalW(x, y);
        }
    }

    public static class GeneralUtils
    {

        public static String MakeNew4CharName(IEnumerable<string> currentList, string fallback, params string[] reservedNames)
        {
            string name = string.Empty;
            // generate names in a way that will never run out before some maximum is reached.
            for (int i = 'a'; i <= 'z'; ++i)
            {
                for (int j = 'a'; j <= 'z'; ++j)
                {
                    for (int k = 'a'; k <= 'z'; ++k)
                    {
                        for (int l = 'a'; l <= 'z'; ++l)
                        {
                            name = String.Concat((char)i, (char)j, (char)k, (char)l);
                            if (!currentList.Contains(name, StringComparer.InvariantCultureIgnoreCase) && !reservedNames.Contains(name, StringComparer.InvariantCultureIgnoreCase))
                            {
                                return name;
                            }
                        }
                    }
                }
            }
            return fallback;
        }

        public static string TrimRemarks(string value, bool trimResult, params char[] cutFrom)
        {
            if (String.IsNullOrEmpty(value))
                return value;
            int index = value.IndexOfAny(cutFrom);
            if (index == -1)
                return value;
            value = value.Substring(0, index);
            if (trimResult)
                value = value.TrimEnd();
            return value;
        }

        public static string AddRemarks(string value, string defaultVal, Boolean trimSource, IEnumerable<string> valuesToDetect, string remarkToAdd)
        {
            if (String.IsNullOrEmpty(value))
                return defaultVal;
            string valTrimmed = value;
            if (trimSource)
                valTrimmed = valTrimmed.Trim();
            foreach (string val in valuesToDetect)
            {
                if ((val ?? String.Empty).Trim().Equals(value, StringComparison.InvariantCultureIgnoreCase))
                {
                    return valTrimmed + remarkToAdd;
                }
            }
            return value;
        }

        public static string FilterToExisting(string value, string defaultVal, Boolean trimSource, IEnumerable<string> existing)
        {
            if (String.IsNullOrEmpty(value))
                return defaultVal;
            string valTrimmed = value;
            if (trimSource)
                valTrimmed = valTrimmed.Trim();
            foreach (string val in existing)
            {
                if ((val ?? String.Empty).Trim().Equals(value, StringComparison.InvariantCultureIgnoreCase))
                {
                    return value;
                }
            }
            return defaultVal;
        }

        public static StringBuilder TrimEnd(this StringBuilder sb, params char[] toTrim)
        {
            if (sb == null || sb.Length == 0) return sb;
            int i = sb.Length - 1;
            if (toTrim.Length > 0)
            {
                for (; i >= 0; --i)
                    if (!toTrim.Contains(sb[i]))
                        break;
            }
            else
            {
                for (; i >= 0; --i)
                    if (!char.IsWhiteSpace(sb[i]))
                        break;
            }
            if (i < sb.Length - 1)
                sb.Length = i + 1;
            return sb;
        }
    }
}
