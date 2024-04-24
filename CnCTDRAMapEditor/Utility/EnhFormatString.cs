﻿//         DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//                     Version 2, December 2004
//
//  Copyright (C) 2004 Sam Hocevar<sam@hocevar.net>
//
//  Everyone is permitted to copy and distribute verbatim or modified
//  copies of this license document, and changing it is allowed as long
//  as the name is changed.
//
//             DO WHAT THE FUCK YOU WANT TO PUBLIC LICENSE
//    TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION
//
//   0. You just DO WHAT THE FUCK YOU WANT TO.
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MobiusEditor.Utility
{
    /// <summary>
    /// When feeding strings into string.Format() as arguments, casting them to this class allows the use of enhanced formatting options.
    /// {0:X} will cut off the string argument at X characters. {0:X-Y} will cut out the substring from index X to Y.
    /// Based on https://stackoverflow.com/a/57704658/395685
    /// </summary>
    public struct EnhFormatString : IFormattable
    {
        private static readonly Regex FormatRegex = new Regex("^(\\d+)(?:-(\\d+))?$", RegexOptions.Compiled);
        public readonly string _string;
        public EnhFormatString(string str)
        {
            _string = str;
        }

        public override string ToString()
           => this.ToString(String.Empty, CultureInfo.CurrentCulture);
        public string ToString(string format)
           => this.ToString(format, CultureInfo.CurrentCulture);

        public string ToString(string format, IFormatProvider provider)
        {
            if (provider == null)
                provider = CultureInfo.CurrentCulture;
            if (String.IsNullOrEmpty(format))
            {
                return _string;
            }
            Match match = FormatRegex.Match(format);
            if (!match.Success)
            {
                throw new FormatException(String.Format( "Format string \"{0}\" is not supported.", format));
            }
            bool singleIndex = match.Groups[2].Value.Length == 0;
            int index1 = Math.Min(_string.Length, Int32.Parse(match.Groups[1].Value));
            int index2 = singleIndex ? 0 : Math.Min(_string.Length, Int32.Parse(match.Groups[2].Value));
            // impossible case: second index is smaller than first. Return empty.
            if (!singleIndex)
            {
                if (index2 == index1)
                {
                    return string.Empty;
                }
                if (index2 < index1)
                {
                    throw new FormatException(String.Format("Bad format string \"{0}\": end index is lower than start index.", format));
                }
                return _string.Substring(index1, index2 - index1);
            }
            // end point is greater than or equal to length: return whole string.
            if (index1 == _string.Length)
            {
                return _string;
            }
            return _string.Substring(0, index1);
        }

        public static implicit operator EnhFormatString(string code)
           => new EnhFormatString(code);
        public static implicit operator string(EnhFormatString language)
           => language._string;
    }
}

